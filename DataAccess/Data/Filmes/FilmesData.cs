using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Filmes;
public class FilmesData : IFilmesData
{
    private readonly ISqlDataAccess _db;

    public FilmesData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<FilmesModel>> GetFilmes() => _db.LoadData<FilmesModel, dynamic>("dbo.spFilmes_GetAll", new { });

    public async Task<FilmesModel?> GetFilme(int id)
    {
        var results = await _db.LoadData<FilmesModel, dynamic>("dbo.spFilmes_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task UpdateFilme(FilmesModel filme) => _db.SaveData("dbo.spFilmes_Update", filme);

    public Task InsertFilme(FilmesModel filme) => _db.SaveData("dbo.spFilmes_Insert", new { filme.Nome, filme.Ano });

    public Task DeleteFilme(int id) => _db.SaveData("dbo.spFilmes_Delete", new { Id = id });
}
