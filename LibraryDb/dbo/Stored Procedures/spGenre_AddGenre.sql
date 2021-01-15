CREATE PROCEDURE [dbo].[spGenre_AddGenre]
	@Name nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Genre([Name])
	VALUES (@Name);
END
