CREATE PROCEDURE [dbo].[spPenalty_AddPenalty]
	@BookRentId int, 
	@BookId int,
	@UserId NVARCHAR (450),
	@PaymentDate datetime2,
	@Payment money
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Penalty(BookRentId, BookId, UserId, PaymentDate, Payment)
	VALUES (@BookRentId,@BookId,@UserId,@PaymentDate,@Payment);
END
