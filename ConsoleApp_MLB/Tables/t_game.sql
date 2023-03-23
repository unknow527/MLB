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

INSERT INTO [dbo].[t_game] ([f_gameId], [f_gameDate], [f_gameStatus], [f_teamAId], [f_teamBId], [f_ra], [f_rb], [f_playerAId], [f_playerBId], [f_sourceId], [f_desc])
VALUES 
('2023-03-23_4_5', '2023-03-23', 1, 4, 5, 0, 0, 28, 29, 1, NULL),
('2023-03-23_6_7', '2023-03-23', 1, 6, 7, 0, 0, 30, 31, 1, NULL),
('2023-03-23_8_9', '2023-03-23', 1, 8, 9, 0, 0, 32, 33, 1, NULL),
('2023-03-23_10_11', '2023-03-23', 1, 10, 11, 0, 0, 34, 35, 1, NULL),
('2023-03-23_12_13', '2023-03-23', 1, 12, 13, 0, 0, 36, 37, 1, NULL);