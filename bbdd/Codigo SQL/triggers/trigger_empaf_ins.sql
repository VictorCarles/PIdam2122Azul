BEGIN
INSERT INTO Acciones VALUES (DEFAULT,Usuario_Username+' ha registrado '+cifEmp,CURDATE(), Usuario_Username,cifEmp);
END