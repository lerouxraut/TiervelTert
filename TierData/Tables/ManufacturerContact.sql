CREATE TABLE ManufacturerContact
(
	ManufacturerContactId INT IDENTITY(1,1) PRIMARY KEY,
	AddressLine01 NVARCHAR(60),
	AddressLine02 NVARCHAR(60),
	AddressLine03 NVARCHAR(60),
	AddressLine04 NVARCHAR(60),
	AddressLine05 NVARCHAR(60),
	Web NVARCHAR(60),
	Email NVARCHAR(60),
	ContactPerson NVARCHAR(60),
	ModifiedBy INT FOREIGN KEY REFERENCES [User](UserId),
	ModifiedDate DATETIME2 DEFAULT( GETDATE())
)