BEGIN
INSERT INTO Acciones VALUE (DEFAULT,Usuario_Username+' a borrado la lista '+Nombre+'.',CURDATE(),Usuario_Username,NULL);
END