
SELECT * 

FROM dbo.genderalLedger;

GO

 CREATE procedure 

		,@CreditID DATETIME
	    ,@TransactionAmount MONEY
		,@VendorID VARCHAR(38)

AS
	BEGIN
        Update INTO Credit
        (CreditID, TransactionAmount, TransactionDate, VendorID,MemoLine)
        VALUES (CreditID_, TransactionAmount_,TransactionDate_, VendorID_,MemoLine_)

	END