CREATE TABLE Manufacturer
(
	ManufacturerId INT IDENTITY(1,1) PRIMARY KEY,
	ManufacturerNumber NVARCHAR(60),
	ManufacturerDescription NVARCHAR(60),
	ModifiedBy INT FOREIGN KEY REFERENCES [User](UserId),
	ModifiedDate DATETIME2 DEFAULT( GETDATE())
)