﻿CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id NVARCHAR (450)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT FirstName, LastName, EmailAddress, CreatedDate
	FROM dbo.[User]
	WHERE Id = @Id
END
