CREATE TABLE ManufacturerProduct(
	ManufacturerProduct BIGINT IDENTITY(1,1) PRIMARY KEY,
	ManufacturerId INT FOREIGN KEY REFERENCES Manufacturer(ManufacturerId) NOT NULL,
	ProductId BIGINT FOREIGN KEY REFERENCES Product(ProductId) NOT NULL
)