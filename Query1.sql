create database AddressBook

CREATE TABLE address_book (
Id int identity,
firstName varchar(10),
lastName varchar(15),
address varchar(50),
city varchar(15),
state varchar(15),
zip varchar(7),
mobileNo varchar(10),
email varchar(30)
)

SELECT * FROM address_book

------ UC9 ----- Address Book with name and Type
ALTER TABLE address_book ADD type varchar(13),name varchar(10)

UPDATE address_book SET type='Friends' WHERE Id=6

------ UC10 ----- 
SELECT COUNT(type)FROM address_book GROUP BY type

-----UC11 ER Diagram for Address Book

CREATE TABLE AddressBook(
bookID int IDENTITY PRIMARY KEY,
book_Name varchar(20)
)

CREATE TABLE contact_info(
book_Id INT FOREIGN KEY REFERENCES AddressBook(bookID),
contact_Id INT IDENTITY PRIMARY KEY,
firstName VARCHAR(10),
lastName VARCHAR(15),
address VARCHAR(50),
city VARCHAR(15),
state VARCHAR(15),
zip VARCHAR(7),
mobileNo VARCHAR(10),
email VARCHAR(30)
)

CREATE TABLE contact_type(
type_Id INT IDENTITY PRIMARY KEY,
contact_name VARCHAR (20),
)

CREATE TABLE type_handler(
info_Id INT FOREIGN KEY REFERENCES contact_info(contact_Id),
con_type_Id INT FOREIGN KEY REFERENCES contact_type(type_Id),
)
 
INSERT INTO AddressBook(book_Name) VALUES('B')

INSERT INTO contact_info(firstName,lastName,address,city,state,zip,mobileNo,email)VALUES('riya','kumar','m-8955','tarai','up','42259','9864553210','riya45@gmail.com')

INSERT INTO contact_type(contact_name)VALUES('friends'),('family'),('profession')

INSERT INTO type_handler VALUES(1,2),(2,1),(1,3)

SELECT ab.book_Name,ci.firstName,ci.lastName,city FROM AddressBook ab,contact_info ci

FULL JOIN type_handler ON type_handler.info_Id=ci.contact_Id

FULL JOIN AddressBook ON AddressBook.bookID=ci.book_Id
