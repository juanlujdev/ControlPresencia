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
horaEntrada DATE NOT NULL,
horaSalida DATE NOT NULL,
finalizar TINYINT(1),
PRIMARY KEY (nif));

alter table fichaje ADD CONSTRAINT fk_1 FOREIGN KEY (nif) REFERENCES empleado (nif);
