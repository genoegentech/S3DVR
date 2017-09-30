/*=================================================================================
	Author	:	VJSV
	Date	:	30/09/2017
	Purpose	:	To Create table Users
	Testing	:	
-----------------------------------------------------------------------------------
Modified By		Date			Version		Remarks
-----------------------------------------------------------------------------------
<New Entry>
-----------------------------------------------------------------------------------
===================================================================================*/

CREATE TABLE Users(
	UserID varchar(20) NULL,
	UserName varchar(100) NULL,
	GroupID smallint NULL,
	Password varchar(500) NULL,
	Email varchar(100) NULL,
	MobNo varchar(20) NULL,
	IsActive bit NULL
) ON [PRIMARY]

GO