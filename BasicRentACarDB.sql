CREATE TABLE Brands(
Id int PRIMARY KEY IDENTITY(1,1),
Name varchar(25) NOT NULL
)

CREATE TABLE Colors (
Id int PRIMARY KEY IDENTITY(1,1),
Name varchar(25) NOT NULL
)

CREATE TABLE Cars (
Id int PRIMARY KEY IDENTITY(1,1),
BrandId int NOT NULL FOREIGN KEY REFERENCES Brands(Id),
ColorId int NOT NULL FOREIGN KEY REFERENCES Colors(Id),
Model varchar(50) NOT NULL,
ModelYear int NOT NULL,
DailyPrice decimal NOT NULL,
Description varchar(250))

CREATE TABLE Users (
Id int PRIMARY KEY IDENTITY(1,1),
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Email varchar(100) NOT NULL,
Password varchar(100) NOT NULL
)

CREATE TABLE Customers (
Id int PRIMARY KEY IDENTITY(1,1),
UserId int FOREIGN KEY REFERENCES Users(Id),
CompanyName varchar(100)
)

CREATE TABLE Rentals (
Id int PRIMARY KEY IDENTITY(1,1),
CarId int FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
CustomerId int FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
RentDate date,
ReturnDate date
)

INSERT INTO Brands (Name) VALUES ('Vw'),('Ford'),('DS')
INSERT INTO Colors (Name) VALUES ('Black'),('White'),('Blue')
INSERT INTO Cars (BrandId, ColorId,Model, ModelYear,DailyPrice,Description) VALUES (1,3,'Golf VII',2015,220,'Diesel A/T'),
(2,1,'Focus',2020,280,'Gasoline M/T')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Kadir','Sarıaslan','kadir@sariaslan.net','12345')
INSERT INTO Customers (UserId,CompanyName) VALUES (1,'Sarıaslan Net')