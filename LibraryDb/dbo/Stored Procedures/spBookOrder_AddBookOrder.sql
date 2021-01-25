CREATE PROCEDURE [dbo].[spBookOrder_AddBookOrder]
	@BookId int,
	@UserId NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.BookRent(BookId, UserId)
	VALUES (@BookId, @UserId);

	UPDATE dbo.Book
	SET AvailableQuantity = AvailableQuantity - 1
	WHERE Id = @BookId;
END

