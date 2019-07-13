CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [OrderId] NCHAR(10) NULL, 
    [Location] NCHAR(10) NULL, 
    [StreetAddress] NCHAR(10) NULL, 
    [Purchaser] NCHAR(10) NULL, 
    [Contact] NCHAR(10) NULL
)
