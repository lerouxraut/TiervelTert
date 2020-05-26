CREATE TABLE [dbo].[Category]
(
	CategoryId INT IDENTITY(1,1) PRIMARY KEY,
	Categoryname NVARCHAR(60) NOT NULL,
	CategoryCode NVARCHAR(30) NULL --- weetie???
)
