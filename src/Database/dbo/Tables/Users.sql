CREATE TABLE [dbo].[Users] (
    [ID]           INT           IDENTITY(1,1) NOT NULL,
    [UserName]     NCHAR (20)    NULL,
    [Mail]         NCHAR (30)    NOT NULL,
    [PasswordHash] NVARCHAR (50) NULL,
    CONSTRAINT [PK_authors] PRIMARY KEY CLUSTERED ([ID] ASC)
);

