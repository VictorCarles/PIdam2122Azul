## BASE DE DATOS Local Market App 
## Inicio código de creación de base de datos
## Version: 1.1

DROP DATABASE localmarket_db;

CREATE DATABASE IF NOT EXISTS  localmarket_db CHARACTER SET UTF8;

USE localmarket_db;

## Procedemos a la creación de las tablas de la base de datos:
## Tabla Usuarios:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Usuario` (
  `Username` VARCHAR(20) NOT NULL,
  `fullname` VARCHAR(45) NOT NULL,
  `surnames` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `telephone` INT(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `profilePicture` BLOB,
  `Address` VARCHAR(45) NOT NULL,
  `CP` INT NOT NULL,
  `type` VARCHAR(20) NOT NULL,
  `CIF` VARCHAR(9) NULL,
  `DNI` VARCHAR(9) NULL,
  `Clave` INT(4) NULL,
  PRIMARY KEY (`Username`),
  UNIQUE INDEX `Username_UNIQUE` (`Username` ASC) VISIBLE)
ENGINE = InnoDB;

## Tabla Acciones:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Acciones` (
  `idAcciones` INT NOT NULL AUTO_INCREMENT,
  `accion` VARCHAR(300) NOT NULL,
  `fecha` DATETIME NOT NULL,
  `Usuario_Username` VARCHAR(20),
  `Empresa_Username` VARCHAR(20),
  PRIMARY KEY (`idAcciones`),
  INDEX `fk_Acciones_Usuario_idx` (`Usuario_Username` ASC) VISIBLE,
  CONSTRAINT `fk_Acciones_Usuario`
    FOREIGN KEY (`Usuario_Username`)
    REFERENCES `localmarket_db`.`Usuario` (`Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

## Tabla Listas:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Listas` (
  `idListas` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Usuario_Username` VARCHAR(20) NOT NULL,
  `idEmpresa` INT NOT NULL,
  PRIMARY KEY (`idListas`),
  INDEX `fk_Listas_Usuario1_idx` (`Usuario_Username` ASC) VISIBLE,
  CONSTRAINT `fk_Listas_Usuario1`
    FOREIGN KEY (`Usuario_Username`)
    REFERENCES `localmarket_db`.`Usuario` (`Username`)
    FOREIGN KEY (`idEmpresa`)
    REFERENCES `localmarket_db`.`Empresa` (`idEmpresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

## Tabla Empresa:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Empresa` (
  `idEmpresa` INT NOT NULL AUTO_INCREMENT,
  `emp_name` VARCHAR(45) NOT NULL,
  `category` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `telephone` INT(11) NOT NULL,
  `avgScore` DOUBLE NOT NULL,
  `pPicture` LONGBLOB NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `cp` INT NOT NULL,
  `description` VARCHAR(600) NOT NULL,
  `Usuario_Username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`idEmpresa`),
  INDEX `fk_Empresa_Usuario1_idx` (`Usuario_Username` ASC) VISIBLE,
  CONSTRAINT `fk_Empresa_Usuario1`
    FOREIGN KEY (`Usuario_Username`)
    REFERENCES `localmarket_db`.`Usuario` (`Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

## Tabla Images:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Images` (
  `idImages` INT NOT NULL AUTO_INCREMENT,
  `Empresa_idEmpresa` INT NOT NULL,
   `img` LONGBLOB NOT NULL,
  PRIMARY KEY (`idImages`),
  INDEX `fk_Images_Empresa1_idx` (`Empresa_idEmpresa` ASC) VISIBLE,
  CONSTRAINT `fk_Images_Empresa1`
    FOREIGN KEY (`Empresa_idEmpresa`)
    REFERENCES `localmarket_db`.`Empresa` (`idEmpresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

## Tabla Producto:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Producto` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `category` VARCHAR(45) NOT NULL,
  `price` DOUBLE NOT NULL,
  `prod_name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NOT NULL,
  `image` LONGBLOB NOT NULL,
  `avaiable` TINYINT(1) NOT NULL,
  `Empresa_idEmpresa` INT NOT NULL,
  PRIMARY KEY (`idProducto`),
  INDEX `fk_Producto_Empresa1_idx` (`Empresa_idEmpresa` ASC) VISIBLE,
  CONSTRAINT `fk_Producto_Empresa1`
    FOREIGN KEY (`Empresa_idEmpresa`)
    REFERENCES `localmarket_db`.`Empresa` (`idEmpresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

## Tabla Comentario:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Comentario` (
  `idComentario` INT NOT NULL AUTO_INCREMENT,
  `text` VARCHAR(45) NOT NULL,
  `score` INT NOT NULL,
  `Empresa_idEmpresa` INT NOT NULL,
  `Usuario_Username` VARCHAR(20) NOT NULL,
  `idRespuesta_Comentario` INT NULL,
  `usefulPoints` INT NOT NULL,
  `PubCom` DATETIME NOT NULL,
  PRIMARY KEY (`idComentario`),
  INDEX `fk_Comentario_Empresa1_idx` (`Empresa_idEmpresa` ASC) VISIBLE,
  INDEX `fk_Comentario_Usuario1_idx` (`Usuario_Username` ASC) VISIBLE,
  INDEX `fk_idRespuesta_Comentario1_idx` (`idRespuesta_Comentario` ASC) VISIBLE,
  CONSTRAINT `fk_Comentario_Empresa1`
    FOREIGN KEY (`Empresa_idEmpresa`)
    REFERENCES `localmarket_db`.`Empresa` (`idEmpresa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Comentario_Usuario1`
    FOREIGN KEY (`Usuario_Username`)
    REFERENCES `localmarket_db`.`Usuario` (`Username`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_idRespuesta_Comentario1`
    FOREIGN KEY (`idRespuesta_Comentario`)
    REFERENCES `localmarket_db`.`Comentario` (`idComentario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

## Tabla Versiones:

CREATE TABLE IF NOT EXISTS `localmarket_db`.`Version` (
  `numVersion` VARCHAR(10) NOT NULL,
  `text` VARCHAR(500) NOT NULL,
  `app` LONGBLOB NOT NULL,
  PRIMARY KEY (`numVersion`))
ENGINE = INNODB;