/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table LookupDetails
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE LookupDetails(
	DetailsID int NULL,
	MasterID int NULL,
	DisplayName varchar(250) NULL,
	ShortName varchar(100) NULL,
	IsActive bit NULL
) ON [PRIMARY]

GO

ALTER TABLE LookupDetails ADD  DEFAULT ((0)) FOR IsActive
GO


