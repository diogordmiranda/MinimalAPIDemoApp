CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
BEGIN
	SELECT Id, Nome, Sobrenome
	FROM dbo.[User]
END