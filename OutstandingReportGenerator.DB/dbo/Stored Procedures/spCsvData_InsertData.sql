CREATE PROCEDURE [dbo].[spCsvData_InsertData]
	@specNumber nvarchar(50),
	@barcode nvarchar(50),
	@collected nvarchar(50),
	@unitNumber nvarchar(50),
	@testRequested nvarchar(50),
	@refLabName nvarchar(50),
	@resultInMeditech nvarchar(50),
	@nhsNumber nvarchar(50),
    @patientName nvarchar(50),
    @dateOfBirth nvarchar(50)

AS
begin
	set nocount on;
	insert into dbo.AllOutStandingTests (SpecNumber, BarCode, Collected, UnitNumber, TestRequested, RefLabName, ResultInMeditech, NHSNumber, PatientName, DateOfBirth)
	values (@specNumber, @barcode, @collected, @unitNumber, @testRequested, @refLabName, @resultInMeditech, @nhsNumber, @patientName, @dateOfBirth)
end