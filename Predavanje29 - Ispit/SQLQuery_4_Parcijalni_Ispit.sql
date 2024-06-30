-- 1. Zadatak
-- Kreiranje baze
CREATE DATABASE ParcijalniIspit4;
GO

USE ParcijalniIspit4;
GO

-- Tablica mjesta stanovanja članova
CREATE TABLE MjestaStanovanja (
    Id INT PRIMARY KEY,
    Grad VARCHAR(255),
    Drzava VARCHAR(255),
    PostanskiBroj VARCHAR(20)
);

-- Tablica autora
CREATE TABLE Autori (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ime VARCHAR(255),
    Prezime VARCHAR(255),
    DatumRodjenja DATE,
    Nacionalnost VARCHAR(255)
);

-- Tablica članova
CREATE TABLE Clanovi (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ime VARCHAR(255),
    Prezime VARCHAR(255),
    Email VARCHAR(255),
    Telefon VARCHAR(50),
    MjestoID INT,
    FOREIGN KEY (MjestoID) REFERENCES MjestaStanovanja(MjestoID)
);

-- Tablica knjiga
CREATE TABLE Knjige (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Naslov VARCHAR(255),
    GodinaIzdanja INT,
    Zanr VARCHAR(255),
    AutorID INT,
    FOREIGN KEY (AutorID) REFERENCES Autori(AutorID)
);

-- Tablica posudbi
CREATE TABLE Posudbe (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClanID INT,
    KnjigaID INT,
    DatumPosudbe DATE,
    DatumPovratka DATE,
    FOREIGN KEY (ClanID) REFERENCES Clanovi(ClanID),
    FOREIGN KEY (KnjigaID) REFERENCES Knjige(KnjigaID)
);

-- 2. Zadatak
-- Mijenjanje tablice mjesta stanovanja članova
ALTER TABLE MjestaStanovanja
ALTER COLUMN Grad VARCHAR(255) NOT NULL;

-- Mijenjanje tablice članova
ALTER TABLE Clanovi
ALTER COLUMN Ime VARCHAR(255) NOT NULL;

ALTER TABLE Clanovi
ALTER COLUMN Prezime VARCHAR(255) NOT NULL;

ALTER TABLE Clanovi
ALTER COLUMN DatumRodjenja DATE NOT NULL;

ALTER TABLE Clanovi
ALTER COLUMN MjestoID INT NOT NULL;

ALTER TABLE Clanovi
ADD DatumRodjenja DATE NOT NULL;

-- Mijenjanje tablice knjiga
ALTER TABLE Knjige
ALTER COLUMN Naslov VARCHAR(255) NOT NULL;

ALTER TABLE Knjige
ALTER COLUMN AutorID INT NOT NULL;

-- Mijenjanje tablice posudbi
ALTER TABLE Posudbe
ALTER COLUMN ClanID INT NOT NULL;

ALTER TABLE Posudbe
ALTER COLUMN KnjigaID INT NOT NULL;

ALTER TABLE Posudbe
ALTER COLUMN DatumPosudbe DATE NOT NULL;

-- 3. Zadatak
-- Dodavanje zapisa u tablicu mjesta stanovanja
INSERT INTO MjestaStanovanja (Grad, Drzava, PostanskiBroj) 
VALUES 
('Valpovo', 'Hrvatska', '31550'),
('Osijek', 'Hrvatska', '31000'),
('Zagreb', 'Hrvatska', '10000'),
('Split', 'Hrvatska', '21000'),
('Rijeka', 'Hrvatska', '51000');

-- Dodavanje zapisa u tablicu članova
INSERT INTO Clanovi (Ime, Prezime, DatumRodjenja, Email, Telefon, MjestoID) 
VALUES 
('Jozo', 'Parmačević', '1990-05-15', 'jozeta@email.com', '123456789', 1),
('Ana', 'Parmačević', '1985-10-20', 'ankica@email.com', '987654321', 1),
('Marko', 'Barić', '2000-03-25', 'marko.gorica@email.com', '456123789', 2),
('Franjo', 'Šaronić', '1998-08-12', 'franziznarda@email.com', '321654987', 3),
('Josip', 'Cvenić', '1992-12-03', 'jozeta_theking@email.com', '789456123', 4);

