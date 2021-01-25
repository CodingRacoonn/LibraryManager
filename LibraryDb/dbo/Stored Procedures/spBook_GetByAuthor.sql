CREATE PROCEDURE [dbo].[spBook_GetByAuthor]
	@AuthorFirstName nvarchar(50),
	@AuthorLastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity, AvailableQuantity
	FROM dbo.Book
	WHERE AuthorFirstName = @AuthorFirstName OR @AuthorLastName = AuthorLastName
END
