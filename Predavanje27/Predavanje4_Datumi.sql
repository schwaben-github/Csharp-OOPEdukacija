--SET LANGUAGE 'Hrvatski'

-- Funkcije za rad s datumom i vremenom
-- DATEADD
-- 1. parametar je što dodajemo, drugi koliko, a treæi od kojeg datuma
SELECT DATEADD(DAY, -5, GETDATE())

--DATEDIFF
SELECT DATEDIFF(DAY, '2024-05-01', GETDATE())

SELECT DATEDIFF(DAY, DATEADD(DAY, -3, GETDATE()), GETDATE()) AS 'Broj dana'

--DATENAME
SELECT DATENAME(DAY, GETDATE())
SELECT DATENAME(MONTH, GETDATE())

--DATEPART
SELECT DATEPART(MONTH, '2024-04-03')
SELECT DATEPART(DAY, '2024-04-03')
SELECT DATEPART(YEAR, '2024-04-03')

--GETDATE
SELECT GETDATE()

-- Konvertiranje i kastanje u SQL-u
--CAST
SELECT CAST(GETDATE() AS nvarchar)

--CONVERT
SELECT CONVERT(nvarchar, GETDATE(), 104) --hrvatski prikaz datuma
SELECT CONVERT(nvarchar, GETDATE(), 105)
SELECT CONVERT(nvarchar, GETDATE(), 100)

--Storane procedure
CREATE PROCEDURE DohvatiStudentaPoImenu
	-- Add the parameters for the stored procedure here
	@imeStudenta NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM stud WHERE imeStud = @imeStudenta
END
GO

--DROP PROCEDURE DohvatiStudentaPoImenu

EXEC DohvatiStudentaPoImenu 'Iva'