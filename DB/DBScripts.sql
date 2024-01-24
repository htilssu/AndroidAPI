IF NOT EXISTS (SELECT 1
               FROM sys.databases
               WHERE name = 'ShoppingTraining')
CREATE DATABASE ShoppingTraining;

USE ShoppingTraining;

CREATE TABLE AdminUser
(
    UserName VARCHAR(24) NOT NULL PRIMARY KEY,
    Password VARCHAR(64) NOT NULL,
)

CREATE TABLE Category
(
    Id           INT          NOT NULL PRIMARY KEY IDENTITY (1,1),
    CategoryName NVARCHAR(25) NOT NULL,
)

CREATE TABLE Product
(
    Id          INT            NOT NULL PRIMARY KEY IDENTITY (1,1),
    ProductName NVARCHAR(40)   NOT NULL,
    Price       DECIMAL(18, 2) NOT NULL,
    CategoryId  INT            NOT NULL FOREIGN KEY REFERENCES Category (Id),
    Quantity    INT            NOT NULL,
    Description NVARCHAR(1000) NOT NULL,
    ImageUrl    NVARCHAR(1000) NOT NULL,
)

CREATE TABLE Customer
(
    UserName    VARCHAR(24)  NOT NULL PRIMARY KEY,
    Password    VARCHAR(64)  NOT NULL,
    FirstName   NVARCHAR(25)  NOT NULL,
    LastName    NVARCHAR(25)  NOT NULL,
    Email       VARCHAR(50)   NOT NULL,
    PhoneNumber CHAR(10)      NOT NULL,
    Address     NVARCHAR(100) NOT NULL,
    BirthDate   DATE          NOT NULL,
--     City        NVARCHAR(25)  NOT NULL,
--     State       NVARCHAR(25)  NOT NULL,
--     ZipCode     NVARCHAR(10)  NOT NULL,
)


CREATE TABLE Invoice
(
    Id         INT            NOT NULL PRIMARY KEY IDENTITY (1,1),
    Customer VARCHAR(24)   NOT NULL FOREIGN KEY REFERENCES Customer (UserName),
    OrderDate  DATE           NOT NULL,
    TotalPrice DECIMAL(18, 2) NOT NULL,
)

CREATE TABLE InvoiceItem
(
    InvoiceId INT            NOT NULL FOREIGN KEY REFERENCES Invoice (Id),
    ProductId INT            NOT NULL FOREIGN KEY REFERENCES Product (Id),
    Quantity  INT            NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY (InvoiceId, ProductId),
)