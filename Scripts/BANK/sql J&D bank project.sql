use CheckRegister

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vendors]') AND type in (N'U'))
BEGIN
create table Vendors (
 VendorID int primary key not null
,[VendorName] varchar(25) not null
,VendorType varchar(25) not null
)
end

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GeneralLedger]') AND type in (N'U'))
BEGIN
Create table [GeneralLedger] (
[date] datetime2 Primary key not null,
[transationamount] money not null,
[description] varchar(100) null,
balance money not null,
creditordebit bit not null,
cleared bit	not null,
fee bit not null
)
end