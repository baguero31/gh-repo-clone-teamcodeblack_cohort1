use CheckRegister
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vendors]') AND type in (N'U'))
BEGIN
	create table Vendors (
	 VendorID int primary key not null
	,[VendorName] varchar(25) not null
	,VendorType varchar(25) not null
	)
END

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
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Debits]') AND type in (N'U'))	
BEGIN
	CREATE TABLE [dbo].[Debits](
		[DebitID] UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
		[TransactionDate] [datetime] NOT NULL,
		[TransactionAmount] [money] NOT NULL,
		[VendorID] [VARCHAR](38) NOT NULL,
		[MemoLine] [varchar](200) NULL,
		[DebitCleared] [bit] NOT NULL,
	 CONSTRAINT [PK_Debit] PRIMARY KEY CLUSTERED 
	(
		[DebitID] ASC,
		[TransactionDate] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
ELSE
BEGIN
	PRINT 'Debits Table already exists'
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Credits]') AND type in (N'U'))	
BEGIN
	CREATE TABLE [dbo].[Credits](
		[CreditID] UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
		[TransactionDate] [datetime] NOT NULL,
		[TransactionAmount] [money] NOT NULL,
		[VendorID] [VARCHAR](38) NOT NULL,
		[MemoLine] [varchar](200) NULL,
		[CreditCleared] [bit] NOT NULL,
	 CONSTRAINT [PK_Credit] PRIMARY KEY CLUSTERED 
	(
		[CreditID] ASC,
		[TransactionDate] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
ELSE
BEGIN
	PRINT 'Credits Table already exists'
END
GO

--new update for pull request, thanks to alex for the help, i was totally lost
CREATE PROCEDURE 
    [dbo].[sp_InsertIntoDebit]
        @DebitID DATETIME
	    ,@TransactionAmount MONEY
    	,@VendorID VARCHAR (38)
    	,@MemoLine VARCHAR (200)
    	,@DebitCleared BIT
AS
	BEGIN
        INSERT INTO [dbo].[Debits]
            (DebitID, TransactionDate, TransactionAmount, VendorID, MemoLine, DebitCleared)
        VALUES 
		    (@DebitID, GETDATE(), @TransactionAmount, @VendorID, @MemoLine, @DebitCleared)
    END
GO


