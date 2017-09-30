/*=================================================================================
	Author	:	Vijesh. V
	Date	:	30/09/2017
	Purpose	:	To Create table AcGroups
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE AcGroups(
	AcGrCode smallint NOT NULL,
	AcGrName varchar(100) NULL,
	AcCategoryID smallint NULL,
	AcGrOrder smallint NULL,
PRIMARY KEY CLUSTERED 
(
	AcGrCode ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
