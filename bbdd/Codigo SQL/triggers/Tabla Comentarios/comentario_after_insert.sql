CREATE TRIGGER `comentario_after_insert` AFTER INSERT ON `comentario` FOR EACH ROW BEGIN

INSERT INTO acciones (action_id, accion, fecha, user_username, cif_company) VALUE 
(idComentario, 'Publicado nueva reseña', publication_date, comment_username, company_page);
	

END