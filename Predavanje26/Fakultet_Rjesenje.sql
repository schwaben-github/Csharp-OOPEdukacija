USE Fakultet;
GO

-- 2. Ispiši imena i prezimena studenata koji su barem jednom pali na ispitu iz predmeta sa šiframa od 220 do 240.
SELECT DISTINCT s.imeStud AS Ime, s.prezStud AS Prezime
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
WHERE i.sifPred BETWEEN 220 AND 240
  AND i.ocjena < 2;

-- 3. Ispiši imena i prezimena studenata koji su na nekom ispitu dobili 3.
SELECT DISTINCT s.imeStud AS Ime, s.prezStud AS Prezime
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
WHERE i.ocjena = 3;

-- 4. Ispiši nazive predmeta na koje je izašao barem jedan student.
SELECT DISTINCT p.nazPred AS Naziv_Kolegija
FROM pred p
JOIN ispit i ON p.sifPred = i.sifPred;

-- 5. Ispiši nazive predmeta na koje nije izašao niƟ jedan student.
SELECT p.nazPred AS Naziv_Kolegija
FROM pred p
LEFT JOIN ispit i ON p.sifPred = i.sifPred
WHERE i.sifPred IS NULL;

-- 6. Ispiši oznake dvorana i nazive kolegija za one kolegije koji imaju više od 2 sata predavanja tjedno.
SELECT DISTINCT d.oznDvorana AS Oznaka_Dvorane, p.nazPred AS Naziv_Kolegija
FROM dvorana d
JOIN rezervacija r ON d.oznDvorana = r.oznDvorana
JOIN pred p ON r.sifPred = p.sifPred
WHERE p.brojSatiTjedno > 2;

-- 7. Ispiši nazive predmeta i organizacijske jedinice kojima pripadaju za one kolegije koji imaju više od 20 upisanih studenata.
SELECT p.nazPred AS Naziv_Kolegija, o.nazOrgjed AS Fakultet
FROM pred p
JOIN orgjed o ON p.sifOrgjed = o.sifOrgjed
WHERE p.upisanoStud > 20;

-- 8. Ispiši sve nazive mjesta u kojima barem jedan student stanuje.
-- Imena mjesta smiju se pojaviƟ samo jednom
SELECT DISTINCT m.nazMjesto AS Ime_Mjesta
FROM stud s
JOIN mjesto m ON s.pbrStan = m.pbr;

-- 9. Ispiši ime i prezime studenta, te naziv i ocjenu za svaki ispit.
SELECT s.imeStud AS Ime, s.prezStud AS Prezime, p.nazPred AS Naziv_Kolegija, i.ocjena AS Ocjena
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
JOIN pred p ON i.sifPred = p.sifPred;

-- 10. Ispiši nazive kolegija i oznake dvorana u kojima imaju rezerviran termin. 
-- Ispišite i naziv organizacijske jedinice kojoj kolegij pripada.
SELECT p.nazPred AS Naziv_Kolegija, d.oznDvorana AS Oznaka_Dvorane, o.nazOrgjed AS Fakultet
FROM pred p
JOIN rezervacija r ON p.sifPred = r.sifPred
JOIN dvorana d ON r.oznDvorana = d.oznDvorana
JOIN orgjed o ON p.sifOrgjed = o.sifOrgjed;

-- 11. Ispiši podatke o studentima i njihovim mjestima stanovanja za one studente koji su barem jednom pali na ispitu „Osnove baze podataka”
SELECT s.mbrStud AS Matični_Broj, s.imeStud AS Ime, s.prezStud AS Prezime, m.nazMjesto AS Mjesto
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
JOIN mjesto m ON s.pbrStan = m.pbr
JOIN pred p ON i.sifPred = p.sifPred
WHERE p.nazPred = 'Osnove baze podataka' AND i.ocjena < 2;

-- 12. Ispiši ime i prezime nastavnika, mjesto stanovanja i županiju nastavnika te naziv kolegija
-- za nastavnike koji su ispitivali studente koji su dobili ocjenu 2 ili 3 iz tog kolegija
SELECT n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika, m.nazMjesto AS Mjesto, z.nazZupanija AS Županija, p.nazPred AS Naziv_Kolegija
FROM nastavnik n
JOIN ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto m ON n.pbrStan = m.pbr
JOIN zupanija z ON m.sifZupanija = z.sifZupanija
JOIN pred p ON i.sifPred = p.sifPred
WHERE i.ocjena IN (2, 3);


-- SELECT s.imeStud AS Ime, s.prezStud AS Prezime, m1.nazMjesto AS Mjesto_Rodjenja, z1.nazZupanija AS Zupanija_Rodjenja
-- FROM stud s
-- JOIN mjesto m1 ON s.pbrRod = m1.pbr
-- JOIN zupanija z1 ON m1.sifZupanija = z1.sifZupanija;

-- 13. Ispiši ime i prezime studenta, te mjesto i županiju u kojoj su rođeni. Nakon toga dodaj mjesto i županiju u kojoj stanuju
SELECT s.imeStud AS Ime, s.prezStud AS Prezime, m1.nazMjesto AS Mjesto_Rodjenja, z1.nazZupanija AS Zupanija_Rodjenja, m2.nazMjesto AS Mjesto_Stanovanja, z2.nazZupanija AS Zupanija_Stanovanja
FROM stud s
JOIN mjesto m1 ON s.pbrRod = m1.pbr
JOIN zupanija z1 ON m1.sifZupanija = z1.sifZupanija
JOIN mjesto m2 ON s.pbrStan = m2.pbr
JOIN zupanija z2 ON m2.sifZupanija = z2.sifZupanija;

