--MATEMATI�KE FUNKCIJE
-- 1. ABS - vra�a pozitivnu vrijednost danog broja (apsolutnu vrijednost)
SELECT ABS(-5) AS 'Pozitivan broj'
SELECT ABS(0)
SELECT ABS(11)

--2. CEILING - zaukru�uje realan broj na prvi ve�i cijeli broj
SELECT CEILING(14.0000000001)
SELECT CEILING(14.9)

--3. FLOOR - zaokru�uje realan broj na prvi manji cijeli broj
SELECT FLOOR(14.9)

--4. POWER - vra�a broj na neku potenciju
SELECT POWER(3,3)

--5. RAND - po defaultu ispisuje nasumi�ni realan broj izme�u 0 i 1
SELECT RAND()
SELECT RAND(10)

-- 6. ROUND() - zaokru�uje neki broj na zadani broj decimalnih mjesta
SELECT ROUND(15.656, 2)

--7. SQUARE() - vra�a kvadrat danog broja
SELECT SQUARE(5)

--8. SQRT() - vra�a drugi korijen zadanog broja
SELECT SQRT(144)

--FUNKCIJE ZA RAD S TEKSTOM
--1. LEN - vra�a duljinu stringa (bez razmaka na kraju)
SELECT LEN('Igor')
SELECT LEN('Igor       ')

--2. UPPER() - pretvara mala slova u velika
SELECT UPPER('sve malo')

--3. LOWER() - pretvara velika slova u mala
SELECT LOWER('SVE VELIKo')

--4. LTRIM i RTRIM - er�e prazan prostor s lijeve/desne strane
SELECT LTRIM('                -Neki tekst-                 ')
SELECT RTRIM('                -Neki tekst-                 ')

--5. REVERSE() - okre�e tekst
SELECT REVERSE ('Baze podataka')

--6. REPLACE() - zamjenjuje u prvom parametru sva pojavljivanja drugog parametra sa tre�im
SELECT REPLACE('Danas je lijep dan', 'Danas', 'Sutra')


