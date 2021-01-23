CREATE PROCEDURE [dbo].[spBookRent_ProlongReturnDate]
	@BookId int,
	@UserId NVARCHAR (450),
	@ExpectedReturnDate datetime2,
	@ProlongCount int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BookRent
	SET ExpectedReturnDate = @ExpectedReturnDate, ProlongCount = @ProlongCount
	WHERE BookId = @BookId and UserId = @UserId;
	
END
