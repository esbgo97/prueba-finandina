CREATE PROCEDURE [dbo].[UPDATE_CLIENT_STATE]
	@Id INT,
	@IsActive BIT
AS
	UPDATE [dbo].[Client]
	SET
		[IsActive] = @IsActive
	WHERE		
		[Id] = @Id
RETURN 0
