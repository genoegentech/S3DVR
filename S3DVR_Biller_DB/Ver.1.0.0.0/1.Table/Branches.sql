/*=================================================================================
	Author	:	Vijesh. V
	Date	:	16/10/2017
	Purpose	:	To Create table Branches
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/
CREATE TABLE Branches(
	BrCode smallint NOT NULL,
	BrName varchar(200) NOT NULL,
	Address varchar(250) NULL,
	EMail varchar(100) NULL,
	MobNo varchar(20) NULL,
	IsActive bit NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE Branches ADD  CONSTRAINT DF_Branches_IsActive  DEFAULT ((0)) FOR IsActive
GO


