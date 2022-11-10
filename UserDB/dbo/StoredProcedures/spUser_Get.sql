CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
BEGIN
	SELECT Id, Nome, Sobrenome
	FROM dbo.[User]
	WHERE Id = @Id
END