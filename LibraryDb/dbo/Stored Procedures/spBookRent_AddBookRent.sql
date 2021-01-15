CREATE PROCEDURE [dbo].[spBookRent_AddBookRent]
	@BookId int,
	@UserId int,
	@ReturnDate datetime2
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.BookRent(BookId, UserId, ReturnDate)
	VALUES (@BookId, @UserId, @ReturnDate);
END
