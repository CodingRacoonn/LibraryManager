CREATE PROCEDURE [dbo].[spBookRent_AddBookRent]
	@BookId int,
	@UserId NVARCHAR (450),
	@ExpectedReturnDate datetime2
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.BookRent(BookId, UserId,ExpectedReturnDate)
	VALUES (@BookId, @UserId, @ExpectedReturnDate);
END
