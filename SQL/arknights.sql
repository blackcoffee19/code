CREATE TABLE operator (
    id PRIMARY KEY,
    Oname UNIQUE,
    gender TEXT
);
INSERT INTO operator (id, Oname, gender)
VALUES (1, 'Lappland', 'Female');

INSERT INTO operator (id, Oname, gender)
VALUES (2, 'Texas', 'Female');

SELECT * FROM operator;

ALTER TABLE operator
ADD COLUMN Ostatus TEXT DEFAULT 'non-date';

UPDATE operator
SET Ostatus = 'date'
WHERE id=1;
UPDATE operator
SET Ostatus = 'date'
WHERE id=2;

INSERT INTO operator (id, Oname, gender, Ostatus) 
VALUES (3, 'silver as', 'male', 'non-date');
INSERT INTO operator (id, Oname, gender, Ostatus) 
VALUES (4, 'F12', 'male', 'non-date');

DELETE FROM operator
WHERE gender='male';