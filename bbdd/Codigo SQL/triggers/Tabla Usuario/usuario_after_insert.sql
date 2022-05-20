CREATE TRIGGER `usuario_after_insert` AFTER INSERT ON `usuario` FOR EACH ROW BEGIN

INSERT INTO Acciones VALUES (DEFAULT,'Registrado nuevo usuario.', NOW(), username, NULL);

END