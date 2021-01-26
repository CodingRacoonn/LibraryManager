CREATE PROCEDURE [dbo].[spBookRent_BookReturned]
	@BookId int,
	@UserId NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BookRent
	SET ReturnDate = GETUTCDATE()
	WHERE BookId = @BookId and UserId = @UserId;
	
	UPDATE dbo.Book
	SET AvailableQuantity = AvailableQuantity + 1
	WHERE Id = @BookId;
END

