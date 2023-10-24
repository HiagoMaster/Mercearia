use Mercearia
go

DECLARE @id INT
DECLARE @Nome VARCHAR(150)
DECLARE @NomeUsuario VARCHAR(150)
DECLARE @Senha VARCHAR(50)
DECLARE @Ativo BIT

SET @id = 1
SET @Nome = 'Erisvaldo'
SET @NomeUsuario = 'Teste'
SET @Senha = '123'
SET @Ativo = 1




INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)
VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)

SELECT *FROM Usuario

UPDATE Usuario SET
Nome = @Nome,
NomeUsuario = @NomeUsuario,
Senha = @Senha,
Ativo = @Ativo
WHERE id = 1

DELETE FROM Usuario WHERE id = 1








