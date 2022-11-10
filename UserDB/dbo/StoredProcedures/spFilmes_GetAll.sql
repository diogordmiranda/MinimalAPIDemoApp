CREATE PROCEDURE [dbo].[spFilmes_GetAll]
AS
BEGIN
	SELECT Id, Nome, Ano
	FROM dbo.[Filmes]
END