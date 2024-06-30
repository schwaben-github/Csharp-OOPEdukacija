USE Fakultet
GO 

-- JOINOVI
--2. Ispiši imena i prezimena studenata koji su barem jednom pali na ispitu iz predmeta sa šiframa od 220 do 240.
SELECT s.imeStud, s.prezStud
FROM stud s
JOIN Ispit i ON s.mbrStud = i.mbrStud
WHERE i.ocjena = 1 AND i.sifPred BETWEEN 220 AND 240;

--3. Ispiši imena i prezimena studenata koji su na nekom ispitu dobili 3.
SELECT DISTINCT s.imeStud AS Ime, s.prezStud AS Prezime
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
WHERE i.ocjena = 3;

--4. Ispiši nazive predmeta na koje je izašao barem jedan student.
SELECT p.nazPred
FROM pred p
JOIN Ispit i ON p.sifPred = i.sifPred;

--5. Ispiši nazive predmeta na koje nije izašao ni􀆟 jedan student.
SELECT p.nazPred
FROM pred p
LEFT JOIN Ispit i ON p.sifPred = i.sifPred
WHERE i.ocjena IS NULL;

--6. Ispiši oznake dvorana i nazive kolegija za one kolegije koji imaju više od 2 sata predavanja tjedno.
SELECT DISTINCT r.oznDvorana AS Oznaka_Dvorane, p.nazPred AS Naziv_Kolegija
FROM rezervacija r JOIN pred p ON r.sifPred = p.sifPred
WHERE p.brojSatiTjedno > 2;

--7. Ispiši nazive predmeta i organizacijske jedinice kojima pripadaju za one kolegije koji imaju više od 20 upisanih studenata.
SELECT p.nazPred AS Naziv_Kolegija, o.nazOrgjed AS Fakultet
FROM pred p
JOIN orgjed o ON p.sifOrgjed = o.sifOrgjed
WHERE p.upisanoStud > 20;

--8. Ispiši sve nazive mjesta u kojima barem jedan student stanuje. Imena mjesta smiju se pojavi􀆟 samo jednom.
SELECT DISTINCT m.nazMjesto
FROM Mjesto m
JOIN stud s ON m.pbr = s.pbrStan;

--9. Ispiši ime i prezime studenta, te naziv i ocjenu za svaki ispit.
SELECT s.imeStud, s.prezStud, p.nazPred, i.ocjena
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
JOIN pred p ON i.sifPred = p.sifPred;

--10. Ispiši nazive kolegija i oznake dvorana u kojima imaju rezerviran termin. Ispišite i naziv organizacijske jedinice kojoj kolegij pripada.
SELECT p.nazPred AS 'Naziv kolegija', r.oznDvorana AS Oznaka_Dvorane, o.nazOrgjed AS Fakultet
FROM pred p
JOIN rezervacija r ON p.sifPred = r.sifPred
JOIN orgjed o ON p.sifOrgjed = o.sifOrgjed;

--11. Ispiši podatke o studen􀆟ma i njihovim mjes􀆟ma stanovanja za one studente koji su barem jednom pali na ispitu „Osnove baze podataka”.
SELECT s.mbrStud AS Matični_Broj, s.imeStud AS Ime, s.prezStud AS Prezime, m.nazMjesto AS Mjesto
FROM stud s
JOIN ispit i ON s.mbrStud = i.mbrStud
JOIN mjesto m ON s.pbrStan = m.pbr
JOIN pred p ON i.sifPred = p.sifPred
WHERE p.nazPred = 'Osnove baze podataka' AND i.ocjena = 1;

-- 12. Ispiši ime i prezime nastavnika, mjesto stanovanja i županiju nastavnika te naziv kolegija za nastavnike koji su ispi􀆟vali studente koji su dobili ocjenu 2 ili 3 iz tog kolegija.
SELECT n.imeNastavnik, n.prezNastavnik, mj.nazMjesto AS MjestoStanovanja, z.nazZupanija AS Zupanija, p.nazPred AS Kolegij
FROM Nastavnik n
JOIN Mjesto mj ON n.pbrStan = mj.pbr
JOIN Zupanija z ON mj.sifZupanija = z.sifZupanija
JOIN Ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN pred p ON i.sifPred = p.sifPred
WHERE i.ocjena IN (2, 3);

--13. Ispiši ime i prezime studenta, te mjesto i županiju u kojoj su rođeni. Nakon toga dodaj mjesto i županiju u kojoj stanuju.
SELECT s.imeStud, s.prezStud, mjRod.nazMjesto AS MjestoRodjenja, zRod.nazZupanija AS ZupanijaRodjenja,
       mjStan.nazMjesto AS MjestoStanovanja, zStan.nazZupanija AS ZupanijaStanovanja
FROM stud s
JOIN Mjesto mjRod ON s.pbrRod = mjRod.pbr
JOIN Zupanija zRod ON mjRod.sifZupanija = zRod.sifZupanija
JOIN Mjesto mjStan ON s.pbrStan = mjStan.pbr
JOIN Zupanija zStan ON mjStan.sifZupanija = zStan.sifZupanija;

