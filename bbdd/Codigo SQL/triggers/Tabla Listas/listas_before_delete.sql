CREATE TRIGGER `listas_before_delete` BEFORE DELETE ON `listas` FOR EACH ROW BEGIN

DECLARE varcif VARCHAR(9); 
DECLARE acc VARCHAR(300);

SET acc='accion';

SET acc='Usuario '+list_username+' ha eliminado el campo/comercio: '+cif_included+'\n de la lista de comercios '+nombre+', list_id: '+list_id+'';
SET varcif=cif_included;

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
VALUES (DEFAULT, acc, NOW(), list_username, varcif);

END