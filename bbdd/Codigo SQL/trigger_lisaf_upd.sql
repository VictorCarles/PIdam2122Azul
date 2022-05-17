BEGIN
INSERT INTO Acciones VALUE (DEFAULT,Usuario_Username+' a modificado la lista '+Nombre+'.',CURDATE(),Usuario_Username,NULL);
END