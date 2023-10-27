use Mercearia
GO

SET IDENTITY_INSERT Produto ON;

INSERT INTO Produto(id, Nome, Preco, Estoque, CodigoDeBarra)
VALUES(1,'Miojo', 5.00, 1, 1234567890126)
go
INSERT INTO Produto(id, Nome, Preco, Estoque, CodigoDeBarra)
VALUES(2, 'Cerveja', 3.00, 2, 1346669802135)
go
UPDATE Produto SET CodigoDeBarra = 123456789012678 WHERE id = 1
UPDATE Produto SET CodigoDeBarra = 134666980213555 WHERE id = 2
BEGIN TRAN
UPDATE Usuario SET Nome = 'Dagorilina' WHERE id = 2
SELECT *FROM Usuario WHERE Id = 2
UPDATE Usuario SET Nome = 'Genoveva' WHERE id = 2

SELECT *FROM Usuario WHERE Id = 2
ROLLBACK
COMMIT
