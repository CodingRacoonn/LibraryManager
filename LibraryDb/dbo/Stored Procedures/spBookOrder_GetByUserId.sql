CREATE PROCEDURE [dbo].[spBookOrder_GetByUserId]
	@UserId NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT bo.OrderDate, b.Title, b.AuthorFirstName, b.AuthorLastName, b.Publisher 
	FROM dbo.BookOrder AS bo
	INNER JOIN dbo.Book AS b ON bo.BookId = b.Id
	INNER JOIN dbo.[User] AS u ON bo.UserId = u.Id
	WHERE u.Id = @UserId;

END