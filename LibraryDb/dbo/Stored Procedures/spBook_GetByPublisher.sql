CREATE PROCEDURE [dbo].[spBook_GetByPublisher]
	@Publisher nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id, Title, [Description], AuthorFirstName, AuthorLastName, Publisher, ReleaseDate, Quantity, AvailableQuantity
	FROM dbo.Book
	WHERE Publisher LIKE @Publisher + '%' OR Publisher LIKE '% ' + @Publisher + '%';
END
