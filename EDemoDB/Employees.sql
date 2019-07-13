CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL, 
    [Team] INT NULL
)
