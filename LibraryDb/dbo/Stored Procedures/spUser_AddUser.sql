CREATE PROCEDURE [dbo].[spUser_AddUser]
	@Id NVARCHAR (450),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.[User](Id,FirstName, LastName, EmailAddress)
	VALUES (@Id,@FirstName, @LastName, @EmailAddress);
END

