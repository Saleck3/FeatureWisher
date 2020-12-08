CREATE TABLE [dbo].[Tags] (
    [id]          INT           IDENTITY(1,1) NOT NULL,
    [description] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED ([id] ASC)
);

