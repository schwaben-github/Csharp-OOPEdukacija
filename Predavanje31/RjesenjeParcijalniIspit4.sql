﻿CREATE DATABASE RjesenjeParcijalniIspit4;
GO

USE RjesenjeParcijalniIspit4;
GO
--1.Zadatak

CREATE TABLE Mjesta (
    Pbr INT PRIMARY KEY,
    NazMjesta NVARCHAR(100) NULL
)
GO

CREATE TABLE Clanovi (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ime NVARCHAR(50) NULL,
    Prezime NVARCHAR(50) NULL,
    DatumRodjenja DATE NULL,
    PbrStan INT NULL FOREIGN KEY REFERENCES Mjesta(Pbr)
)
GO

CREATE TABLE Autori (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ime NVARCHAR(50) NULL,
    Prezime NVARCHAR(50) NULL
)
Go

CREATE TABLE Knjige (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Naslov NVARCHAR(100) NULL,
    AutorId INT NULL FOREIGN KEY REFERENCES Autori(Id)
)
GO

CREATE TABLE Posudbe (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClanId INT NULL FOREIGN KEY REFERENCES Clanovi(Id),
    KnjigaId INT NULL FOREIGN KEY REFERENCES Knjige(Id),
    DatumPosudbe DATE NULL,
    DatumVracanja DATE NULL
)
GO


--2.Zadatak


ALTER TABLE Clanovi
ALTER COLUMN Ime NVARCHAR(50) NOT NULL

ALTER TABLE Clanovi
ALTER COLUMN Prezime NVARCHAR(50) NOT NULL

ALTER TABLE Clanovi
ALTER COLUMN DatumRodjenja DATE NOT NULL

ALTER TABLE Clanovi
ALTER COLUMN PbrStan INT NOT NULL


ALTER TABLE Mjesta
ALTER COLUMN NazMjesta NVARCHAR(100) NOT NULL


ALTER TABLE Knjige
ALTER COLUMN Naslov NVARCHAR(100) NOT NULL

ALTER TABLE Knjige
ALTER COLUMN AutorId INT NOT NULL


ALTER TABLE Posudbe
ALTER COLUMN ClanId INT NOT NULL

ALTER TABLE Posudbe
ALTER COLUMN KnjigaId INT NOT NULL

ALTER TABLE Posudbe
ALTER COLUMN DatumPosudbe DATE NOT NULL
GO
--3.Zadatak

INSERT INTO Mjesta (Pbr, NazMjesta)
VALUES 
(10000, 'Zagreb'),
(21000, 'Split'),
(51000, 'Rijeka'),
(31000, 'Osijek'),
(31550, 'Valpovo')
GO

INSERT INTO Clanovi (Ime, Prezime, DatumRodjenja, PbrStan)
VALUES 
('Ivan', 'Horvat', '2005-04-23', 10000),
('Ana', 'Anić', '1985-06-15', 21000),
('Marko', 'Markić', '2010-09-10', 51000),
('Lucija', 'Horvat', '2000-11-30', 31550),
('Petar', 'Petrić', '2003-01-01', 31000),
('Mario', 'Vidaković', '1990-01-01', 31550),
('Ivica', 'Ivanović', '1995-05-05', 31550),
('Jurica', 'Vidić', '1988-08-08', 31550)
GO


INSERT INTO Autori (Ime, Prezime)
VALUES 
('Ivo', 'Andrić'),
('Miroslav', 'Krleža'),
('Ivana', 'Brlić-Mažuranić'),
('August', 'Šenoa'),
('Antun', 'Gustav Matoš')
GO

INSERT INTO Knjige (Naslov, AutorId)
VALUES 
('Na Drini ćuprija', 1),
('Povratak Filipa Latinovicza', 2),
('Čudnovate zgode šegrta Hlapića', 3), 
('Zlatarovo zlato', 4),
('Pjesme', 5),
('Regoč', 3),
('Šuma striborova', 3),
('Sunce djever i Neva Nevičica', 3)
GO

INSERT INTO Posudbe (ClanId, KnjigaId, DatumPosudbe, DatumVracanja)
VALUES 
(1, 1, '2024-01-01', NULL),
(2, 2, '2024-02-01', '2024-03-01'),
(3, 3, '2024-03-01', NULL),
(4, 3, '2024-05-01', NULL),
(5, 4, '2024-05-15', NULL),
(6, 6, '2024-02-12', NULL),
(7, 7, '2023-12-12', NULL),
(8, 8, '2024-06-02', NULL)


--4.Zadatak

SELECT DISTINCT Prezime
FROM Clanovi
ORDER BY Prezime DESC

--5.Zadatak

SELECT c.Ime, c.Prezime, m.NazMjesta AS MjestoStanovanja
FROM Clanovi c
INNER JOIN Mjesta m ON c.PbrStan = m.Pbr
WHERE DATEDIFF(YEAR, c.DatumRodjenja, GETDATE()) >= 18


--6.Zadatak
SELECT c.Ime, c.Prezime, k.Naslov AS NazivKnjige, a.Ime + ' ' + a.Prezime AS Autor,(DATEDIFF(day, p.DatumPosudbe, GETDATE()) - 15) * 0.5 AS Zakasnina
FROM Posudbe p
INNER JOIN Clanovi c ON p.ClanID = c.Id
INNER JOIN Knjige k ON p.KnjigaID = k.Id
INNER JOIN Autori a ON k.AutorID = a.Id
WHERE p.DatumVracanja IS NULL AND DATEDIFF(day, p.DatumPosudbe, GETDATE()) > 15


--7.Zadatak

SELECT  c.Ime, c.Prezime
FROM Clanovi c
INNER JOIN Posudbe p ON c.Id = p.ClanID
INNER JOIN Knjige k ON p.KnjigaID = k.Id
INNER JOIN Autori a ON k.AutorID = a.Id
INNER JOIN Mjesta m ON c.PbrStan = m.Pbr
WHERE a.Ime = 'Ivana' AND a.Prezime = 'Brlić-Mažuranić' AND m.NazMjesta = 'Valpovo'