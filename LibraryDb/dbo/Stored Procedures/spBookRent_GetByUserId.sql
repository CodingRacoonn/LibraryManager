CREATE PROCEDURE [dbo].[spBookRent_GetByUserId]
	@UserId NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT br.BookId, br.RentDate, br.ReturnDate, br.ExpectedReturnDate, br.ProlongCount, b.Title, b.AuthorFirstName, b.AuthorLastName, b.Publisher 
	FROM dbo.BookRent AS br
	INNER JOIN dbo.Book AS b ON br.BookId = b.Id
	INNER JOIN dbo.[User] AS u ON br.UserId = u.Id
	WHERE u.Id = @UserId;
END
