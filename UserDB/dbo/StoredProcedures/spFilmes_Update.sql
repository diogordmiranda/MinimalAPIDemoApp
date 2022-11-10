CREATE PROCEDURE [dbo].[spFilmes_Update]
	@Id int,
	@Nome nvarchar(50),
	@Ano datetime
AS
BEGIN
	UPDATE dbo.[Filmes]
	SET Nome = @Nome, Ano = @Ano
	WHERE Id = @Id
END
	