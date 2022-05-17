BEGIN

INSERT INTO Acciones VALUE (DEFAULT,Usuario_Username+' a añadido un comentario',CURDATE(),Usuario_Username,null);
UPDATE Empresa SET avgScore=AVG(score);

END