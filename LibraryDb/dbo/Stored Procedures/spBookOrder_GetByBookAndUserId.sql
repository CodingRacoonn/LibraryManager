CREATE PROCEDURE [dbo].[spBookOrder_GetByBookAndUserId]
	@UserId NVARCHAR (450),
	@BookId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT bo.OrderDate, b.Title, b.AuthorFirstName, b.AuthorLastName, b.Publisher 
	FROM dbo.BookOrder AS bo
	INNER JOIN dbo.Book AS b ON bo.BookId = b.Id
	WHERE bo.UserId = @UserId and bo.OrderComplete = 0 and bo.BookId = @BookId;

END