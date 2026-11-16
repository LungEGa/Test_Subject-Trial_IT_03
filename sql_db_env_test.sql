----- [Required] Create Database and Table -----
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'db_test')
BEGIN
	CREATE DATABASE [db_test];
END
GO

CREATE TABLE approval_request (
	sorting_id BIGINT PRIMARY KEY 
);


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
