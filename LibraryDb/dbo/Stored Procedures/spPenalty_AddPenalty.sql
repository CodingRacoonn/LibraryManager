CREATE PROCEDURE [dbo].[spPenalty_AddPenalty]
	@BookRentId int, 
	@UserId int,
	@RealReturnDate datetime2,
	@Payment money,
	@Paid bit
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Penalty(BookRentId, UserId, RealReturnDate, Payment, Paid)
	VALUES (@BookRentId,@UserId,@RealReturnDate,@Payment,@Paid);
END
