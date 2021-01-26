CREATE PROCEDURE [dbo].[spBook_GetByAuthor]
	@AuthorFirstName nvarchar(50),
	@AuthorLastName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity, AvailableQuantity
	FROM dbo.Book
	WHERE AuthorFirstName LIKE @AuthorFirstName + '%' OR AuthorFirstName LIKE '% ' + @AuthorFirstName + '%' OR AuthorLastName LIKE @AuthorLastName + '%' OR AuthorLastName LIKE '% ' + @AuthorLastName + '%'
END
