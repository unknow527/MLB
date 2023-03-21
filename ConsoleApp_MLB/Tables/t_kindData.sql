CREATE TABLE [dbo].[t_kindData] (
    [f_dataId]   INT            IDENTITY (1, 1) NOT NULL,
    [f_kindId]   TINYINT        NOT NULL,
    [f_dataName] NVARCHAR (50)  NOT NULL,
    [f_desc]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_dataId] ASC)
);