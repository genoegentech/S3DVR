/*=================================================================================
	Author	:	Vijesh. V
	Date	:	16/10/2017
	Purpose	:	To Create table Suppliers
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/
CREATE TABLE Suppliers(
	SupplierCode smallint NOT NULL,
	Name varchar(250) NOT NULL,
	Address varchar(600) NULL,
	Email varchar(100) NULL,
	MobNo varchar(20) NULL,
	IsActive bit NOT NULL,
	SplNotes varchar(250) NULL,
 CONSTRAINT PK_Suppliers PRIMARY KEY CLUSTERED 
(
	SupplierCode ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE Suppliers ADD  CONSTRAINT DF_Suppliers_IsActive  DEFAULT ((0)) FOR IsActive
GO


