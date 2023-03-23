CREATE TABLE [dbo].[t_kind] (
    [f_kindId]   TINYINT        NOT NULL,
    [f_kindName] NVARCHAR (50)  NOT NULL,
    [f_desc]     NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_kindId] ASC)
);

INSERT INTO [dbo].[t_kind] ([f_kindId], [f_kindName], [f_desc])
VALUES (1, 'team', '¶¤¥î'),
       (2, 'allay', 'Áp·ù'),
       (3, 'player', '§ë¤â');