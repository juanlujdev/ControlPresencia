CREATE DATABASE control_presencia CHARACTER SET UTF8;

CREATE TABLE if not exists empleado(
alta TINYINT(1) NULL,
nif VARCHAR(20) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellidos VARCHAR(50) NOT NULL,
administrador TINYINT(1) NULL,
contraseña VARCHAR(50) NOT NULL,
PRIMARY KEY (nif));

CREATE TABLE if NOT EXISTS fichaje(
nif VARCHAR(20) NOT NULL,
horaEntrada DATETIME NOT NULL,
horaSalida DATETIME NOT NULL,
finalizar TINYINT(1),
PRIMARY KEY (nif));

alter table fichaje ADD CONSTRAINT fk_1 FOREIGN KEY (nif) REFERENCES empleado (nif);

INSERT INTO empleado (`alta`,`nif`,`nombre`,`apellidos`,`administrador`,`contraseña`) VALUES (TRUE,'11111111H','Juan','Marques',TRUE,'1dam');
INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES (TRUE,'22585431y','Antonio','Carmona',FALSE,'xxx');

#Pruebas de consultas
SELECT * FROM empleado WHERE nif = "11111111H" AND alta = true;