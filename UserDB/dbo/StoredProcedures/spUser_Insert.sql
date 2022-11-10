CREATE PROCEDURE [dbo].[spUser_Insert]
	@Nome nvarchar(50),
	@Sobrenome nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.[User] (Nome, Sobrenome)
	VALUES (@Nome, @Sobrenome)
END
