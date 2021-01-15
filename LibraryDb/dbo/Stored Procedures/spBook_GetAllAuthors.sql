CREATE PROCEDURE [dbo].[spBook_GetAllAuthors]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT AuthorFirstName, AuthorLastName
	FROM dbo.Book
	ORDER BY AuthorLastName;
END
