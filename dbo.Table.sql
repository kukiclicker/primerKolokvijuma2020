CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [IndexNumber] NVARCHAR(20) NOT NULL, 
    [AverageMark] DECIMAL(16, 2) NULL
)
