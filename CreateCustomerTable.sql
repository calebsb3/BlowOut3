CREATE TABLE [dbo].[Customer](
	[iCustomerID] INT	IDENTITY (1, 1) NOT NULL,
	[sCustFirstName] VARCHAR(30) NOT NULL,
	[sCustLastName] VARCHAR(30) NOT NULL,
	[sCustAddress] VARCHAR(50) NULL,
	[sCustState] VARCHAR(45) NULL,
	[sCustCity] VARCHAR(50) NULL,
	[iCustZip] INT NULL,
	[cCustPhone] VARCHAR(15) NULL,
	[cCustEmail] VARCHAR(30) NOT NULL,
	PRIMARY KEY ([iCustomerID] ASC)
);
