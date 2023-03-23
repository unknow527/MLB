USE [C:\CSHARP\.NET CORE\MLB\CONSOLEAPP_MLB\APP_DATA\DB_MLB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spDeleteGame]
		@f_gameId = N'2023-03-21_5_6'

SELECT	@return_value as 'Return Value'

GO
