CREATE PROCEDURE [dbo].[spPenalty_GetByUserId]
	@userId NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT b.Id, b.Title, b.AuthorFirstName, b.AuthorLastName, br.RentDate, br.ReturnDate, p.Payment, p.PaymentDate
	FROM dbo.Penalty AS p
	INNER JOIN dbo.BookRent AS br ON p.BookRentId = br.Id
	INNER JOIN dbo.[User] AS u ON p.UserId = u.Id
	INNER JOIN dbo.Book AS b ON br.BookId = b.Id
	WHERE u.Id = @userId;
END
