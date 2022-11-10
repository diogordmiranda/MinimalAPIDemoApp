namespace MinimalAPIDemo;

public static class Filmes
{
    public static void ConfigureFilmes(this WebApplication app)
    {
        // All of my mapping 
        app.MapGet("/Filmes", GetFilmes);
        app.MapGet("/Filmes/{id}", GetFilme);
        app.MapPost("/Filmes", InsertFilme);
        app.MapPut("/Filmes", UpdateFilme);
        app.MapDelete("/Filmes", DeleteFilme);
    }

    private static async Task<IResult> GetFilmes(IFilmesData data)
    {
        try
        {
            return Results.Ok(await data.GetFilmes());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetFilme(int id, IFilmesData data)
    {
        try
        {
            var result = await data.GetFilme(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertFilme(FilmesModel user, IFilmesData data)
    {
        try
        {
            await data.InsertFilme(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateFilme(FilmesModel user, IFilmesData data)
    {
        try
        {
            await data.UpdateFilme(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteFilme(int id, IFilmesData data)
    {
        try
        {
            await data.DeleteFilme(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}