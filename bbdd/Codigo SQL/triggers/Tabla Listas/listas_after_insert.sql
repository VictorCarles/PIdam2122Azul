CREATE TRIGGER `listas_after_insert` AFTER INSERT ON `listas` FOR EACH ROW BEGIN

DECLARE nombre_new_list VARCHAR(50);
DECLARE username_new_list VARCHAR(20);

DECLARE numlista INT;
DECLARE varcif VARCHAR(9); 
DECLARE acc VARCHAR(300);

SET nombre_new_list = NEW.nombre;
SET username_new_list=NEW.list_username;
SET numlista=0; SET acc='accion';

SET numlista=(SELECT COUNT(list_id) FROM listas WHERE nombre=nombre_new_list AND list_username=username_new_list);

if numlista=1 THEN
		SET acc=list_username+' ha creado la lista de comercios: '+nombre_new_list;
		SET varcif=NULL;
END if;
	
if numlista>1 THEN
		SET acc='Usuario '+list_username+' ha añadido el comercio  con cif:'+cif_included+', a la lista: '+nombre+', list_id: '+list_id+'';
		SET varcif=cif_included;
END if;

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
		VALUES (DEFAULT, acc, NOW(), list_username, varcif);

END