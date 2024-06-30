-- 2.
SELECT Ime, Prezime FROM Korisnici

-- 3.
SELECT Id, CONCAT(Ime, ' ', Prezime) AS ImePrezime
FROM Korisnici;

SELECT Id, Ime, ' ', Prezime AS 'Ime i prezime'
FROM Korisnici

-- 4.
SELECT DISTINCT Ime FROM Korisnici ORDER BY Ime DESC;

-- 5.
SELECT * FROM Proizvodi WHERE JeDostupan = 1

-- 6.
SELECT Naziv, ROUND(Cijena * 1.25, 2) AS 'Cijena sa PDV-om'
FROM Proizvodi

-- 7.
SELECT * FROM Proizvodi
WHERE Cijena * 1.25 < 10 OR Cijena * 1.25 > 100;

-- 8.
SELECT * FROM Korisnici
WHERE LOWER(LEFT(Ime, 1)) IN ('a', 'e', 'i', 'o', 'u')
	AND LOWER(RIGHT(Ime, 1)) IN ('a', 'e', 'i', 'o', 'u');

SELECT * FROM Korisnici
WHERE Ime LIKE '[aeiou]%[aeiou]'
-- % = bilo koji znaci i bilo koji broj njih
-- _ = samo jedan znak

-- 9.
SELECT * FROM Korisnici
WHERE LOWER(LEFT(Ime, 1)) NOT IN ('a', 'e', 'i', 'o', 'u')
	AND LOWER(RIGHT(Ime, 1)) NOT IN ('a', 'e', 'i', 'o', 'u');

SELECT * FROM Korisnici
WHERE Ime LIKE '[^aeiou]%[^aeiou]'

-- 10.
-- SELECT * FROM Korisnici
-- WHERE LOWER(LEFT(Prezime, 1)) IN ('a', 'e', 'i', 'o', 'u')
--	OR LOWER(RIGHT(Prezime, 1)) IN ('a', 'e', 'i', 'o', 'u');

SELECT * FROM Korisnici
WHERE Ime LIKE '[aeiou]%' OR Prezime LIKE '%[aeiou]'

-- 11.
SELECT * FROM Korisnici
WHERE Prezime LIKE '%rk%' OR Ime LIKE '%rk%';