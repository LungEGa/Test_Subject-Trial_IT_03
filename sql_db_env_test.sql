---------- // Executable for Testing // ----------

----- [Required] Create Database and Table -----
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'db_test')
BEGIN
	CREATE DATABASE [db_test];
	ALTER DATABASE [db_test] COLLATE Thai_CI_AS;
END
GO

USE [db_test];
CREATE TABLE approval_request (
	sorting_id BIGINT NOT NULL IDENTITY PRIMARY KEY,
	req_topic NVARCHAR(100) COLLATE Thai_CI_AS NOT NULL,
	req_details NVARCHAR(500) COLLATE Thai_CI_AS NULL,
	requester NVARCHAR(100) COLLATE Thai_CI_AS NOT NULL,
	req_created_ts DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	req_stat NVARCHAR(10) NOT NULL DEFAULT 'Pending',
	approval_comment NVARCHAR(500) COLLATE Thai_CI_AS NULL,
	approver NVARCHAR(100) COLLATE Thai_CI_AS NULL,
	req_approval_ts DATETIME NULL
);

----- [Required] Inserting Sample Data -----
BEGIN
	INSERT INTO approval_request (req_topic, requester)	
	VALUES ('รายการที่ 1', 'ผู้ร้องขอ A'), ('รายการที่ 2', 'ผู้ร้องขอ A'), ('รายการที่ 3', 'ผู้ร้องขอ A'),
		('รายการที่ 4', 'ผู้ร้องขอ B'), ('รายการที่ 5', 'ผู้ร้องขอ B'), ('รายการที่ 6', 'ผู้ร้องขอ C'),
		('รายการที่ 7', 'ผู้ร้องขอ D'), ('รายการที่ 8', 'ผู้ร้องขอ D'), ('รายการที่ 9', 'ผู้ร้องขอ D'),
		('รายการที่ 10', 'ผู้ร้องขอ D'), ('Requesting 11', 'Requester E'), ('Requesting 12', 'Requester E');
END
GO

----- [Optional] Preview Dataset -----
SELECT * FROM [db_test].[dbo].[approval_request];






---------- // In-progress of Development Codes // ----------

----- [Optional] Creating Application Database Access [FAILED TEST] -----
USE [db_test];
-- CREATE CREDENTIAL apps_dbaccess WITH IDENTITY = 'SHARED ACCESS SIGNATURE', SECRET = '4ppsCl23dent14l';
-- CREATE DATABASE SCOPED CREDENTIAL apps_dbaccess WITH IDENTITY = 'SHARED ACCESS SIGNATURE', SECRET = '4ppsCl23dent14l';

SELECT name, credential_identity, create_date, modify_date
FROM sys.credentials;
SELECT name, credential_identity, create_date, modify_date
FROM sys.database_scoped_credentials;

-- DROP DATABASE SCOPED CREDENTIAL apps_dbaccess;
-- DROP CREDENTIAL apps_dbaccess;
