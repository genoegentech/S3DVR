/*=================================================================================
	Author	:	Vijesh. V
	Date	:	16/10/2017
	Purpose	:	To Create table Customers
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/
CREATE TABLE Customers(
	CustomerCode int NOT NULL,
	Name varchar(250) NOT NULL,
	Gender smallint NULL,
	Address varchar(600) NULL,
	CustDate datetime NULL,
	Email varchar(100) NULL,
	MobNo varchar(20) NULL,
	IsActive bit NOT NULL,
	SplNotes varchar(250) NULL,
 CONSTRAINT PK_Customers PRIMARY KEY CLUSTERED 
(
	CustomerCode ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE Customers ADD  CONSTRAINT DF_Customers_IsActive  DEFAULT ((0)) FOR IsActive
GO


