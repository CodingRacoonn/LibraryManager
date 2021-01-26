CREATE PROCEDURE [dbo].[spBook_CheckAQById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON
	SELECT AvailableQuantity
	FROM dbo.Book
	WHERE Id = @Id;
END