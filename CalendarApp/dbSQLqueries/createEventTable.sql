CREATE TABLE [dbo].[Event]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NULL, 
    [Description] TEXT NULL, 
    [StartDate] DATETIME NULL, 
    [EndDate] DATETIME NULL
)