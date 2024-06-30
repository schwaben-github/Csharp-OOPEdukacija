CREATE DATABASE MojaPrvaBaza
GO

USE MojaPrvaBaza
GO

-- komentar
CREATE TABLE Skladista(
Id		INT PRIMARY KEY IDENTITY(1,1),
Naziv	NVARCHAR(50)  NOT NULL,
Lokacija	NVARCHAR(50) NULL
)
GO

CREATE TABLE Proizvodi(
Id		INT PRIMARY KEY IDENTITY(1,1),
Naziv	NVARCHAR(50) NOT NULL,
Cijena	FLOAT NOT NULL,
SkladisteId		INT FOREIGN KEY REFERENCES Skladista(Id)
)
GO

-- ispis svih (*) podataka iz tablice
SELECT * FROM Skladista
GO 

-- dodavanje zapisa u tablicu - Naziv i lokacija
INSERT INTO Skladista VALUES('Skladište br. 1', 'Valpovo')
INSERT INTO Skladista VALUES('Skladište br. 2', 'Osijek')
GO

-- ispis odabranih podataka iz tablice
SELECT Naziv, Lokacija FROM Skladista

-- dodavanje proizvoda
INSERT INTO Proizvodi VALUES ('Mlijeko', 0.89, 1)
INSERT INTO Proizvodi VALUES ('Kruh', 0.99, 1)
INSERT INTO Proizvodi VALUES ('Sol', 0.59, 1)
INSERT INTO Proizvodi VALUES ('Sir', 2.89, 1)

-- ispis proizvoda
SELECT * FROM Proizvodi
SELECT Naziv, CIJENA FROM Proizvodi

-- spajanje tablica
SELECT * FROM Proizvodi JOIN Skladista ON Proizvodi.SkladisteId = Skladista.Id

SELECT p.Naziv, p.Cijena, s.Lokacija, s.Naziv FROM Proizvodi AS p 
JOIN Skladista AS s ON p.SkladisteId = s.Id
