create table Vendors (
[VendorName] varchar(25) primary key not null
,VendorID int not null
,VendorType varchar(25) not null
)

Create table [Checkingtransactions] (
[date] datetime2 Primary key not null,
[transationamount] money not null,
[description] varchar(100)not null,
balance money not null,
creditordebit bit not null,
cleared bit	not null,
fee bit not null,
)