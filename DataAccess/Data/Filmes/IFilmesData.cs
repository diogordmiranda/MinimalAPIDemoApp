using DataAccess.Models;

namespace DataAccess.Data.Filmes;
public interface IFilmesData
{
    Task DeleteFilme(int id);
    Task<FilmesModel?> GetFilme(int id);
    Task<IEnumerable<FilmesModel>> GetFilmes();
    Task InsertFilme(FilmesModel filme);
    Task UpdateFilme(FilmesModel filme);
}