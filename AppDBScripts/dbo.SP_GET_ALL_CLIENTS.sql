CREATE PROCEDURE [dbo].[GET_ALL_CLIENTS]
AS
	SELECT 
		[Id],
		[Names],
		[LastNames],
		[DocNumber],
		[Birth],
		[IsActive]
	FROM [dbo].[Client]
RETURN 0
