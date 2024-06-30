-- Kreiranje baze podataka Fakultet
CREATE DATABASE Fakultet;
GO

-- Koristite bazu podataka Fakultet
USE Fakultet;
GO

-- Kreiranje tablice orgjed
CREATE TABLE orgjed (
    sifOrgjed INT PRIMARY KEY,
    nazOrgjed NVARCHAR(50),
    sifNadorgjed INT NULL,
    CONSTRAINT FK_Orgjed_Nadorgjed FOREIGN KEY (sifNadorgjed) REFERENCES orgjed(sifOrgjed)
);
GO

-- Kreiranje tablice nastavnik
CREATE TABLE nastavnik (
    sifNastavnik INT PRIMARY KEY,
    imeNastavnik NVARCHAR(50),
    prezNastavnik NVARCHAR(50),
    pbrStan INT,
    sifOrgjed INT,
    koef FLOAT,
    CONSTRAINT FK_Nastavnik_Orgjed FOREIGN KEY (sifOrgjed) REFERENCES orgjed(sifOrgjed)
);
GO

-- Kreiranje tablice pred
CREATE TABLE pred (
    sifPred INT PRIMARY KEY,
    kratPred NVARCHAR(50) NULL,
    nazPred NVARCHAR(50),
    sifOrgjed INT NULL,
    upisanoStud INT NULL,
    brojSatiTjedno INT NULL,
    CONSTRAINT FK_Pred_Orgjed FOREIGN KEY (sifOrgjed) REFERENCES orgjed(sifOrgjed)
);
GO

-- Kreiranje tablice ispit
CREATE TABLE ispit (
    mbrStud INT NULL,
    sifPred INT,
    sifNastavnik INT,
    datIspit DATE,
    ocjena INT,
    CONSTRAINT FK_Ispit_Pred FOREIGN KEY (sifPred) REFERENCES pred(sifPred),
    CONSTRAINT FK_Ispit_Nastavnik FOREIGN KEY (sifNastavnik) REFERENCES nastavnik(sifNastavnik)
);
GO

-- Kreiranje tablice dvorana
CREATE TABLE dvorana (
    oznDvorana INT PRIMARY KEY,
    kapacitet INT NULL
);
GO

-- Kreiranje tablice zupanija
CREATE TABLE zupanija (
    sifZupanija INT PRIMARY KEY,
    nazZupanija NVARCHAR(50)
);
GO

-- Kreiranje tablice mjesto
CREATE TABLE mjesto (
    pbr INT PRIMARY KEY,
    nazMjesto NVARCHAR(250),
    sifZupanija INT NULL,
    CONSTRAINT FK_Mjesto_Zupanija FOREIGN KEY (sifZupanija) REFERENCES zupanija(sifZupanija)
);
GO

-- Kreiranje tablice stud
CREATE TABLE stud (
    mbrStud INT PRIMARY KEY,
    imeStud NVARCHAR(50),
    prezStud NVARCHAR(50),
    pbrRod INT NULL,
    pbrStan INT,
    datRodStud DATE NULL,
    oibStud NVARCHAR(13) NULL,
    CONSTRAINT FK_Stud_MjestoRod FOREIGN KEY (pbrRod) REFERENCES mjesto(pbr),
    CONSTRAINT FK_Stud_MjestoStan FOREIGN KEY (pbrStan) REFERENCES mjesto(pbr)
);
GO

-- Kreiranje tablice rezervacija
CREATE TABLE rezervacija (
    oznDvorana INT NULL,
    oznVrstaDan NVARCHAR(10),
    sat INT,
    sifPred INT,
    CONSTRAINT FK_Rezervacija_Dvorana FOREIGN KEY (oznDvorana) REFERENCES dvorana(oznDvorana),
    CONSTRAINT FK_Rezervacija_Pred FOREIGN KEY (sifPred) REFERENCES pred(sifPred)
);
GO

ALTER TABLE nastavnik
ADD CONSTRAINT FK_Nastavnik_Mjesto FOREIGN KEY (pbrStan) REFERENCES mjesto(pbr);
GO