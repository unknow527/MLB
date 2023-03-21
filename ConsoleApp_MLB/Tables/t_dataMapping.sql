CREATE TABLE [dbo].[t_dataMapping] (
    [f_dataId]   INT            NOT NULL,
    [f_sourceId] TINYINT        NOT NULL,
    [f_sdName]   NVARCHAR (50)  NOT NULL,
    [f_desc]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_dataId] ASC)
);
