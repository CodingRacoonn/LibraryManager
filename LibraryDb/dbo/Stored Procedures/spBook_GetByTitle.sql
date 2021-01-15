CREATE PROCEDURE [dbo].[spBook_GetByTitle]
	@Title nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity
	FROM dbo.Book
	WHERE Title LIKE @Title + '%' OR Title LIKE @Title + ' %'
END