-- 14. Ispiši nazive mjesta u kojima je barem jedan student i rođen i stanuje. Imena mjesta smiju se pojaviti samo jednom
SELECT DISTINCT m1.nazMjesto AS Mjesto
FROM stud s
JOIN mjesto m1 ON s.pbrRod = m1.pbr

UNION

SELECT DISTINCT m2.nazMjesto AS Mjesto
FROM stud s
JOIN mjesto m2 ON s.pbrStan = m2.pbr;

-- 15. Ispiši podatke o nastavnicima koji su ispitivali studente koji stanuju u istoj županiji u kojoj stanuje i nastavnik
SELECT DISTINCT n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika, n.pbrStan AS Pbr_Nastavnik, m1.sifZupanija AS Zupanija_Nastavnik
FROM nastavnik n
JOIN ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto m1 ON n.pbrStan = m1.pbr
JOIN mjesto m2 ON s.pbrStan = m2.pbr AND m1.sifZupanija = m2.sifZupanija;

-- 16. Ispiši podatke o studentima koji studiraju u mjestu različitom od mjesta rođenja,
-- ali koje se nalazi u istoj županiji u kojoj su i rođeni
SELECT s.imeStud AS Ime, s.prezStud AS Prezime, m1.nazMjesto AS Mjesto_Rodjenja, m2.nazMjesto AS Mjesto_Stanovanja, z.nazZupanija AS Županija
FROM stud s
JOIN mjesto m1 ON s.pbrRod = m1.pbr
JOIN mjesto m2 ON s.pbrStan = m2.pbr
JOIN zupanija z ON m1.sifZupanija = z.sifZupanija
WHERE m1.sifZupanija = m2.sifZupanija AND m1.nazMjesto <> m2.nazMjesto;

-- 17. Ispiši podatke o studentima i nastavnicima koji imaju ista prezimena
SELECT s.imeStud AS Ime_Studenta, s.prezStud AS Prezime_Studenta, n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika
FROM stud s
JOIN nastavnik n ON s.prezStud = n.prezNastavnik;

-- FUNKCIJE
-- 1. Ispiši ime i prezime te mjesto rođenja studenata kojima ime počinje slovom F
SELECT imeStud AS Ime_Studenta, prezStud AS Prezime_Studenta, m.nazMjesto AS Mjesto_Rodjenja
FROM stud
JOIN mjesto m ON stud.pbrRod = m.pbr
WHERE imeStud LIKE 'F%';

-- 2. Ispiši ime i prezime nastavnika koji živi u mjestu koje na trećem mjestu naziva ima slovo Z
SELECT imeNastavnik AS Ime, prezNastavnik AS Prezime
FROM nastavnik
JOIN mjesto ON nastavnik.pbrStan = mjesto.pbr
WHERE SUBSTRING(mjesto.nazMjesto, 3, 1) = 'Z';

-- 3. Ispiši ime i prezime studenata te imena i prezimena nastavnika koji u imenu na petom mjestu imaju isto slovo
SELECT s.imeStud AS ImeStudenta, s.prezStud AS PrezimeStudenta, n.imeNastavnik AS ImeNastavnika, n.prezNastavnik AS PrezimeNastavnika
FROM stud s
JOIN nastavnik n ON SUBSTRING(s.imeStud, 5, 1) = SUBSTRING(n.imeNastavnik, 5, 1);

-- 4. Ispiši nazive županija kojima je duljina imena duža od 13 znakova, a kraća od 20 znakova
SELECT nazZupanija AS Zupanija
FROM zupanija
WHERE LEN(nazZupanija) > 13 AND LEN(nazZupanija) < 20;

-- 5. Ispiši ime i prezime studenata koji su rođeni u svibnju
SELECT imeStud AS Ime, prezStud AS Prezime
FROM stud
WHERE MONTH(datRodStud) = 5;

--6. Ispiši imena i prezimena studenata koji su na ispit izašli između 10. i 20. u mjesecu
SELECT imeStud AS Ime, prezStud AS Prezime
FROM stud
JOIN ispit ON stud.mbrStud = ispit.mbrStud
WHERE DAY(datIspit) BETWEEN 10 AND 20;

-- 7. Pronađi podatke o onim nastavnicima koji su u lipnju ispitivali studente čije je mjesto rođenja isto mjestu nastavnikova stanovanja.
-- Ispiši ime i prezime nastavnika, naziv mjesta u kojem stanuje, ime i prezime studenta te naziv mjesta u kojem je rođen
SELECT n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika, m1.nazMjesto AS Mjesto_Stanovanja,
       s.imeStud AS Ime_Studenta, s.prezStud AS Prezime_Studenta, m2.nazMjesto AS Mjesto_Rodjenja
FROM nastavnik n
JOIN ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto m1 ON n.pbrStan = m1.pbr
JOIN mjesto m2 ON s.pbrRod = m2.pbr
WHERE MONTH(i.datIspit) = 6 AND m1.nazMjesto = m2.nazMjesto;
