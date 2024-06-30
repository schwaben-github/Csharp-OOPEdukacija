-- Kreiranje baze podataka
CREATE DATABASE Knjiznica
GO

USE Knjiznica
GO


CREATE TABLE kategorijeknjiga(
	kategorijaid int PRIMARY KEY IDENTITY(1,1),
	naziv varchar(50) NOT NULL
);

CREATE TABLE mjestastanovanja(
	adresaid int PRIMARY KEY IDENTITY(1,1),
	grad varchar(50) NOT NULL,
	drzava varchar(50) NOT  NULL
);

CREATE TABLE clanovi(
	clanid INT PRIMARY KEY IDENTITY(1,1),
	ime varchar50 NOT NULL,
	prezime varchar(50) NOT NULL,
	adresaid int NOT NULL,
	FOREIGN KEY (adresaid) REFERENCES mjestastanovanja(adresaid)
);

CREATE TABLE knjige(
	knjigaid int PRIMARY KEY IDENTITY(1,1),
	naslov varchar(100) NOT NULL,
	autor varchar(100) NOT NULL,
	kategorijaid int NOT NULL,
	FOREIGN KEY (kategorijaid) REFERENCES kategorijeknjiga(kategorijaid)
);

CREATE TABLE posudbe(
	posudbaid int PRIMARY KEY IDENTITY(1,1),
	clanid int NOT NULL,
	knjigaid int NOT NULL,
	datumposudbe date NOT NULL,
	datumpovratka [date] NULL,
	FOREIGN KEY (knjigaid) REFERENCES knjige(knjigaid)
);


-- Insert records

INSERT INTO kategorijeknjiga (naziv)
VALUES
    ('Science Fiction'),
    ('Romance'),
    ('Mystery'),
    ('Fantasy'),
    ('Non-Fiction');

INSERT INTO mjestastanovanja (grad, drzava)
VALUES
    ('Zagreb', 'Hrvatska'),
    ('Split', 'Hrvatska'),
    ('Rijeka', 'Hrvatska'),
    ('Osijek', 'Hrvatska'),
    ('Zadar', 'Hrvatska');

INSERT INTO knjige (title, writer, categoryid) VALUES
('Dune', 'Frank Herbert', 1),
('Neuromancer', 'William Gibson', 1),
('Foundation', 'Isaac Asimov', 1),
('Hyperion', 'Dan Simmons', 1),
('Snow Crash', 'Neal Stephenson', 1),
('The Left Hand of Darkness', 'Ursula K. Le Guin', 1),
('1984', 'George Orwell', 1),
('Brave New World', 'Aldous Huxley', 1),
('The Time Machine', 'H.G. Wells', 1),
('Fahrenheit 451', 'Ray Bradbury', 1),
('Pride and Prejudice', 'Jane Austen', 2),
('Gone with the Wind', 'Margaret Mitchell', 2),
('Jane Eyre', 'Charlotte Brontë', 2),
('Wuthering Heights', 'Emily Brontë', 2),
('The Notebook', 'Nicholas Sparks', 2),
('Me Before You', 'Jojo Moyes', 2),
('Outlander', 'Diana Gabaldon', 2),
('The Fault in Our Stars', 'John Green', 2),
('The Time Traveler’s Wife', 'Audrey Niffenegger', 2),
('Twilight', 'Stephenie Meyer', 2),
('The Da Vinci Code', 'Dan Brown', 3),
('Gone Girl', 'Gillian Flynn', 3),
('The Girl with the Dragon Tattoo', 'Stieg Larsson', 3),
('The Silence of the Lambs', 'Thomas Harris', 3),
('Big Little Lies', 'Liane Moriarty', 3),
('The Woman in White', 'Wilkie Collins', 3),
('In the Woods', 'Tana French', 3),
('The Hound of the Baskervilles', 'Arthur Conan Doyle', 3),
('Rebecca', 'Daphne du Maurier', 3),
('Murder on the Orient Express', 'Agatha Christie', 3),
('Harry Potter and the Sorcerer\'s Stone', 'J.K. Rowling', 4),
('The Hobbit', 'J.R.R. Tolkien', 4),
('The Name of the Wind', 'Patrick Rothfuss', 4),
('The Fellowship of the Ring', 'J.R.R. Tolkien', 4),
('A Game of Thrones', 'George R.R. Martin', 4),
('The Way of Kings', 'Brandon Sanderson', 4),
('The Lies of Locke Lamora', 'Scott Lynch', 4),
('Mistborn: The Final Empire', 'Brandon Sanderson', 4),
('American Gods', 'Neil Gaiman', 4),
('The Golden Compass', 'Philip Pullman', 4),
('Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', 5),
('Educated', 'Tara Westover', 5),
('Becoming', 'Michelle Obama', 5),
('The Immortal Life of Henrietta Lacks', 'Rebecca Skloot', 5),
('The Wright Brothers', 'David McCullough', 5),
('Thinking, Fast and Slow', 'Daniel Kahneman', 5),
('Quiet: The Power of Introverts in a World That Can\'t Stop Talking', 'Susan Cain', 5),
('The Tipping Point', 'Malcolm Gladwell', 5),
('Outliers', 'Malcolm Gladwell', 5),
('Into the Wild', 'Jon Krakauer', 5),
('Dune Messiah', 'Frank Herbert', 1),
('The Catcher in the Rye', 'J.D. Salinger', 2),
('The Great Gatsby', 'F. Scott Fitzgerald', 2),
('The Shining', 'Stephen King', 3),
('The Martian', 'Andy Weir', 1),
('Life of Pi', 'Yann Martel', 4),
('Slaughterhouse-Five', 'Kurt Vonnegut', 1),
('The Hunger Games', 'Suzanne Collins', 4),
('To Kill a Mockingbird', 'Harper Lee', 5),
('Catch-22', 'Joseph Heller', 1),
('Frankenstein', 'Mary Shelley', 1);


INSERT INTO posudbe (clanid, knjigaid, datumposudbe, datumpovratka)
VALUES
    (2, 1, '2024-01-05', '2024-01-07'),
    (3, 15, '2024-02-10', '2024-02-15'),
    (5, 20, '2024-03-20', '2024-03-25'),
    (7, 23, '2024-04-12', NULL),
    (9, 33, '2024-05-18', NULL),
	(11, 34,'2024-05-21', NULL);
