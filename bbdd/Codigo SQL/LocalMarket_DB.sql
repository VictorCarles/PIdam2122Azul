## BASE DE DATOS Local Market App 
## Inicio código de creación de base de datos 
DROP DATABASE localmarket_db IF EXISTS;

CREATE DATABASE IF NOT EXISTS  localmarket_db CHARACTER SET UTF8;

USE localmarket_db;

## Procedemos a la creación de las tablas de la base de datos:
## Tabla Usuarios:
/*
CREATE TABLE IF NOT EXISTS usuarios(
username VARCHAR(20) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(100) NOT NULL,
informacion_contacto 
*/