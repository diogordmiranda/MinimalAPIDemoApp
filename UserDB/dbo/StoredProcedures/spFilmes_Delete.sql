CREATE PROCEDURE [dbo].[spFilmes_Delete]
	@Id int
AS
BEGIN
	DELETE
	FROM dbo.[Filmes]
	WHERE Id = @Id
END