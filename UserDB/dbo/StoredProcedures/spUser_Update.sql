CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Nome nvarchar(50),
	@Sobrenome nvarchar(50)
AS
BEGIN
	UPDATE dbo.[User]
	SET Nome = @Nome, Sobrenome = @Sobrenome
	WHERE Id = @Id
END
