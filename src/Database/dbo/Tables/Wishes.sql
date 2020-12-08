CREATE TABLE [dbo].[Wishes] (
    [Id]          INT            IDENTITY(1,1) NOT NULL,
    [Title]       NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [User_id]     INT            NOT NULL,
    CONSTRAINT [PK_Wishes_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Wishes_Users] FOREIGN KEY ([User_id]) REFERENCES [dbo].[Users] ([ID])
);

