CREATE PROCEDURE [dbo].[spDeleteGame]
	@f_gameId nvarchar(50)
AS
	DELETE FROM t_game WHERE f_gameId=@f_gameId;
