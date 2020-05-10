CREATE DATABASE control_presencia CHARACTER SET UTF8;

CREATE TABLE if not exists empleado(
alta TINYINT(1) NULL,
nif VARCHAR(20) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellidos VARCHAR(50) NOT NULL,
administrador TINYINT(1) NULL,
contraseña VARCHAR(50) NULL,
PRIMARY KEY (nif));

CREATE TABLE if NOT EXISTS fichaje(
nif VARCHAR(20) NOT NULL,
horaEntrada DATETIME NOT NULL,
horaSalida DATETIME NOT NULL,
finalizar TINYINT(1));
##Se elimina la primary key , para poder repetir el nif. (Se podria añadir una primary autoincrement  si fuera necesario)

alter table fichaje ADD CONSTRAINT fk_1 FOREIGN KEY (nif) REFERENCES empleado (nif);
INSERT INTO empleado (`alta`,`nif`,`nombre`,`apellidos`,`administrador`,`contraseña`) VALUES (TRUE,'11111111H','Juan','Marques',TRUE,'1dam');
INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES (TRUE,'22585431y','Antonio','Carmona',FALSE,NULL);
INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES (TRUE,'22585111y','Carlos','Aparicio',FALSE,NULL);
INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES (TRUE,'33563572V','Jose','Romero',FALSE,null);
INSERT INTO fichaje (nif,horaEntrada,horaSalida,finalizar) VALUE ('22585431y','2020-10-05 08:00:00','0000-00-00 00:00:00',false);
INSERT INTO fichaje (nif,horaEntrada,horaSalida,finalizar) VALUE ('22585111y','2020-10-05 08:00:00','2020-10-05 13:00:00',FALSE);


#Pruebas de consultas
SELECT * FROM empleado WHERE nif = "11111111H" AND alta = TRUE;
SELECT nombre, apellidos,horaEntrada FROM empleado INNER JOIN fichaje ON empleado.nif=fichaje.nif WHERE finalizar=FALSE;
UPDATE fichaje SET horaSalida = '2020-10-05 13:00:00', finalizar = TRUE WHERE nif = '22585111y'; 
SELECT * FROM fichaje WHERE nif = '33563572V' AND finalizar = FALSE;
SELECT * FROM fichaje WHERE nif = '33563572V' AND finalizar = TRUE;
SELECT COUNT(*) FROM fichaje WHERE nif = '33563572V'; 

SELECT horaEntrada, horaSalida,   horaSalida - horaEntrada AS duracion FROM fichaje WHERE finalizar=TRUE AND nif ="22585111y";
SELECT horaEntrada, horaSalida, DATEDIFF ( horaEntrada, horaSalida) AS duracion FROM fichaje WHERE finalizar=TRUE AND nif ="22585111y";
SELECT horaEntrada, horaSalida, TIMESTAMPDIFF (MINUTE,horaEntrada,horaSalida) AS Duracion_Minutos from fichaje WHERE finalizar=TRUE AND nif ="22585111y";