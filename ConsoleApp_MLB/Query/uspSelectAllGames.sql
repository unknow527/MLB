USE [C:\CSHARP\VS2022\CONSOLEAPP_MLB\CONSOLEAPP_MLB\APP_DATA\DB_MLB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spSelectAllGames]

SELECT	@return_value as 'Return Value'

GO
