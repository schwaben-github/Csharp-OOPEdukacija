CREATE DATABASE MojaPrvaBaza
Use MojaPrvaBaza
GO

CREATE TABLE Skladista(
Id		INT	PRIMARY KEY IDENTITY(1, 1),
Naziv	NVARCHAR(50)	NOT NULL,
Lokacija	NVARCHAR(50)	NULL
)
GO

CREATE TABLE Proizvodi(
Id		INT PRIMARY KEY IDENTITY(1, 1),
Naziv	NVARCHAR(50)	NOT NULL,
Cijena	FLOAT	NOT NULL,
SkladisteId		INT FOREIGN KEY REFERENCES Skladista(Id)
)
GO

-- Ispis svih podataka iz tablice
SELECT * FROM Skladista
GO

-- Dodavanje zapisa u tablicu - naziv i lokacija
INSERT INTO Skladista VALUES('Skladište br. 1', 'Valpovo')
INSERT INTO Skladista VALUES('Skladište br. 2', 'Osijek')
GO

-- Ispis odabranih podataka iz tablice
SELECT Naziv, Lokacija FROM Skladista
GO

-- Dodavanje proizvoda
INSERT INTO Proizvodi VALUES ('Mlijeko', 0.89, 1)
INSERT INTO Proizvodi VALUES ('Kruh', 0.59, 1)
INSERT INTO Proizvodi VALUES ('Sol', 0.79, 1)
INSERT INTO Proizvodi VALUES ('Sir', 1.29, 1)
INSERT INTO Proizvodi VALUES ('Ulje', 1.89, 1)
GO

SELECT * FROM Proizvodi
GO

-- Spajanje tablica
SELECT * FROM Proizvodi JOIN Skladista ON Proizvodi.SkladisteId = Skladista.Id

SELECT p.Naziv, p.Cijena, s.Naziv FROM Proizvodi AS p JOIN Skladista AS s ON p.SkladisteId = s.Id