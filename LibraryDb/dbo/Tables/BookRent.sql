CREATE TABLE [dbo].[BookRent]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [RentDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ReturnDate] DATETIME2 NOT NULL, 
    [ProlongCount] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_BookRent_ToBook] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id]), 
    CONSTRAINT [FK_BookRent_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
