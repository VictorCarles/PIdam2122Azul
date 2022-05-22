CREATE TRIGGER `producto_before_delete` BEFORE DELETE ON `producto` FOR EACH ROW BEGIN

DECLARE varuser VARCHAR(20);

SET varuser=(SELECT owner_username FROM empresa WHERE cif=product_company);

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company) 
VALUE (DEFAULT,'Usuario '+varuser+' ha eliminado el producto'+product_name+' del catalogo de comercio con cif: '+product_company+'.',
		 NOW(), varuser, product_company);

END