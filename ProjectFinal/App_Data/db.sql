use master
go

create database db_examenweb
go

use db_examenweb
go


IF (OBJECT_ID('Utilisateur') IS NULL)
BEGIN
	CREATE TABLE Utilisateur
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		LoginUtil NVARCHAR(99) NOT NULL UNIQUE,
		[Mot de passe] NVARCHAR(99) NOT NULL
	)
END
ELSE
	PRINT 'la table Utilisateur deja exists'
GO


IF (OBJECT_ID('Pylone') IS NULL)
BEGIN
	CREATE TABLE Pylone
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		number NVARCHAR(20) NOT NULL,
		line INT NOT NULL,
		city NVARCHAR(99) NOT NULL,
		latitude FLOAT NOT NULL,
		longitude FLOAT NOT NULL,
		degradation NVARCHAR(99) NOT NULL
	)
END
ELSE
	PRINT 'la table Pylone existe déjà'
GO


IF (OBJECT_ID('Worker') IS NULL)
BEGIN
	CREATE TABLE Worker
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		cin NVARCHAR(20) NOT NULL,
		full_name NVARCHAR(20) NOT NULL,
		city NVARCHAR(99) NOT NULL,
		phone NVARCHAR(20) NOT NULL,
		birth_date DATE,
		start_date DATE,
		job_title NVARCHAR(99) NOT NULL
	)
END
ELSE
	PRINT 'la table Worker existe déjà'
GO


IF (OBJECT_ID('Work') IS NULL)
BEGIN
	CREATE TABLE Work
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		worker_id INT NOT NULL REFERENCES Worker(Id) ON DELETE CASCADE ON UPDATE CASCADE,
		pylone_id INT NOT NULL REFERENCES Pylone(Id) ON DELETE CASCADE ON UPDATE CASCADE,
		work_date DATE,
		progress FLOAT NOT NULL,
		payment FLOAT NOT NULL
	)
END
ELSE
	PRINT 'la table Work existe déjà'
GO


IF (OBJECT_ID('Vehicle') IS NULL)
BEGIN
	CREATE TABLE Vehicle
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		license_plate NVARCHAR(99) NOT NULL,
		model NVARCHAR(99) NOT NULL,
		fuel_type NVARCHAR(99) NOT NULL,
		initial_mileage FLOAT NOT NULL
	)
END
ELSE
	PRINT 'la table Vehicle existe déjà'
GO


IF (OBJECT_ID('FuelConsumption') IS NULL)
BEGIN
	CREATE TABLE FuelConsumption
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		vehicle_id INT NOT NULL REFERENCES Vehicle(Id) ON DELETE CASCADE ON UPDATE CASCADE,
		volume FLOAT NOT NULL,
		price FLOAT NOT NULL,
		date_consoommation DATE,
		mileage FLOAT NOT NULL
	)
END
ELSE
	PRINT 'la table FuelConsumption existe déjà'
GO


IF (OBJECT_ID('Rest') IS NULL)
BEGIN
	CREATE TABLE Rest
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		worker_id INT NOT NULL REFERENCES Worker(Id) ON DELETE CASCADE ON UPDATE CASCADE,
		date_rest DATE,
		description NVARCHAR(99)
	)
END
ELSE
	PRINT 'la table Rest existe déjà'
GO

insert into Work (worker_id, pylone_id, work_date, progress, payment) values (1, 2,	'2023-05-06', 0.5, 1000.0)

select * from Pylone
select * from Worker
select * from Work
select * from Vehicle
select * from Utilisateur
select * from FuelConsumption
select * from Rest