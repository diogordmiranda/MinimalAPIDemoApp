CREATE PROCEDURE [dbo].[spFilmes_Insert]
	@Nome nvarchar(50),
	@Ano datetime
AS
BEGIN
	INSERT INTO dbo.[Filmes] (Nome, Ano)
	VALUES (@Nome, @Ano)
END
