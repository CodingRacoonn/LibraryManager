CREATE TABLE [dbo].[Penalty]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookRentId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [RealReturnDate] DATETIME2 NULL, 
    [Payment] MONEY NOT NULL, 
    [Paid] BIT NULL, 
    CONSTRAINT [FK_Penalty_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Penalty_ToBookRent] FOREIGN KEY ([BookRentId]) REFERENCES [BookRent]([Id])
)
