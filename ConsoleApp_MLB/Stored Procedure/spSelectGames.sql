CREATE PROCEDURE [dbo].[spSelectGames]
AS
	SELECT TOP 1000 * FROM t_game ORDER BY f_gameId desc;
