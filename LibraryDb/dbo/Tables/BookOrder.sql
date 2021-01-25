CREATE TABLE [dbo].[BookOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(450) NOT NULL, 
    [BookId] INT NOT NULL, 
    [OrderDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
