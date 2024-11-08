CREATE DATABASE SB;
USE SB;
DROP DATABASE SB;

CREATE TABLE Izdavac(
  id INT PRIMARY KEY IDENTITY (1, 1),
  ime NVARCHAR(50) NOT NULL,
  sediste NVARCHAR(50) NOT NULL
);

INSERT INTO Izdavac (ime, sediste) VALUES (N'Дерета', N'Кнез Михаилова 46, Београд'),
(N'Вулкан', N'Господара Вучића 245, Београд'),
(N'Лагуна', N'Ресавска 33, Београд'),
(N'Креативни центар', N'Градиштанска 8, Београд'),
(N'Пчелица', N'Колубарска 4, Чачак');

SELECT *
FROM Izdavac;

CREATE TABLE Korisnik(
  email NVARCHAR(50) PRIMARY KEY,
  lozinka NVARCHAR(30) NOT NULL,
  jmbg CHAR(13) NOT NULL,
  ime NVARCHAR(20) NOT NULL,
  prezime NVARCHAR(50) NOT NULL,  
  uloga INT
);

INSERT INTO Korisnik (email, lozinka, jmbg, ime, prezime, uloga) VALUES (N'stefanovicsalex@SKBibioteka_Z.rs', N'coamafija1312', '2210003710256', N'Александар', N'Стефановић', 2),
(N'stefanovicsalex@SKBibioteka_A.rs', N'coamafija1312', '2210003710256', N'Александар', N'Стефановић', 3),
(N'aleksandargerasimovic@SKBibioteka_A.rs', N'alekgera551', '1502970710742', N'Александар', N'Герасимовић', 3),
(N'jelenanikolic@SKBibioteka_Z.rs', N'jecapereca95', '1707995700111', N'Јелена', N'Николић', 2),
(N'nikolavucic@SKBibioteka_Z.rs', N'dzonidep83', '1704983710932', N'Никола', N'Вучић', 2);

SELECT *
FROM Korisnik;

DELETE FROM Korisnik;

CREATE TABLE Autor(
  id INT PRIMARY KEY IDENTITY (1, 1),
  ime NVARCHAR(20) NOT NULL,
  prezime NVARCHAR(50) NOT NULL  
);

INSERT INTO Autor (ime, prezime) VALUES (N'Иво', N'Андрић'),
(N'Добрица', N'Ерић'),
(N'Фјодор', N'Михајловић Достојевски'),
(N'Добрица', N'Ћосић'),
(N'Милош', N'Црњански'),
(N'Лав', N'Николајевич Толстој'),
(N'Марк', N'Твен'),
(N'Џорџ', N'Орвел'),
(N'Жил', N'Верн'),
(N'Меша', N'Селимовић');

SELECT *
FROM Autor;

CREATE TABLE Knjiga(
  ISBN CHAR(17) PRIMARY KEY,
  naziv NVARCHAR(70) NOT NULL  
);

INSERT INTO Knjiga (ISBN, naziv) VALUES ('978-86-1729-12-17', N'На Дрини Ћуприја'),
('978-86-7401-132-1', N'Ана Карењина'),
('978-86-4130-1-131', N'Рат и мир'),
('978-86-7410-431-1', N'20000 миља под морем'),
('978-86-4710-709-2', N'Вашар у Тополи'),
('978-86-4109-812-5', N'Корени'),
('978-86-0971-8-838', N'Деобе'),
('978-86-0183-99-22', N'Време власти'),
('978-86-0193-092-1', N'Дервиш и смрт'),
('978-86-8536-928-6', N'Животињска фарма');

ALTER TABLE Knjiga
ADD izdavac_id INT FOREIGN KEY REFERENCES Izdavac(id);

ALTER TABLE Knjiga
ADD kolicina INT;

SELECT *
FROM Knjiga;

select *
from pozajmica;

CREATE TABLE Autor_Knjiga(
  id INT PRIMARY KEY IDENTITY (1, 1),
  autor_id INT FOREIGN KEY REFERENCES Autor(id),
  knjiga_ISBN CHAR(17) FOREIGN KEY REFERENCES Knjiga(ISBN)
);

CREATE TABLE Pozajmica(
  id INT PRIMARY KEY IDENTITY (1, 1),
  datum_uzimanja DATE NOT NULL,
  datum_vracanja DATE NOT NULL,
  vraceno CHAR(2) NOT NULL,
  clan_email NVARCHAR(50) FOREIGN KEY REFERENCES Korisnik(email),
  zaposleni_email NVARCHAR(50) FOREIGN KEY REFERENCES Korisnik(email),
  knjiga_ISBN CHAR(17) FOREIGN KEY REFERENCES Knjiga(ISBN)
);

ALTER TABLE Pozajmica
DROP COLUMN vraceno;

ALTER PROCEDURE Pozajmica_Insert
@datum_uzimanja DATE,
@datum_vracanja DATE,
@clan_email NVARCHAR(50),
@zaposleni_email NVARCHAR(50),
@knjiga_ISBN CHAR(17)
AS
BEGIN
  IF ((SELECT Knjiga.kolicina FROM Knjiga WHERE Knjiga.ISBN = @knjiga_ISBN) > 0)
  BEGIN
    IF (EXISTS(SELECT TOP 1 id FROM Pozajmica WHERE clan_email = @clan_email)) RETURN -1;
    BEGIN
    INSERT INTO Pozajmica VALUES (@datum_uzimanja, @datum_vracanja, @clan_email, @zaposleni_email, @knjiga_ISBN);    
    UPDATE Knjiga
    SET kolicina = kolicina - 1
    WHERE Knjiga.ISBN = @knjiga_ISBN;
    RETURN 0;
    END;    
  END;
  RETURN -2;
END;

ALTER PROCEDURE Pozajmica_Delete
@id INT,
@knjiga_ISBN CHAR(17)
AS
BEGIN
  DELETE FROM Pozajmica WHERE id = @id;
  UPDATE Knjiga
  SET kolicina = kolicina + 1
  WHERE ISBN = @knjiga_ISBN;
END;