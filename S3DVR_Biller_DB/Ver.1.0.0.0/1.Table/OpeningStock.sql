/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table OpeningStock
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE OpeningStock(
	StkItemCode smallint NULL,
	OpBalDate datetime NULL,
	Quantity int NULL,
	Rate money NULL,
	UnitCode int NULL,
	PerUnitCode int NULL,
	Value money NULL
) ON [PRIMARY]

GO