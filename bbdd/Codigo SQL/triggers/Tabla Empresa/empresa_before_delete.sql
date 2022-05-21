CREATE TRIGGER `empresa_before_delete` BEFORE DELETE ON `empresa` FOR EACH ROW BEGIN

INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company) 
VALUE (DEFAULT,'El usuario '+owner_username+' a eliminado la pagina de comercio "'+company_name+'", con cif: '+cif+'.',
		 NOW(),	owner_username, cif);


END