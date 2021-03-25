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