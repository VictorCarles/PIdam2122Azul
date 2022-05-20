CREATE TRIGGER `usuario_before_update` BEFORE UPDATE ON `usuario` FOR EACH ROW BEGIN

INSERT INTO Acciones VALUES (DEFAULT, username+' a actualizado su perfil.', NOW(), username, NULL);

END