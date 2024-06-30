CREATE DATABASE dbIzmjene
GO

USE dbIzmjene
GO

--1. kreiranje tablice
CREATE TABLE Proizvodi(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	Naziv	NVARCHAR(50) NOT NULL,
	Cijena	FLOAT NOT NULL,
	PDV		FLOAT NOT NULL,
	Mjera	NVARCHAR(10)
)

--2. izmjena tablice Proizvodi
ALTER TABLE Proizvodi ADD Kolicina INT NOT NULL

--3. Kreranje tablice za narudzbe
CREATE TABLE Narudzbe(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	DatumNarudzbe	DATETIME NOT NULL,
	PredvidjeniDatumDostave	DATETIME NOT NULL,
	JeDostavljeno		BIT
)

-- 4. Brisanje atributa
ALTER TABLE Proizvodi DROP COLUMN Kolicina

--5. Kreiranje junction tablice za vezu više na više
CREATE TABLE NarudzbeProizvodi(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	NarudzbaId	INT FOREIGN KEY REFERENCES Narudzbe(Id),
	ProizvodId	INT FOREIGN KEY REFERENCES Proizvodi(Id),
	Kolicina	INT NOT NULL
)

CREATE TABLE Korisnici(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	Ime	NVARCHAR(50) NOT NULL,
	Prezime NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Adresa NVARCHAR(250) NOT NULL,
	Telefon NVARCHAR(50) NULL,
	Napomena NVARCHAR(MAX) NULL
)

ALTER TABLE Narudzbe ADD KorisnikId INT FOREIGN KEY REFERENCES Korisnici(Id)

ALTER TABLE NarudzbeProizvodi ADD JedCijena FLOAT NOT NULL

ALTER TABLE Proizvodi ALTER COLUMN Cijena DECIMAL(18,2) NOT NULL

ALTER TABLE Proizvodi DROP COLUMN PDV

ALTER TABLE Proizvodi ADD JeDostupan BIT

ALTER TABLE Proizvodi DROP COLUMN Mjera

CREATE TABLE MjereProizvoda(
	Id		INT PRIMARY KEY IDENTITY(1,1),
	Naziv	NVARCHAR(10)
)

ALTER TABLE Proizvodi ADD MjereProizvodaId INT FOREIGN KEY REFERENCES 
MjereProizvoda(Id)

-- PUNJENJE TABLICA
-- bez navoðenja imena atributa
INSERT INTO MjereProizvoda VALUES ('kg')
-- sa navoðenjem naziva stupca
INSERT INTO MjereProizvoda (Naziv) VALUES ('g')
-- unošenje više vrijednosti odjednom
INSERT INTO MjereProizvoda (Naziv) VALUES
('dag'),
('kom'),
('m'),
('cm'),
('l')
 
 SELECT * FROM MjereProizvoda

 INSERT INTO Proizvodi(Naziv, Cijena, MjereProizvodaId) VALUES
 ('Bijeli kruh', 0.99, 4)

 INSERT INTO Proizvodi(Naziv, Cijena, MjereProizvodaId) VALUES
 ('Crni kruh', 0.89, 4),
 ('Mlijeko', 0.59, 7),
 ('Sok od jabuke', 1.59, 7),
 ('TV', 299.99, 4),
 ('Tablet', 199.99, 4)

 SELECT * FROM Proizvodi

 -- update tablice - postavljam jedostupa na 1
 UPDATE Proizvodi SET JeDostupan = 1

 --ispis vrijednosti iz dvije tablice
 SELECT * FROM Proizvodi AS p INNER JOIN MjereProizvoda AS mp 
 ON p.MjereProizvodaId = mp.Id

 SELECT p.Naziv, p.Cijena, p.JeDostupan, mp.Naziv AS 'Jed. mjere'
 FROM Proizvodi AS p INNER JOIN MjereProizvoda AS mp 
 ON p.MjereProizvodaId = mp.Id

 -- Punjenje tablice korisnika
 INSERT INTO Korisnici (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
 ('Pero', 'Periæ', 'pero@peric.com', 'Perin put 11', '0124354645', 'Pero ima velikog psa'),
 ('Iva', 'Iviæ', 'iva@ivic.com', 'Ivin trg 100', '031242431', NULL)
 SELECT * FROM Korisnici

INSERT INTO Narudzbe (DatumNarudzbe, PredvidjeniDatumDostave, JeDostavljeno, KorisnikId) VALUES
('2024-05-27', '2024-05-30', 0, 1),
('2024-05-26', '2024-05-27', 1, 2)
SELECT * FROM Narudzbe

INSERT INTO NarudzbeProizvodi (NarudzbaId, ProizvodId, Kolicina, JedCijena) VALUES
(1, 9, 2, 0.99)
INSERT INTO NarudzbeProizvodi (NarudzbaId, ProizvodId, Kolicina, JedCijena) VALUES
(1, 1, 2, 0.89)
INSERT INTO NarudzbeProizvodi (NarudzbaId, ProizvodId, Kolicina, JedCijena) VALUES
(1, 2, 2, 2 * (SELECT Cijena FROM Proizvodi WHERE Id=2))

SELECT * FROM NarudzbeProizvodi

SELECT * FROM Proizvodi
-- IZMJENE PODATAKA U BAZI - CRUD operacije

--1. Izmjena vrijednosti u bazi
UPDATE Proizvodi SET JeDostupan = 0
UPDATE Proizvodi SET JeDostupan = 1 WHERE Id < 6

UPDATE Proizvodi SET Naziv = 'Kruh' WHERE Naziv = 'Crni kruh'
UPDATE Proizvodi SET Naziv = 'Tablet' WHERE JeDostupan = 0

--2. Brisanje podataka iz baze - uvijek navesti WHERE
DELETE FROM Proizvodi WHERE Id > 5
DELETE FROM Proizvodi WHERE Id = 3

-- test
INSERT INTO Proizvodi VALUES ('Monitor', '99.99', 0, 4)
SELECT * FROM Proizvodi
SELECT * FROM NarudzbeProizvodi
DELETE FROM NarudzbeProizvodi WHERE ProizvodId = 1
DELETE FROM Proizvodi WHERE Id=1
DELETE FROM NarudzbeProizvodi
DELETE FROM Proizvodi

--3. Brisanje pomoæu naredbe TRUNCATE - brojaè bi se trebao vratiti na poèetak
TRUNCATE TABLE NarudzbeProizvodi

-- 4. Brisanje cijele tablice
DROP TABLE NarudzbeProizvodi

-- 5. Brisanje cijele baze
DROP DATABASE dbIzmjene

