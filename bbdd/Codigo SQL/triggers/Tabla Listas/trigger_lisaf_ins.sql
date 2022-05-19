BEGIN
INSERT INTO Acciones VALUES (DEFAULT,Usuario_Username+' ha creado la lista '+Nombre,CURDATE(), Usuario_Username,NULL);
END