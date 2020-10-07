CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Names] NCHAR(50) NOT NULL, 
    [LastNames] NCHAR(50) NOT NULL, 
    [DocNumber] NCHAR(12) NOT NULL, 
    [Birth] DATETIME NOT NULL, 
    [IsActive] BIT NOT NULL
)