-- Dodavanje zapisa u tablicu autora
INSERT INTO Autori (Ime, Prezime, DatumRodjenja, Nacionalnost) 
VALUES 
('Ivana', 'Brlić-Mažuranić', '1874-04-18', 'Hrvatska'),
('J.R.R.', 'Tolkien', '1892-01-03', 'Velika Britanija'),
('Agatha', 'Christie', '1890-09-15', 'Velika Britanija'),
('George', 'Orwell', '1903-06-25', 'Velika Britanija'),
('Fyodor', 'Dostoevsky', '1821-11-11', 'Rusija');

-- Dodavanje zapisa u tablicu knjiga
INSERT INTO Knjige (Naslov, GodinaIzdanja, Zanr, AutorID) 
VALUES 
('Priče iz davnine', 1916, 'Dječja knjiga', 1),
('Gospodar prstenova', 1954, 'Fantazija', 2),
('Ubojstvo u Orijent ekspresu', 1934, 'Kriminalistički roman', 3),
('1984', 1949, 'Dystopija', 4),
('Zločin i kazna', 1866, 'Psihološki roman', 5);

INSERT INTO Posudbe (ClanID, KnjigaID, DatumPosudbe, DatumPovratka) 
VALUES 
(1, 2, '2024-05-20', NULL),
(2, 3, '2024-06-01', NULL),
(3, 5, '2024-05-10', NULL),
(4, 4, '2024-05-25', NULL),
(5, 1, '2024-06-05', NULL);

-- 4. Zadatak
-- Prezimena članova
SELECT DISTINCT Prezime
FROM Clanovi
ORDER BY Prezime DESC;

-- 5. Zadatak
-- Punoljetni članovi
SELECT c.Ime, c.Prezime, m.Grad
FROM Clanovi c
JOIN MjestaStanovanja m ON c.MjestoID = m.MjestoID
WHERE YEAR(GETDATE()) - YEAR(c.DatumRodjenja) >= 18;

-- 6. Zadatak
-- Zakasnina
SELECT 
    c.Ime AS 'Ime Clana', 
    c.Prezime AS 'Prezime Clana', 
    k.Naslov AS 'Naziv Knjige', 
    CONCAT(a.Ime, ' ', a.Prezime) AS Autor,
    CASE 
        WHEN DATEDIFF(DAY, p.DatumPosudbe, GETDATE()) > 15 THEN (DATEDIFF(DAY, p.DatumPosudbe, GETDATE()) - 15) * 0.5
        ELSE 0 
    END AS Zakasnina
FROM 
    Clanovi c
JOIN 
    Posudbe p ON c.ClanID = p.ClanID
JOIN 
    Knjige k ON p.KnjigaID = k.KnjigaID
JOIN 
    Autori a ON k.AutorID = a.AutorID;
WHERE p.DatumPovratka IS NULL
	AND DATEDIFF(DAY, p.DatumPosudbe, GETDATE()) > 15;

-- 7. Zadatak
-- Čitatelji Ivane Brlić-Mažuranić
SELECT 
    c.Ime AS ImeClana,
    c.Prezime AS PrezimeClana
FROM 
    Clanovi c
JOIN 
    Posudbe p ON c.ClanID = p.ClanID
JOIN 
    Knjige k ON p.KnjigaID = k.KnjigaID
JOIN 
    Autori a ON k.AutorID = a.AutorID
WHERE 
    a.Ime = 'Ivana' AND a.Prezime = 'Brlić-Mažuranić'
    AND c.MjestoID = (SELECT MjestoID FROM MjestaStanovanja WHERE Grad = 'Valpovo');


-- Dopune tablica
-- Dopuna tablice knjiga
INSERT INTO Knjige (Naslov, GodinaIzdanja, Zanr, AutorID) 
VALUES 
('Čudnovate zgode šegrta Hlapića', 1913, 'Dječja knjiga', 1),
('Dječja čitanka o zdravlju', 1927, 'Dječja knjiga', 1),
('Srce od licitara', 1939, 'Dječja knjiga', 1);

-- Dopuna tablice posudbi
INSERT INTO Posudbe (ClanID, KnjigaID, DatumPosudbe, DatumPovratka) 
VALUES
(1, 6, '2024-05-20', NULL),
(2, 7, '2024-06-01', NULL),
(3, 8, '2024-06-01', NULL);