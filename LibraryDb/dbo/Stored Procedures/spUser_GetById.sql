CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, FirstName, LastName, EmailAddress
	FROM dbo.[User]
	WHERE Id = @Id
END
