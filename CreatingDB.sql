
CREATE DATABASE Warehouse
GO
USE Warehouse;

CREATE TABLE Goods
(
    ID INT IDENTITY PRIMARY KEY NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Type] NVARCHAR(100) NOT NULL,
    Supplier NVARCHAR(30),
    Quantity NVARCHAR(10),
    Cost NVARCHAR(100),
    [Date] NVARCHAR(30)
);