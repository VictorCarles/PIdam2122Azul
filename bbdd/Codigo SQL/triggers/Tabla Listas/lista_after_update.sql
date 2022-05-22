CREATE TRIGGER `listas_after_update` AFTER INSERT ON `listas` FOR EACH ROW BEGIN

BEGIN

DECLARE varcif VARCHAR(9); 
DECLARE acc VARCHAR(300);

SET acc='accion';

SET acc='Usuario '+list_username+' ha actualizado la lista de comercios '+nombre+', list_id: '+list_id+'';
SET varcif=cif_included;

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
VALUES (DEFAULT, acc, NOW(), list_username, varcif);

END