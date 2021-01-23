CREATE TABLE [dbo].[Penalty] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [BookRentId]     INT           NOT NULL,
    [UserId]         INT           NOT NULL,
    [PaymentDate] DATETIME2 (7) NULL,
    [Payment]        MONEY         NOT NULL,
    [Paid]           BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Penalty_ToUser] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Penalty_ToBookRent] FOREIGN KEY ([BookRentId]) REFERENCES [dbo].[BookRent] ([Id])
);

