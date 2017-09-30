/*=================================================================================
	Author	:	Vijesh. V
	Date	:	30/09/2017
	Purpose	:	To Create table AcCategory
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE AcCategory(
	AcCategoryID smallint NOT NULL,
	CategoryName varchar(100) NULL,
PRIMARY KEY CLUSTERED 
(
	AcCategoryID ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
