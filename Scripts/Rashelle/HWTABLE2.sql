use pubs;
create Table HWTable2
(
	[StoreName] varchar(40) NULL,
	[StoreAddress] varchar(40) NULL,
	[StoreCity] varchar(20) NULL,
	[StoreState] char(2) NULL,
	[SalesQuantity] smallint NOT NULL,
	[Discount] decimal(4,2) NOT NULL,
	[EmployeeID] char(9) NOT NULL,
	[JobLevel] tinyint NULL,
	[HireDate] datetime NOT NULL,
	[JobDescription] varchar(50) NOT NULL
)