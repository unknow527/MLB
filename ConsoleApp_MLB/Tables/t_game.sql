CREATE TABLE [dbo].[t_game] (
    [f_gameId]     NVARCHAR (50) NOT NULL,
    [f_gameDate]   NVARCHAR (50)  NOT NULL,
    [f_gameStatus] TINYINT        NOT NULL,
    [f_teamAId]    INT            NOT NULL,
    [f_teamBId]    INT            NOT NULL,
    [f_ra]         TINYINT        NULL,
    [f_rb]         TINYINT        NULL,
    [f_playerAId]  INT            NULL,
    [f_playerBID]  INT            NULL,
    [f_sourceId]   TINYINT        NULL,
    [f_desc]       NVARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([f_gameId] ASC)
);