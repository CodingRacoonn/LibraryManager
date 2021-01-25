CREATE PROCEDURE [dbo].[spBook_GetAll]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity, AvailableQuantity
	FROM dbo.Book
	ORDER BY Title;
END
