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
