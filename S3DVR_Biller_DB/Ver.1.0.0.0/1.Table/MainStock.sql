/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table MainStock
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE MainStock(
	StkItemCode smallint NULL,
	StkDate datetime NULL,
	Quantity int NULL,
	Rate money NULL,
	UnitCode smallint NULL,
	PerUnitCode smallint NULL,
	Value money NULL
) ON [PRIMARY]

GO