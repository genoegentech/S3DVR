/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table StockItems
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE StockItems(
	StkItemCode smallint NOT NULL,
	StkGroupCode smallint NULL,
	StkItemName varchar(250) NULL,
	StkItemDescription varchar(600) NULL,
	StkSupplierCode smallint NULL,
	StkMainUnitCode smallint NULL,
	StkAlternativeUnitCode smallint NULL,
PRIMARY KEY CLUSTERED 
(
	StkItemCode ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

