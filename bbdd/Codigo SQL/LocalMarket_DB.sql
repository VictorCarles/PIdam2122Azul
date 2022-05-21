## BASE DE DATOS Local Market App 
## Inicio código de creación de base de datos
## Version: 2.0
 
-- DROP DATABASE IF EXISTS localmarket_db;

CREATE DATABASE IF NOT EXISTS  localmarket_db CHARACTER SET UTF8;

USE localmarket_db;

## Procedemos a la creación de las tablas de la base de datos:

## Tabla Usuarios:
CREATE TABLE IF NOT EXISTS localmarket_db.Usuario(
  `username` VARCHAR(20) NOT NULL,
  `fullname` VARCHAR(45) NOT NULL,
  `surnames` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `telephone` INT(11) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `profilePicture` LONGBLOB NULL,
  `address` VARCHAR(45) NOT NULL,
  `cp` INT NOT NULL,
  `tipo` VARCHAR(20) NOT NULL,
  `DNI` VARCHAR(9) NULL,
  PRIMARY KEY (username));
-- DROP TABLE IF EXISTS localmarket_db.Usuario;


## Tabla Empresa:
CREATE TABLE IF NOT EXISTS localmarket_db.Empresa(
  `cif` VARCHAR(9) NOT NULL,
  `company_name` VARCHAR(45) NOT NULL,
  `category` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `telephone` INT(11) NOT NULL,
  `avgscore` DOUBLE NOT NULL,
  `pPicture` LONGBLOB NULL,
  `address` VARCHAR(45) NOT NULL,
  `cp` INT NOT NULL,
  `description` VARCHAR(600) NOT NULL,
  `owner_username` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`cif`),
  INDEX `fk_owner_username_idx` (`owner_username` ASC),
  CONSTRAINT `fk_owner_username`
    FOREIGN KEY (owner_username)
    REFERENCES localmarket_db.Usuario (`username`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE);
-- DROP TABLE IF EXISTS localmarket_db.Empresa;
 -- UNIQUE INDEX `owner_username_UNIQUE` (`owner_username` ASC)
 

## Tabla Acciones:
CREATE TABLE IF NOT EXISTS localmarket_db.Acciones (
--  `action_id` INT NOT NULL AUTO_INCREMENT,
  `action_id` INT NOT NULL AUTO_INCREMENT,
  `accion` VARCHAR(600) NOT NULL,
  `fecha` DATETIME NOT NULL,
  `user_username` VARCHAR(20) NOT NULL,
  `cif_company` VARCHAR(9) NULL,
  PRIMARY KEY (`action_id`),
  INDEX `fk_user_username_idx` (`user_username` ASC),
  CONSTRAINT `fk_user_username`
    FOREIGN KEY (user_username)
    REFERENCES localmarket_db.Usuario (username)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cif_company`
    FOREIGN KEY (cif_company)
    REFERENCES localmarket_db.Empresa (cif)
    ON DELETE NO ACTION
    ON UPDATE CASCADE);
    
-- DROP TABLE IF EXISTS localmarket_db.Acciones;



## Tabla Listas:
CREATE TABLE IF NOT EXISTS localmarket_db.Listas (
  `idListas` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `username` VARCHAR(20) NOT NULL,
  `cif_included` VARCHAR(9) NOT NULL,
  PRIMARY KEY (`idListas`),
  INDEX `fk_username_idx` (`username` ASC),
  CONSTRAINT `fk_username`
    FOREIGN KEY (`username`)
    REFERENCES localmarket_db.Usuario (`username`)
	 ON DELETE CASCADE
    ON UPDATE CASCADE,
	CONSTRAINT `fk_cif_included`
    FOREIGN KEY (`cif_included`)
    REFERENCES localmarket_db.Empresa (cif)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
-- DROP TABLE IF EXISTS localmarket_db.Listas;


## Tabla Images:
CREATE TABLE IF NOT EXISTS localmarket_db.Images (
  `idImages` INT NOT NULL AUTO_INCREMENT,
  `company_profile` VARCHAR(9) NOT NULL,
   `img` LONGBLOB NOT NULL,
  PRIMARY KEY (`idImages`),
  INDEX `fk_company_profile_idx` (`company_profile` ASC),
  CONSTRAINT `fk_company_profile`
    FOREIGN KEY (`company_profile`)
    REFERENCES localmarket_db.Empresa (`cif`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
-- DROP TABLE IF EXISTS localmarket_db.Images;


## Tabla Producto:
CREATE TABLE IF NOT EXISTS localmarket_db.Producto (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `category` VARCHAR(45) NOT NULL,
  `price` DOUBLE NOT NULL,
  `prod_name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NOT NULL,
  `image` LONGBLOB NULL,
  `available` TINYINT(1) NOT NULL,
  `product_company` VARCHAR(9) NOT NULL,
  PRIMARY KEY (`idProducto`),
  INDEX `fk_product_company_idx` (`product_company` ASC),
  CONSTRAINT `fk_product_company`
    FOREIGN KEY (`product_company`)
    REFERENCES `localmarket_db`.`Empresa` (`cif`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
-- DROP TABLE IF EXISTS localmarket_db.Producto;


## Tabla Comentario:
CREATE TABLE IF NOT EXISTS localmarket_db.Comentario (
  `idComentario` INT NOT NULL AUTO_INCREMENT,
   text_contents VARCHAR(500) NOT NULL,
  `score` INT NOT NULL,
  `company_page` VARCHAR(9) NOT NULL,
  `comment_username` VARCHAR(20) NOT NULL,
  `id_respuesta` INT NULL,
  `useful_rating` INT NOT NULL,
  `publication_date` DATETIME NOT NULL,
  PRIMARY KEY (`idComentario`),
  INDEX `fk_company_page_idx` (`company_page` ASC),
  INDEX `fk_comment_username_idx` (`comment_username` ASC),
  INDEX `fk_id_respuesta_idx` (`id_respuesta` ASC),
  CONSTRAINT `fk_company_page`
    FOREIGN KEY (`company_page`)
    REFERENCES localmarket_db.Empresa (`cif`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE,
  CONSTRAINT `fk_comment_username`
    FOREIGN KEY (`comment_username`)
    REFERENCES localmarket_db.Usuario (username)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_id_respuesta`
    FOREIGN KEY (`id_respuesta`)
    REFERENCES localmarket_db.Comentario (`idComentario`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
-- DROP TABLE IF EXISTS localmarket_db.Comentario;


## Tabla Versiones:

CREATE TABLE IF NOT EXISTS localmarket_db.Versions (
  `num_version` VARCHAR(10) NOT NULL,
  `dev_notes` VARCHAR(500) NOT NULL,
  `appfiles` LONGBLOB NOT NULL,
  PRIMARY KEY (`num_version`));
-- DROP TABLE IF EXISTS localmarket_db.Versions;