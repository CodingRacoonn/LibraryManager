CREATE PROCEDURE [dbo].[spBook_AddBook]
	@Title nvarchar(50),
	@AuthorFirstName nvarchar(50),
	@AuthorLastName nvarchar(50),
	@Publisher nvarchar(50),
	@Description nvarchar(MAX),
	@ReleaseDate datetime2,
	@Quantity int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Book(Title, AuthorFirstName, AuthorLastName, Publisher, [Description], ReleaseDate, Quantity)
	VALUES (@Title, @AuthorFirstName, @AuthorLastName, @Publisher, @Description, @ReleaseDate, @Quantity);
END