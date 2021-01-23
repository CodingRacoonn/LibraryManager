CREATE PROCEDURE [dbo].[SpBookGenre_GetByBookId]
	@bookId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT g.[Name]
	FROM dbo.BookGenre AS bg
	INNER JOIN dbo.Genre AS g ON bg.GenreId = g.Id
	INNER JOIN dbo.Book AS b ON bg.BookId = b.Id
	WHERE b.Id = @bookId
END
