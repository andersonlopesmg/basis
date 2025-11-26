IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'basis_store')
BEGIN
    CREATE DATABASE basis_store;
END
GO

USE basis_store;
GO

IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'basis')
BEGIN
    CREATE LOGIN basis WITH PASSWORD = 'Basis@1234', CHECK_POLICY = OFF;
END
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'basis')
BEGIN
    CREATE USER basis FOR LOGIN basis;
    EXEC sp_addrolemember 'db_owner', 'basis';
END
GO