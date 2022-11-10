IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] (Nome, Sobrenome)
	VALUES ('Diogo', 'Miranda'),
	('Bruna', 'Coutinho'),
	('Carol','Miranda'),
	('Eduardo','Di Biase')
END