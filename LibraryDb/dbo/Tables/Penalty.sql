CREATE TABLE [dbo].[Penalty]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookRentId] INT NOT NULL, 
    [BookId] INT NOT NULL, 
    [UserId] NVARCHAR (450) NOT NULL, 
    [PaymentDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Payment] MONEY NOT NULL, 
    CONSTRAINT [FK_Penalty_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Penalty_ToBookRent] FOREIGN KEY ([BookRentId]) REFERENCES [BookRent]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_Penalty_ToBook] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id]) 
)
