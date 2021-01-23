﻿CREATE PROCEDURE [dbo].[spBookRent_BookReturned]
	@BookId int,
	@UserId NVARCHAR (450),
	@ReturnDate datetime2
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BookRent
	SET ReturnDate = @ReturnDate
	WHERE BookId = @BookId and UserId = @UserId;
	
END
