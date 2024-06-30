USE WebShop
SELECT * FROM Narudzbe
SELECT * FROM NarudzbeDetalji

--INNER JOIN
SELECT * FROM NarudzbeDetalji AS nd 
INNER JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id

SELECT * FROM NarudzbeDetalji AS nd 
INNER JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id
INNER JOIN Proizvodi AS p ON nd.ProizvodId=p.Id

--RIGHT JOIN
SELECT * FROM NarudzbeDetalji AS nd 
RIGHT JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id

SELECT * FROM NarudzbeDetalji AS nd 
RIGHT JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id
RIGHT JOIN Proizvodi AS p ON nd.ProizvodId=p.Id

--LEFT JOIN
SELECT * FROM NarudzbeDetalji AS nd 
LEFT JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id

SELECT * FROM NarudzbeDetalji AS nd 
LEFT JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id
LEFT JOIN Proizvodi AS p ON nd.ProizvodId=p.Id

-- FULL OUTER JOIN
SELECT * FROM NarudzbeDetalji AS nd 
FULL OUTER JOIN Narudzbe AS n ON nd.NarudzbaId = n.Id
FULL OUTER JOIN Proizvodi AS p ON nd.ProizvodId=p.Id

--CROSS JOIN
SELECT * FROM Proizvodi, KategorijeProizvodi, Kategorije

SELECT * FROM MjereProizvoda
SELECT * FROM Proizvodi
-- 1. INNER JOIN tablica MjereProizvoda i Proizvodi
SELECT * FROM Proizvodi AS mp
INNER JOIN MjereProizvoda AS p
ON mp.Id = p.Id

-- 2. LEFT JOIN tablica MjereProizvoda i Proizvodi
SELECT * FROM Proizvodi AS mp
LEFT JOIN MjereProizvoda AS p
ON mp.Id = p.Id

-- 3. RIGHT JOIN tablica MjereProizvoda i Proizvodi
SELECT * FROM Proizvodi AS mp
RIGHT JOIN MjereProizvoda AS p
ON mp.Id = p.Id

-- 4. REKURZIVNO SPAJANJE
SELECT * FROM KategorijeProizvodi AS kp1
INNER JOIN KategorijeProizvodi AS kp2
ON kp1.ProizvodId = kp2.ProizvodId WHERE kp1.Id <> kp2.Id

-- 5. FULL OUTER JOIN
SELECT * FROM Proizvodi AS mp
FULL OUTER JOIN MjereProizvoda AS p
ON mp.Id = p.Id

-- Update sa spajanjem tablica
SELECT * FROM Proizvodi AS p
INNER JOIN KategorijeProizvodi AS kp ON p.Id = kp.ProizvodId
INNER JOIN Kategorije AS k ON k.Id = kp.KategorijaId
WHERE k.Id = 2

-- Zadatak: dodati u naziv proizvoda kategoriju u kojoj se proizvod nalazi 
-- (samo za proizvode iz kategorije 2)
UPDATE p SET p.Naziv = CONCAT(p.Naziv, '-', k.Naziv) FROM Proizvodi AS p
INNER JOIN KategorijeProizvodi AS kp ON p.Id = kp.ProizvodId
INNER JOIN Kategorije AS k ON k.Id = kp.KategorijaId
WHERE k.Id = 2

SELECT * FROM Proizvodi