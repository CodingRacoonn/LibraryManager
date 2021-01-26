CREATE TABLE [dbo].[BookRent]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookId] INT NOT NULL, 
    [UserId] NVARCHAR (450) NOT NULL, 
    [RentDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ExpectedReturnDate] DATETIME2 NOT NULL, 
    [ReturnDate] DATETIME2 NULL, 
    [ProlongCount] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_BookRent_ToBook] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_BookRent_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]) ON DELETE CASCADE
)
