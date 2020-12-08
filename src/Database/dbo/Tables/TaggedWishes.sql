CREATE TABLE [dbo].[TaggedWishes] (
    [Wish_id] INT NOT NULL,
    [Tag_id]  INT NOT NULL,
    CONSTRAINT [FK_tagged_wishes_tag_id] FOREIGN KEY ([Tag_id]) REFERENCES [dbo].[Tags] ([id]),
    CONSTRAINT [FK_tagged_wishes_wish_id] FOREIGN KEY ([Tag_id]) REFERENCES [dbo].[Wishes] ([Id])
);

