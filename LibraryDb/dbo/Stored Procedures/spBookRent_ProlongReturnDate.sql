CREATE PROCEDURE [dbo].[spBookRent_ProlongReturnDate]
	@BookId int,
	@UserId NVARCHAR (450),
	@ExpectedReturnDate datetime2
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BookRent
	SET ExpectedReturnDate = @ExpectedReturnDate, ProlongCount = ProlongCount + 1
	WHERE BookId = @BookId and UserId = @UserId;
	
END