--14. Ispiši nazive mjesta u kojima je barem jedan student i rođen i stanuje. Imena mjesta smiju se pojavi􀆟 samo jednom.
SELECT DISTINCT mj.nazMjesto
FROM stud s
JOIN Mjesto mj ON s.pbrRod = mj.pbr
WHERE s.pbrRod = s.pbrStan;

-- 15. Ispiši podatke o nastavnicima koji su ispi􀆟vali studente koji stanuju u istoj županiji u kojoj stanuje i nastavnik.
SELECT DISTINCT n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika, 
n.pbrStan AS Pbr_Nastavnik, m1.sifZupanija AS Zupanija_Nastavnik
FROM nastavnik n
JOIN ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto m1 ON n.pbrStan = m1.pbr
JOIN mjesto m2 ON s.pbrStan = m2.pbr 
WHERE m1.sifZupanija = m2.sifZupanija;

--16. Ispiši podatke o studen􀆟ma koji studiraju u mjestu različitom od mjesta rođenja, ali koje se nalazi u istoj županiji u kojoj su i rođeni.
SELECT s.imeStud AS Ime, s.prezStud AS Prezime, m1.nazMjesto AS Mjesto_Rodjenja, m2.nazMjesto AS Mjesto_Stanovanja, z.nazZupanija AS Županija
FROM stud s
JOIN mjesto m1 ON s.pbrRod = m1.pbr
JOIN mjesto m2 ON s.pbrStan = m2.pbr
JOIN zupanija z ON m1.sifZupanija = z.sifZupanija
WHERE m1.sifZupanija = m2.sifZupanija AND m1.nazMjesto <> m2.nazMjesto;

--17. Ispiši podatke o studen􀆟ma i nastavnicima koji imaju ista prezimena.
SELECT s.imeStud AS Ime_Studenta, s.prezStud AS Prezime_Studenta, n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika
FROM stud s
JOIN nastavnik n ON s.prezStud = n.prezNastavnik;

SELECT s.imeStud AS Ime_Studenta, s.prezStud AS Prezime_Studenta, n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika
FROM stud s, nastavnik n WHERE s.prezStud = n.prezNastavnik;


--FUNKCIJE
-- 1. Ispiši ime i prezime te mjesto rođenja studenata kojima ime počinje slovom F.
SELECT imeStud, prezStud, (SELECT nazMjesto FROM Mjesto WHERE pbr = s.pbrRod) AS MjestoRodjenja
FROM stud s
WHERE imeStud LIKE 'F%';

SELECT imeStud AS Ime_Studenta, prezStud AS Prezime_Studenta, m.nazMjesto AS Mjesto_Rodjenja
FROM stud
JOIN mjesto m ON stud.pbrRod = m.pbr
WHERE imeStud LIKE 'F%';

--2. Ispiši ime i prezime nastavnika koji živi u mjestu koje na trećem mjestu naziva ima slovo Z.
SELECT imeNastavnik, prezNastavnik
FROM Nastavnik n
JOIN Mjesto m ON n.pbrStan = m.pbr
WHERE SUBSTRING(m.nazMjesto, 3, 1) = 'Z';

--3. Ispiši ime i prezime studenata te imena i prezimena nastavnika koji u imenu na petom mjestu imaju isto slovo.
SELECT s.imeStud, s.prezStud, n.imeNastavnik, n.prezNastavnik
FROM stud s
JOIN Nastavnik n ON SUBSTRING(s.imeStud, 5, 1) = SUBSTRING(n.imeNastavnik, 5, 1);

--4. Ispiši nazive županija kojima je duljina imena duža od 13 znakova, a kraća od 20 znakova.
SELECT nazZupanija AS Zupanija
FROM zupanija
WHERE LEN(nazZupanija) > 13 AND LEN(nazZupanija) < 20;

--5. Ispiši ime i prezime studenata koji su rođeni u svibnju.
SELECT imeStud AS Ime, prezStud AS Prezime
FROM stud
WHERE MONTH(datRodStud) = 5;

--6. Ispiši imena i prezimena studenata koji su na ispit izašli između 10. i 20. u mjesecu.
SELECT imeStud AS Ime, prezStud AS Prezime
FROM stud
JOIN ispit ON stud.mbrStud = ispit.mbrStud
WHERE DAY(datIspit) BETWEEN 10 AND 20;

--7. Pronađi podatke o onim nastavnicima koji su u lipnju ispi􀆟vali studente čije je mjesto rođenja isto mjestu nastavnikova
--stanovanja. Ispiši ime i prezime nastavnika, naziv mjesta u kojem stanuje, ime i prezime studenta te naziv mjesta u kojem
--je rođen.
SELECT n.imeNastavnik AS Ime_Nastavnika, n.prezNastavnik AS Prezime_Nastavnika, m1.nazMjesto AS Mjesto_Stanovanja,
       s.imeStud AS Ime_Studenta, s.prezStud AS Prezime_Studenta, m2.nazMjesto AS Mjesto_Rodjenja
FROM nastavnik n
JOIN ispit i ON n.sifNastavnik = i.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto m1 ON n.pbrStan = m1.pbr
JOIN mjesto m2 ON s.pbrRod = m2.pbr
WHERE MONTH(i.datIspit) = 6 AND
m1.nazMjesto = m2.nazMjesto;