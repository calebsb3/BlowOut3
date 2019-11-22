CREATE TABLE dbo.Instrument (
	iInstrumentID INT IDENTITY(1,1) NOT NULL,
	sInstrumentDesc VARCHAR(100) NOT NULL,
	bInstrumentType BIT NOT NULL,
	dInstrumentPrice MONEY NOT NULL,
	PRIMARY KEY ([iInstrumentID] ASC),
	iCustomerID INT FOREIGN KEY REFERENCES Customer(iCustomerID)
);