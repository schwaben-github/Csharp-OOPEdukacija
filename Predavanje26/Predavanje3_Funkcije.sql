--MATEMATIÈKE FUNKCIJE
-- 1. ABS - vraæa pozitivnu vrijednost danog broja (apsolutnu vrijednost)
SELECT ABS(-5) AS 'Pozitivan broj'
SELECT ABS(0)
SELECT ABS(11)

--2. CEILING - zaukružuje realan broj na prvi veæi cijeli broj
SELECT CEILING(14.0000000001)
SELECT CEILING(14.9)

--3. FLOOR - zaokružuje realan broj na prvi manji cijeli broj
SELECT FLOOR(14.9)

--4. POWER - vraæa broj na neku potenciju
SELECT POWER(3,3)

--5. RAND - po defaultu ispisuje nasumièni realan broj izmeðu 0 i 1
SELECT RAND()
SELECT RAND(10)

-- 6. ROUND() - zaokružuje neki broj na zadani broj decimalnih mjesta
SELECT ROUND(15.656, 2)

--7. SQUARE() - vraæa kvadrat danog broja
SELECT SQUARE(5)

--8. SQRT() - vraæa drugi korijen zadanog broja
SELECT SQRT(144)

--FUNKCIJE ZA RAD S TEKSTOM
--1. LEN - vraæa duljinu stringa (bez razmaka na kraju)
SELECT LEN('Igor')
SELECT LEN('Igor       ')

--2. UPPER() - pretvara mala slova u velika
SELECT UPPER('sve malo')

--3. LOWER() - pretvara velika slova u mala
SELECT LOWER('SVE VELIKo')

--4. LTRIM i RTRIM - erže prazan prostor s lijeve/desne strane
SELECT LTRIM('                -Neki tekst-                 ')
SELECT RTRIM('                -Neki tekst-                 ')

--5. REVERSE() - okreæe tekst
SELECT REVERSE ('Baze podataka')

--6. REPLACE() - zamjenjuje u prvom parametru sva pojavljivanja drugog parametra sa treæim
SELECT REPLACE('Danas je lijep dan', 'Danas', 'Sutra')


