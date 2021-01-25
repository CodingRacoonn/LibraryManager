CREATE PROCEDURE [dbo].[spBookRent_AddBookRent_WithAQ]
	@BookId int,
	@UserId NVARCHAR (450),
	@ExpectedReturnDate datetime2
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.BookRent(BookId, UserId,ExpectedReturnDate)
	VALUES (@BookId, @UserId, @ExpectedReturnDate);

	UPDATE dbo.Book
	SET AvailableQuantity = AvailableQuantity - 1
	WHERE Id = @BookId;
END





