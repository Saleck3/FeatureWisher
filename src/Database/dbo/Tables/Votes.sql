CREATE TABLE [dbo].[Votes] (
    [WishId] INT NOT NULL,
    [UserId] INT NOT NULL,
    [Amount] INT NOT NULL,
    CONSTRAINT [FK_Votes_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([ID]),
    CONSTRAINT [FK_Votes_Wish] FOREIGN KEY ([WishId]) REFERENCES [dbo].[Users] ([ID])
);

