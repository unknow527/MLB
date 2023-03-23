CREATE PROCEDURE [dbo].[SelectAllGames]
AS
	SELECT
		g.f_gameId, 
        g.f_gameDate, 
        g.f_gameStatus, 
        ta.f_dataName AS teamA, 
        tb.f_dataName AS teamB, 
        g.f_ra, 
        g.f_rb,
        pa.f_dataName AS playerA, 
        pb.f_dataName AS playerB,  
        g.f_sourceId, 
        g.f_desc
    FROM 
        t_game g
        LEFT JOIN t_kindData ta ON g.f_teamAId = ta.f_dataId
        LEFT JOIN t_kindData tb ON g.f_teamBId = tb.f_dataId
        LEFT JOIN t_kindData pa ON g.f_playerAId = pa.f_dataId
        LEFT JOIN t_kindData pb ON g.f_playerBId = pb.f_dataId
    ORDER BY g.f_gameId desc

-- Batch Separator

SELECT * FROM t_game ORDER BY f_gameId desc;

