
CREATE PROCEDURE [dbo].[sp_GetMaxQuantity]
AS
    SELECT MAX(Quantity) FROM Stationery 
GO


CREATE PROCEDURE [dbo].[sp_GetMinQuantity]
AS
    SELECT MIN(Quantity) FROM Stationery 
GO


CREATE PROCEDURE [dbo].[sp_GetMaxPrice]
AS
    SELECT MAX(Price) FROM Stationery  
GO


CREATE PROCEDURE [dbo].[sp_GetMinPrice]
AS
    SELECT MIN(Price) FROM Stationery
GO


CREATE PROCEDURE [dbo].[sp_GetAvgQuantityByType]
    @type NVARCHAR(50),
    @avg INT OUT
AS
    SELECT @avg = AVG(Quantity)
    FROM Stationery
    WHERE [Name] LIKE '%' + @type + '%'
GO