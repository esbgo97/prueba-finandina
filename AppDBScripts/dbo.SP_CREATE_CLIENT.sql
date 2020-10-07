CREATE PROCEDURE [dbo].[CREATE_CLIENT]
	@Id INT,
	@Names NVARCHAR(50),
	@LastNames NVARCHAR(50),
	@DocNumber NVARCHAR(12),
	@Birth DATETIME,
	@IsActive BIT
AS
	DECLARE @newId INT
	SELECT @newId = COUNT(Id)+1 FROM [dbo].[Client]
	
	INSERT INTO  
		[dbo].[Client]
	(
		[Id],
		[Names],
		[LastNames],
		[DocNumber],
		[Birth],
		[IsActive]
	)VALUES (
		@newId,
		@Names,
		@LastNames,
		@DocNumber,
		@Birth,
		@IsActive
	)
	SELECT @newId
RETURN 0
