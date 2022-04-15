/*
	SampleAPI schema
	
	To run this schema, you will need to:
	1. Create a database called SampleAPI in your Sql Server.
	2. Open the schema file, and replace the ***Database*** with your database name
	3. Run the schema.
*/


USE '***DATABASE***'
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTable]') AND type in (N'U'))
BEGIN
	CREATE TABLE GetTable
	(
		TableID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
		GetTableDate date NOT NULL,
		GetTableColumn1 varchar(50) NOT NULL,
		GetTableColumn2 varchar(100) NULL,
		IsGetTableBoolean bit NOT NULL
	)
END