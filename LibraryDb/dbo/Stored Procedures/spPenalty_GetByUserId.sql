CREATE PROCEDURE [dbo].[spPenalty_GetByUserId]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT b.Title, b.AuthorFirstName, b.AuthorLastName, br.RentDate, br.ReturnDate, p.Payment, p.Paid, p.RealReturnDate
	FROM dbo.Penalty AS p
	INNER JOIN dbo.BookRent AS br ON p.BookRentId = br.Id
	INNER JOIN dbo.[User] AS u ON p.UserId = u.Id
	INNER JOIN dbo.Book AS b ON br.BookId = b.Id
	WHERE u.Id = @Id
END