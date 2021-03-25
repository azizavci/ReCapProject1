CREATE DATABASE ReCapProject

CREATE TABLE Brands(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	BRANDNAME varchar(50)

);

CREATE TABLE Colors(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	COLORNAME varchar(50)

);

CREATE TABLE Cars(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	BRANDID int,
	COLORID int,
	MODELYEAR int,
	DAILYPRICE int,
	INFORMATION varchar(50),

	FOREIGN KEY(BRANDID) REFERENCES Brands(Id),
	FOREIGN KEY(COLORID) REFERENCES Colors(Id)
);

CREATE TABLE Users(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	FIRSTNAME varchar(50),
	LASTNAME varchar(50),
	EMAIL varchar(100),
	USERPASSWORD varchar(50)

);

CREATE TABLE Customers(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	USERID int,
	COMPANYNAME varchar(50)

);

CREATE TABLE Rentals(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	BRANDID int,
	CUSTOMERID int,
	RENTALDATE datetime,
	RETURNDATE datetime
	

	FOREIGN KEY(BRANDID) REFERENCES Brands(ID),
	FOREIGN KEY(CUSTOMERID) REFERENCES Colors(ID)
);