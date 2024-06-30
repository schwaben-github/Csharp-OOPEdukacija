CREATE DATABASE dbIzmjene;
GO

USE dbIzmjene;
GO

-- 1. kreiranje tablice
CREATE TABLE Proizvodi(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Naziv NVARCHAR(50) NOT NULL,
	Cijena FLOAT NOT NULL,
	PDV FLOAT NOT NULL,
	Mjera NVARCHAR(10)
)

-- 2. Izmjena tablice Proizvodi
ALTER TABLE Proizvodi ADD Kolicina INT NOT NULL

-- 3. Kreiranje tablice za narudzbe
CREATE TABLE Narudzbe(
Id INT PRIMARY KEY IDENTITY(1, 1),
DatumNarudzbe DATETIME NOT NULL,
PredvidjeniDatumDostave DATETIME NOT NULL,
JeDostavljeno BIT
)

-- 4. Brisanje atributa
ALTER TABLE Proizvodi DROP COLUMN Kolicina

-- 5. Kreiranje junction tablice za vezu many-to-many
CREATE TABLE NarudzbeProizvodi(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	NaruzbaId INT FOREIGN KEY REFERENCES Narudzbe(Id),
	ProizvodId INT FOREIGN KEY REFERENCES Proizvodi(Id),
	Kolicina INT NOT NULL
)

-- 6. Kreiranje tablice Korisnici
CREATE TABLE Korisnici(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Ime NVARCHAR(50) NOT NULL,
	Prezime NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Adresa NVARCHAR(250) NOT NULL,
	Telefon NVARCHAR(50) NOT NULL,
	Napomena NVARCHAR(MAX) NOT NULL
)

-- 7. Dodavanje foreign key za tablicu Korisnici
ALTER TABLE Narudzbe ADD KorisnikId INT FOREIGN KEY REFERENCES Korisnici(Id)

ALTER TABLE NarudzbeProizvodi ADD JedCijena FLOAT NOT NULL

ALTER TABLE Proizvodi ALTER COLUMN Cijena DECIMAL(18, 2) NOT NULL

ALTER TABLE Proizvodi DROP COLUMN PDV

ALTER TABLE Proizvodi ADD JeDostupan BIT

ALTER TABLE Proizvodi DROP COLUMN Mjera

CREATE TABLE MjereProizvoda(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Naziv VARCHAR(10)
)

ALTER TABLE pROIZVODI ADD MjereProizvodaId INT FOREIGN KEY REFERENCES MjereProizvoda(Id)

-- Punjenje tablica na 3 nacina
-- bez navodjenja imena atributa
INSERT INTO MjereProizvoda VALUES ('kg')
-- sa navodjenjem imena atributa
INSERT INTO MjereProizvoda (Naziv) VALUES ('g')
-- unosenje vise vrijednosti odjednom
INSERT INTO MjereProizvoda (Naziv) VALUES
('dag'),
('kom'),
('m'),
('cm'),
('l')

SELECT * FROM MjereProizvoda

-- Punjenje tablice Proizvodi
INSERT INTO Proizvodi(Naziv, Cijena, Mjera) VALUES
	('Crni kruh', 0.89, 4),
	('Mlijeko', 0.59, 4),
	('Sok od jabuke', 1.59, 4),
	('Cokolada', 1.79, 4),
	('Polubijeli kruh', 0.89, 4)

SELECT * FROM Proizvodi


-- Update tablice - postavljanje jedostupan na 1
UPDATE Proizvodi SET JeDostupan = 1

UPDATE Proizvodi SET MjereProizvodaID = 4

-- Ispis vrijednosti iz dvije tablice
SELECT * FROM Proizvodi AS p INNER JOIN MjereProizvoda AS mp ON p.MjereProizvodaId = mp.Id

SELECT p.Naziv, p.Cijena, p.JeDostupan, mp.Naziv AS 'Jed. mjere'
FROM Proizvodi AS p INNER JOIN MjereProizvoda AS mp
ON p.MjereProizvodaId = mp.Id

-- Punjenje tablice korisnika
INSERT INTO Korisnici (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
('Pero', 'Peri?', 'pero@gmail.com', 'Perin put 11', '01 234 5564', 'Pero ima velikog psa!'),
('Marica', 'Mari?', 'mara@gmail.com', 'Marin put 12', '01 442 5471', '0')

SELECT * FROM Korisnici

-- Punjenje tablice narudžbe
INSERT INTO Narudzbe (DatumNarudzbe, PredvidjeniDatumDostave, JeDostavljeno, KorisnikId) VALUES
('2024-05-27', '2024-05-30', 0 , 3),
('2024-05-26', '2024-05-27', 1 , 4)

SELECT * FROM Narudzbe

INSERT INTO NarudzbeProizvodi (NaruzbaId, ProizvodId, Kolicina, JedCijena) VALUES
(3, 1, 2, 0.99),
(4, 1, 2, 0.99)

SELECT * FROM NarudzbeProizvodi

-- Izmjene podataka u bazi - CRUD operacije
-- Izmjena vrijednosti
UPDATE Proizvodi SET JeDostupan = 0 WHERE Id = 1

SELECT * FROM Proizvodi

UPDATE Proizvodi SET Naziv = 'Kruh' WHERE Naziv = 'Crni kruh'
UPDATE Proizvodi SET Naziv = 'Crni kruh' WHERE JeDostupan = 0

SELECT * FROM Proizvodi

-- Brisanje podataka iz baze - uvijek navesti WHERE!
DELETE FROM Proizvodi WHERE Id = 3
DELETE FROM Proizvodi WHERE Id = 1

-- Brisanje pomo?u naredbe TRUNCATE - broja? se vra?a na po?etak
TRUNCATE TABLE <Ime tablice>

-- Brisanje cijele tablice
DROP TABLE <Ime tablice>

-- Brisanje cijele baze
DROP DATABASE <Ime baze>


SELECT * FROM Proizvodi
SELECT * FROM NarudzbeProizvodi
SELECT * FROM Korisnici
SELECT * FROM Narudzbe
SELECT * FROM MjereProizvoda