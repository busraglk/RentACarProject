CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [BrandId ] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear ] INT NULL, 
    [DailyPrice] DECIMAL(18, 2) NULL, 
    [Description] VARCHAR(100) NULL
)
