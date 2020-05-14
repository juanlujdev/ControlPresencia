CREATE TABLE if not exists empleado(
alta TINYINT(1) NULL,
nif VARCHAR(20) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellidos VARCHAR(50) NOT NULL,
administrador TINYINT(1) NULL,
contraseña VARCHAR(50) NULL,
PRIMARY KEY (nif));

CREATE TABLE if NOT EXISTS fichaje(
nif VARCHAR(20) not NULL,
horaEntrada DATETIME NOT NULL,
horaSalida DATETIME NOT NULL,
finalizar TINYINT(1));

alter table fichaje ADD CONSTRAINT fk_1 FOREIGN KEY (nif) REFERENCES empleado (nif) ON DELETE cascade;

INSERT INTO empleado (`alta`,`nif`,`nombre`,`apellidos`,`administrador`,`contraseña`) VALUES (TRUE,'11111111H','Juan','Marques',TRUE,'1dam');
