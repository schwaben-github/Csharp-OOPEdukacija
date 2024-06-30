-- kreiranje baze podataka
CREATE DATABASE CD_DVD_Zbirka;
GO

USE CD_DVD_Zbirka;
GO

-- kreiranje tablica
CREATE TABLE prijatelji (
  prijateljID INT PRIMARY KEY IDENTITY(1,1),
  ime NVARCHAR(50),
  prezime NVARCHAR(50),
  telefon VARCHAR(10),
);

CREATE TABLE mediji (
  medijID INT PRIMARY KEY IDENTITY(1,1),
  naslov NVARCHAR(75),
  tip  NVARCHAR(10),
);

CREATE TABLE posudbe (
  posudbaID INT PRIMARY KEY IDENTITY(1,1),
  prijateljID INT,
  datum_posudbe DATE,
  datum_vracanja DATE,
  medijID INT,
  FOREIGN KEY (prijateljID) REFERENCES prijatelji(prijateljID),
  FOREIGN KEY (medijID) REFERENCES mediji(medijID)
);

-- unos podataka
INSERT INTO prijatelji (ime, prezime) VALUES
('Jozo', 'Parmačević'),
('Marica', 'Barić'),
('Franjo', 'Šaronić'),
('Barica', 'Abramić'),
('Petar', 'Cvenić');

INSERT INTO mediji (naslov, tip) VALUES
('Thriller', 'CD'),
('Back in Black', 'CD'),
('The Dark Side of the Moon', 'CD'),
('The Wall', 'CD'),
('Abbey Road', 'CD'),
('Rumours', 'CD'),
('Hotel California', 'CD'),
('Led Zeppelin IV', 'CD'),
('The Joshua Tree', 'CD'),
('Nevermind', 'CD'),
('Sgt. Pepper’s Lonely Hearts Club Band', 'CD'),
('Purple Rain', 'CD'),
('Born in the U.S.A.', 'CD'),
('Bad', 'CD'),
('Goodbye Yellow Brick Road', 'CD'),
('A Night at the Opera', 'CD'),
('Appetite for Destruction', 'CD'),
('Thriller', 'CD'),
('Back to Black', 'CD'),
('21', 'CD'),
('1989', 'CD'),
('To Pimp a Butterfly', 'CD'),
('The Marshall Mathers LP', 'CD'),
('OK Computer', 'CD'),
('Lemonade', 'CD'),
('The Godfather', 'DVD'),
('The Shawshank Redemption', 'DVD'),
('Pulp Fiction', 'DVD'),
('The Dark Knight', 'DVD'),
('Schindlers List', 'DVD'),
('Forrest Gump', 'DVD'),
('Inception', 'DVD'),
('The Matrix', 'DVD'),
('Fight Club', 'DVD'),
('The Lord of the Rings: The Fellowship of the Ring', 'DVD'),
('Star Wars: Episode IV - A New Hope', 'DVD'),
('The Silence of the Lambs', 'DVD'),
('Saving Private Ryan', 'DVD'),
('The Avengers', 'DVD'),
('Titanic', 'DVD'),
('Jurassic Park', 'DVD'),
('Gladiator', 'DVD'),
('The Lion King', 'DVD'),
('The Godfather: Part II', 'DVD'),
('Goodfellas', 'DVD'),
('Braveheart', 'DVD'),
('Casablanca', 'DVD'),
('Back to the Future', 'DVD'),
('The Terminator', 'DVD'),
('Rocky', 'DVD'),
('To Kill a Mockingbird', 'Knjiga'),
('1984', 'Knjiga'),
('Pride and Prejudice', 'Knjiga'),
('The Great Gatsby', 'Knjiga'),
('Moby-Dick', 'Knjiga'),
('War and Peace', 'Knjiga'),
('The Catcher in the Rye', 'Knjiga'),
('The Lord of the Rings', 'Knjiga'),
('Jane Eyre', 'Knjiga'),
('Crime and Punishment', 'Knjiga'),
('The Hobbit', 'Knjiga'),
('Anna Karenina', 'Knjiga'),
('Brave New World', 'Knjiga'),
('Harry Potter and the Philosophers Stone', 'Knjiga'),
('The Kite Runner', 'Knjiga'),
('The Da Vinci Code', 'Knjiga'),
('The Alchemist', 'Knjiga'),
('The Catch-22', 'Knjiga'),
('The Chronicles of Narnia', 'Knjiga'),
('The Book Thief', 'Knjiga'),
('The Grapes of Wrath', 'Knjiga'),
('Wuthering Heights', 'Knjiga'),
('Great Expectations', 'Knjiga'),
('The Picture of Dorian Gray', 'Knjiga'),
('Frankenstein', 'Knjiga');

INSERT INTO posudbe (prijateljID, datum_posudbe, datum_vracanja, medijID) VALUES
(1, '2024-05-01', NULL, 7),
(2, '2024-05-03', NULL, 45),
(3, '2024-05-05', '2024-05-19', 73),
(4, '2024-05-07', NULL, 56),
(5, '2024-05-09', '2024-05-23', 3);

-- upit za popis prijatelja koji nisu vratili medij i broj dana kod njih
SELECT p.ime AS 'Ime', p.prezime AS 'Prezime', DATEDIFF(DAY, l.datum_posudbe, GETDATE()) AS 'Dana Kod Prijatelja'
FROM prijatelji p
JOIN posudbe l ON p.prijateljID = l.prijateljID
WHERE l.datum_vracanja IS NULL;

-- upit za popis prijatelja koji nisu vratili medij + NASLOV MEDIJA + i broj dana kod njih
SELECT p.ime AS 'Ime', p.prezime AS 'Prezime', m.naslov AS 'Naslov', DATEDIFF(DAY, l.datum_posudbe, GETDATE()) AS 'Dana Kod Prijatelja'
FROM prijatelji p
JOIN posudbe l ON p.prijateljID = l.prijateljID
JOIN mediji m ON l.medijID = m.medijID
WHERE l.datum_vracanja IS NULL;

-- ažuriranje datumskog polja za sve prijatelje koji nisu vratili medij na aktualni datum
UPDATE posudbe
SET datum_vracanja = GETDATE()
WHERE datum_vracanja IS NULL;