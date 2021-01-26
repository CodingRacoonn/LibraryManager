CREATE PROCEDURE [dbo].[spPenalty_AddPenalty]
	@BookRentId int, 
	@BookId int,
	@UserId NVARCHAR (450),
	@Payment money
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Penalty(BookRentId, BookId, UserId, Payment)
	VALUES (@BookRentId,@BookId,@UserId,@Payment);
END
