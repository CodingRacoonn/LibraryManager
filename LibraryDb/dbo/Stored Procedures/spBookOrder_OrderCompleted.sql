CREATE PROCEDURE [dbo].[spBookOrder_OrderCompleted]
	@UserId NVARCHAR (450),
	@BookId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.BookOrder
	SET OrderComplete = 1
	WHERE UserId = @UserId and BookId = @BookId;

END
