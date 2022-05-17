BEGIN
INSERT INTO Acciones VALUES (DEFAULT,Usuario_Username+' ha registrado '+emp_name,CURDATE(), Usuario_Username,emp_name);
END