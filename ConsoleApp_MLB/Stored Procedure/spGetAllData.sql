CREATE PROCEDURE [dbo].[spGetAllData]
AS
	SELECT TOP 1000 * FROM t_game ORDER BY f_gameId desc;
	SELECT TOP 1000 * FROM t_kind;
