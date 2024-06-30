CREATE DATABASE Inventar;
GO

USE Inventar;
GO

CREATE TABLE Categories (
 CategoryId INT PRIMARY KEY IDENTITY(1,1),
 CategoryName VARCHAR(75) NOT NULL
);

CREATE TABLE Products (
 ProductId INT PRIMARY KEY IDENTITY(1,1),
 ProductName VARCHAR(75) NOT NULL,
 Quantity INT NOT NULL,
 Price DECIMAL(10, 2) NOT NULL,
 CategoryId INT,
 FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);