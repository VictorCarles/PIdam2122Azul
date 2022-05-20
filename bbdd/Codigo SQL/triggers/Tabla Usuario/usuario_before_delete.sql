CREATE TRIGGER `usuario_before_delete` BEFORE DELETE ON `usuario` FOR EACH ROW BEGIN

DECLARE varcif VARCHAR(9);
DECLARE iscompany_owner BOOL;
DECLARE acc VARCHAR(600);
-- SET $varcif = NULL;
DECLARE CURSOR1 CURSOR FOR SELECT cif FROM empresa WHERE empresa.owner_username=OLD.username;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET iscompany_owner=1;
-- SET varcif = SELECT cif FROM localmarket_db.empresa WHERE empresa.owner_username=username;

SET iscompany_owner=0;
SET acc='Accion';

OPEN CURSOR1;

fetch CURSOR1 INTO varcif;

if iscompany_owner=1 THEN
	SET acc=OLD.username+' ha eliminado su cuenta de usuario empresario. Su empresa es: '+varcif;
	INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
	VALUE (DEFAULT, acc, NOW(), OLD.username, varcif);
	
END if;

if iscompany_owner=0 THEN
	INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
	VALUE (DEFAULT,OLD.username+' ha eliminado su cuenta de usuario cliente.',
								NOW(), OLD.username, NULL);
END if;
CLOSE CURSOR1;

END