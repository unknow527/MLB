USE [C:\CSHARP\.NET CORE\MLB\CONSOLEAPP_MLB\APP_DATA\DB_MLB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spCreateGame]
		@f_gameId = N'2023-03-21_5_6',
		@f_gameDate = N'2023-03-21',
		@f_gameStatus = 1,
		@f_teamAId = 5,
		@f_teamBId = 6,
		@f_ra = 0,
		@f_rb = 0,
		@f_playerAId = 20,
		@f_playerBId = 21,
		@f_sourceId = 1,
		@f_desc = N'test'

SELECT	@return_value as 'Return Value'

GO
