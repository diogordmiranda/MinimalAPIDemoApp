CREATE PROCEDURE [dbo].[spFilmes_Get]
	@Id int
AS
BEGIN
	SELECT Id, Nome, Ano
	FROM dbo.[Filmes]
	WHERE Id = @Id
END
