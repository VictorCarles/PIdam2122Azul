CREATE TRIGGER `usuario_after_insert` AFTER INSERT ON `usuario` FOR EACH ROW BEGIN

INSERT INTO localmarket_db.Acciones (action_id, accion, fecha, user_username, cif_company) 
VALUES (DEFAULT,'Registrado nuevo usuario: '+tipo+'', NOW(), username, NULL);

END