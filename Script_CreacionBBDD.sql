##pregunta1
CREATE DATABASE FICHAR;
CHARACTER SET UTF8;

-- -----------------------------------------------------
-- Table `supermercado`.`ZONA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fichar`.`empleado` (
  `nif` INT NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NOT NULL,
  `administrador` 
  PRIMARY KEY (`nif`));



-- -----------------------------------------------------
-- Table `supermercado`.`REPARTIDOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `supermercado`.`REPARTIDOR` (
  `Matricula` VARCHAR(8) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `CodigoPostal` INT NOT NULL,
  PRIMARY KEY (`Matricula`),
  INDEX `reparte` (`CodigoPostal` ASC),
  CONSTRAINT `reparte`
    FOREIGN KEY (`CodigoPostal`)
    REFERENCES `supermercado`.`ZONA` (`CodigoPostal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
