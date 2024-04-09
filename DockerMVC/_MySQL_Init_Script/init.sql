CREATE DATABASE produtosbd;

USE produtosdb;

DROP TABLE IF EXISTS Produtos;

CREATE TABLE Produtos (
	Id INT AUTO_INCREMENT,
	Nome VARCHAR(30) NOT NULL,
	Categoria VARCHAR(30) NOT NULL,
	Quantidade INT NOT NULL,
	Preco DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (Id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES Produtos WRITE;
INSERT INTO Produtos VALUES(1,"Lápis","Material", 50, "2.0");
INSERT INTO Produtos VALUES(2, "Caderno 55", "Caderno", 30, "25.0");
INSERT INTO Produtos VALUES(3, "Mochila verde", "Mochila", 20, "150.0");
UNLOCK TABLES;
