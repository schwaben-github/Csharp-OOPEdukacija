-- Matematićke funkcije
-- ABS - vraća apsolutnu vrijednost
SELECT ABS(-1) AS 'Pozitivan broj'
SELECT ABS(0) AS 'Pozitivan broj'
SELECT ABS(11) AS 'Pozitivan broj'

-- CEILING - zaokružuje realan broj na prvi veći cijeli broj
SELECT CEILING(14.1) AS 'Zaokružen broj'

-- FLOOR - zaokružuje realan broj na prvi manji cijeli broj
SELECT FLOOR(14.1) AS 'Zaokružen broj'

-- POWER - vraća broj na neku potenciju
SELECT POWER(2, 3) AS 'Potencija'

-- RAND - po defaultu ispisuje nasumični realan broj između 0 i 1
SELECT RAND() AS 'Slučajan broj'

-- ROUND - zaokružuje neki broj na zadani broj decimalnih mjesta
SELECT ROUND(15.6556, 2)

-- SQUARE - vraća kvarat zadanog broja
SELECT SQUARE(5)

-- SQRT - vraća drugi korjen
SELECT SQRT(144)


-- Funkcije za rad s tekstom
-- LEN - vraća duljinu stringa (bez razmaka na kraju)
SELECT LEN('Tibor  ')

-- UPPER
SELECT UPPER('sve malo')

-- LOWER
SELECT LOWER('SVE VELIkoOOO')

-- LTRIM i RTRIM - reže prazan prostor s lijeve / desne strane
SELECT LTRIM('        -neki tekst-         ')
SELECT RTRIM('        -neki tekst-         ')

-- REVERSE - okreće tekst
SELECT REVERSE('Baze podataka')

-- REPLACE - zamjenjuje u prvom parametru sva pojavljivanja drugog parametra sa trećim
SELECT REPLACE('Danas je lijep dan!', 'Danas', 'Sutra')

-- SUBSTRING - vraća dio stringa počevši od definiranog indeksa
-- prvi parametar je string, drugi indeks početka, a treći duljina
SELECT SUBSTRING('nekidugackistring', 7, 2)

-- CONCAT - konkatenira navedene parametre razdvojene zarezom
SELECT CONCAT('Samo ', 'da ', 'ti ', 'nešto ', 'kažem! ') AS 'Rečenica'