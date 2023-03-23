CREATE TABLE [dbo].[t_source] (
    [f_souceId]   TINYINT        NOT NULL,
    [f_souceName] NVARCHAR (50)  NOT NULL,
    [f_desc]      NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_souceId] ASC)
);

INSERT INTO [dbo].[t_source] ([f_souceId], [f_souceName], [f_desc])
VALUES (1, 'yahoo', NULL),
       (2, 'espn', NULL);