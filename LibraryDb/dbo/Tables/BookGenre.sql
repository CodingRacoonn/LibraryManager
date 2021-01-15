CREATE TABLE [dbo].[BookGenre]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GenreId] INT NOT NULL, 
    [BookId] INT NOT NULL, 
    CONSTRAINT [FK_BookGenre_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id]), 
    CONSTRAINT [FK_BookGenre_ToBook] FOREIGN KEY ([BookId]) REFERENCES [Book]([Id])
)
