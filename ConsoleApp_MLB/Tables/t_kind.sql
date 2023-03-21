CREATE TABLE [dbo].[t_kind] (
    [f_kindId]   TINYINT        NOT NULL,
    [f_kindName] NVARCHAR (50)  NOT NULL,
    [f_desc]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_kindId] ASC)
);