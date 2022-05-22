CREATE TRIGGER `usuario_before_delete` BEFORE DELETE ON `usuario` FOR EACH ROW BEGIN

DECLARE varcif VARCHAR(20);
DECLARE acc VARCHAR(600);
DECLARE pastacc INT;
SET acc='Accion';

if (OLD.tipo='basic') THEN
		SET acc=username+' ha eliminado su cuenta de usuario cliente.';
		SET varcif=NULL;
END if;

if (OLD.tipo='business') THEN
		SET varcif=(SELECT cif FROM empresa WHERE owner_username=username);
		SET acc=username+' ha eliminado su cuenta de usuario empresario. Su empresa es: '+varcif;
END IF;

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
VALUE (DEFAULT, acc, NOW(), username, varcif);

SET pastacc=(SELECT action_id FROM localmarket_db.acciones WHERE user_username=username);
UPDATE acciones SET accion=(SELECT CONCAT(accion,' : (DELETED USER. log code: ',action_id,')')) WHERE action_id=pastacc;


END