CREATE PROCEDURE [dbo].[spBook_GetAll]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity
	FROM dbo.Book
	ORDER BY Title;
END
