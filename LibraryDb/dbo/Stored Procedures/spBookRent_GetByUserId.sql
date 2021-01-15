CREATE PROCEDURE [dbo].[spBookRent_GetByUserId]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT br.RentDate, br.ReturnDate, br.ProlongCount, b.Title, b.AuthorFirstName, b.AuthorLastName, b.Publisher 
	FROM dbo.BookRent AS br
	INNER JOIN dbo.Book AS b ON br.BookId = b.Id
	INNER JOIN dbo.[User] AS u ON br.UserId = u.Id
	WHERE u.Id = @Id
END
