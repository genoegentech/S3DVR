/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table Units
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE Units(
	ID int IDENTITY(1,1) NOT NULL,
	Name varchar(50) NULL,
	DisplayName varchar(100) NULL,
	IsCompund bit NULL
) ON [PRIMARY]

GO

ALTER TABLE Units ADD  DEFAULT ((0)) FOR IsCompund
GO
