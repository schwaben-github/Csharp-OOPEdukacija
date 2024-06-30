--2. Ispiši samo imena i prezimena korisnika.
SELECT Ime, Prezime FROM Korisnici

--3. Ispiši Id te ime i prezime svih korisnika. Ime i prezime treba ispisa􀆟 zajedno u jednom stupcu.
SELECT Id, CONCAT(Ime, ' ', Prezime) AS ImePrezime
FROM Korisnici

SELECT Id, Ime + ' ' + Prezime AS 'Ime i prezime'
FROM Korisnici

--4. Ispiši sva imena korisnika tako da se ni􀆟 jedno ne pojavi dva puta. Sor􀆟raj imena silazno po abecedi.
SELECT DISTINCT Ime FROM Korisnici ORDER BY Ime DESC;


--5. Ispiši sve dostupne proizvode.
SELECT * FROM Proizvodi WHERE JeDostupan = 1
-- da budu neki dostupni: UPDATE Proizvodi SET JeDostupan = 1 WHERE Id > 10

--6. Ispiši nazive praoizvoda te njihovu cijenu sa PDV-om (prema formuli Cijena*1.25)
SELECT Naziv, ROUND(Cijena * 1.25, 2) AS 'Cijena sa PDV-om'
FROM Proizvodi

--7. Ispiši sve proizvode koji imaju cijenu sa PDV-om manju od 10 ili veću od 100.
SELECT * FROM Proizvodi
WHERE Cijena * 1.25 < 10 OR Cijena * 1.25 > 100;

--8. Ispiši sve podatke o korisnicima čije ime počinje i završava samoglasnikom.
SELECT * FROM Korisnici
WHERE LOWER(LEFT(Ime, 1)) IN ('a', 'e', 'i', 'o', 'u')
AND LOWER(RIGHT(Ime, 1)) IN ('a', 'e', 'i', 'o', 'u');

SELECT * FROM Korisnici WHERE Ime LIKE '[aeiou]%[aeiou]'

-- samo za 1 znak između prvog i zadnjeg:
INSERT INTO Korisnici (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
 ('Ivica', 'Perić', 'pero@peric.com', 'Perin put 11', '0124354645', 'Pero ima velikog psa')

SELECT * FROM Korisnici WHERE Ime LIKE '[aeiou]_[aeiou]'


--9. Ispiši sve podatke o korisnicima čije ime počinje i završava bilo kojim znakom osim samoglasnikom.
SELECT * FROM Korisnici
WHERE LOWER(LEFT(Ime, 1)) NOT IN ('a', 'e', 'i', 'o', 'u')
AND LOWER(RIGHT(Ime, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');

-- Znak ^ predstavlja negaciju u like naredbi
SELECT * FROM Korisnici WHERE Ime LIKE '[^aeiou]%[^aeiou]'

INSERT INTO Korisnici (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
 ('Petar', 'Perić', 'pero@peric.com', 'Perin put 11', '0124354645', 'Pero ima velikog psa')

--10. Ispiši sve podatke o korisnicima čije ime počinje ili završava samoglasnikom.
SELECT * FROM Korisnici WHERE Ime LIKE '[aeiou]%' OR Ime LIKE '%[aeiou]'

--11. Ispiši sve podatke o korisnicima kojima ime ili prezime bilo gdje sadrži slova r i k jedno iza drugog.
SELECT * FROM Korisnici WHERE Ime LIKE '%rk%' OR Prezime LIKE '%rk%'

INSERT INTO Korisnici (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
 ('Darko', 'Perić', 'pero@peric.com', 'Perin put 11', '0124354645', 'Pero ima velikog psa'), 
 ('Petar', 'Perković', 'pero@peric.com', 'Perin put 11', '0124354645', 'Pero ima velikog psa')