CREATE TRIGGER `producto_after_insert` AFTER INSERT ON `producto` FOR EACH ROW BEGIN

DECLARE varuser VARCHAR(20);

SET varuser=(SELECT owner_username FROM empresa WHERE cif=product_company);

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company) 
VALUES (DEFAULT, 'El producto: '+product_name+' ha sido añadido al catalogo de comercio con cif: '+product_company+'.',
		  NOW(), varuser, product_company);

END