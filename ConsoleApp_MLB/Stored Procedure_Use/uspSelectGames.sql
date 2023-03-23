USE [DB_MLB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spSelectGames]

SELECT	@return_value as 'Return Value'

GO
