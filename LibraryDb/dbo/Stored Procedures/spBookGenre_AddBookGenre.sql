CREATE PROCEDURE [dbo].[spBookGenre_AddBookGenre]
	@GenreId int,
	@BookId int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.BookGenre(GenreId, BookId)
	VALUES (@GenreId,@BookId);
END
