USE [mlb]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spCreateGame]
		@f_gameId = N'2023-03-21_26_27',
		@f_gameDate = N'2023-03-21',
		@f_gameStatus = 1,
		@f_teamAId = 26,
		@f_teamBId = 27,
		@f_ra = 0,
		@f_rb = 0,
		@f_playerAId = 65,
		@f_playerBId = 66,
		@f_sourceId = 1,
		@f_desc = N'test'

SELECT	@return_value as 'Return Value'

GO
