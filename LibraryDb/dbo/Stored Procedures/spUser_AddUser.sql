CREATE PROCEDURE [dbo].[spUser_AddUser]
	@Id int output,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.[User](FirstName, LastName, EmailAddress)
	VALUES (@FirstName, @LastName, @EmailAddress);
	SELECT @Id = Scope_Identity();
END

