/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table StockItemAlternativeUnitCodes
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE StockItemAlternativeUnitCodes(
	StkItemCode smallint NOT NULL,
	StkAlternativeUnitCode smallint NULL,
PRIMARY KEY CLUSTERED 
(
	StkItemCode ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


