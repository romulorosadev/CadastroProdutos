CREATE DATABASE dbProduct;
USE dbProduct;

CREATE TABLE dbProduct (
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(250) NOT NULL,
    fabricante VARCHAR(250) NOT NULL,
    preco DOUBLE
);