CREATE TRIGGER `usuario_after_update` AFTER UPDATE ON `usuario` FOR EACH ROW BEGIN

DECLARE varcif VARCHAR(20);
DECLARE acc VARCHAR(600);

SET acc='Accion';
SET varcif=NULL;

SET varcif=(SELECT cif FROM localmarket_db.empresa WHERE owner_username=username);

if (NEW.tipo!=OLD.tipo && NEW.tipo='business') THEN
		SET acc=username+' ha actualizado su cuenta al tipo EMPRESARIO.';
		SET varcif=(SELECT cif FROM localmarket_db.empresa WHERE owner_username=username);
END if;
if (NEW.tipo!=OLD.tipo && NEW.tipo='basic') THEN
		SET acc=username+' ha actualizado su cuenta al tipo BASIC.';
		SET varcif=NULL;
END IF;		

INSERT INTO Acciones (action_id, accion, fecha, user_username, cif_company)
VALUES (DEFAULT, acc, NOW(), username, varcif);

END