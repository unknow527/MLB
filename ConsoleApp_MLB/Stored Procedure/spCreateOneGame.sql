CREATE PROCEDURE [dbo].[spCreateOneGame]
	@f_gameId nvarchar(50),
	@f_gameDate nvarchar(50),
	@f_gameStatus tinyint,
	@f_teamAId int,
	@f_teamBId int,
	@f_ra tinyint,
	@f_rb tinyint,
	@f_playerAId int,
	@f_playerBId int,
	@f_sourceId tinyint,
	@f_desc nvarchar(200)
AS

	INSERT INTO t_game(f_gameId, f_gameDate, f_gameStatus, f_teamAId, f_teamBId, f_ra, f_rb, f_playerAId, f_playerBId, f_sourceId, f_desc)
	OUTPUT inserted.f_gameId
	VALUES (@f_gameId, @f_gameDate, @f_gameStatus, @f_teamAId, @f_teamBId, @f_ra, @f_rb, @f_playerAId, @f_playerBId, @f_sourceId, @f_desc)

-- Batch Separator

-- SELECT * FROM t_game WHERE f_gameId = @f_gameId;
