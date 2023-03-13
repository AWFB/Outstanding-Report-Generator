CREATE TABLE [dbo].[AllOutStandingTests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SpecNumber] NVARCHAR(50) NOT NULL, 
    [BarCode] NVARCHAR(50) NOT NULL, 
    [Collected] NVARCHAR(50) NOT NULL, 
    [UnitNumber] NVARCHAR(50) NOT NULL, 
    [TestRequested] NVARCHAR(50) NOT NULL, 
    [RefLabName] NVARCHAR(50) NULL, 
    [ResultInMeditech] NVARCHAR(50) NULL, 
    [NHSNumber] NVARCHAR(50) NOT NULL, 
    [PatientName] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] NVARCHAR(50) NOT NULL
)
