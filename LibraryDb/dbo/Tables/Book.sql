CREATE TABLE [dbo].[Book]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [AuthorFirstName] NVARCHAR(50) NOT NULL, 
    [AuthorLastName] NVARCHAR(50) NOT NULL, 
    [Publisher] NVARCHAR(50) NOT NULL, 
    [ReleaseDate] DATETIME2 NOT NULL, 
    [Quantity] INT NOT NULL
)
