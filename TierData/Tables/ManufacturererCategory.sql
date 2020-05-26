CREATE TABLE [dbo].[ManufacturererCategory]
(
	[ManufacturererCategoryId] INT IDENTITY(1,1) PRIMARY KEY,
	ManufacturererId INT FOREIGN KEY REFERENCES Manufacturer(ManufacturerId)NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) NOT NULL
)
