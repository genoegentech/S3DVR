/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table LookupMaster
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE LookupMaster(
	MasterID int NULL,
	Name varchar(100) NULL,
	Description varchar(250) NULL,
	IsActive bit NULL
) ON [PRIMARY]

GO

ALTER TABLE LookupMaster ADD  DEFAULT ((0)) FOR IsActive
GO


