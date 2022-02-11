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
