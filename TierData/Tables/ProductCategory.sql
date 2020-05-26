CREATE TABLE [dbo].[ProductCategory]
(
	[ProductCategoryId] INT IDENTITY(1,1) PRIMARY KEY,
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL
)
