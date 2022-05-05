
SELECT * 
FROM dbo.genderalLedger;
GO

 create procedure 
		,@CreditID_ DATETIME
+	    ,@TransactionAmount_ MONEY
+    	,@VendorID_ VARCHAR 38
AS
+	BEGIN
+        INSERT INTO Credit
+        (CreditID, TransactionDate, VendorID,)
+        VALUES (CreditID_, TransactionAmount_, VendorID_,)
+    END
 GO

