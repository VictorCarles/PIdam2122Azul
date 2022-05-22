CREATE TRIGGER `empresa_after_update` AFTER UPDATE ON `empresa` FOR EACH ROW BEGIN


INSERT INTO localmarket_db.acciones(action_id, accion, fecha, user_username, cif_company)
VALUES (DEFAULT, NEW.owner_username+' ha actualizado la información de la pagina del comercio con cif: '+NEW.cif, NOW(), NEW.owner_username, NEW.cif);

END