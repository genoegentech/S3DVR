/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table CompoundUnits
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE CompoundUnits(
	UnitID int NULL,
	FirstUnitID int NULL,
	Conversion varchar(100) NULL,
	SecondUnitID int NULL
) ON [PRIMARY]

GO
