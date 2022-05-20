CREATE TRIGGER `comentario_before_delete` BEFORE DELETE ON `comentario` FOR EACH ROW BEGIN

INSERT INTO acciones 
VALUE (DEFAULT,'Eliminado comentario. \n Publicado el: '+publication_date+' \n Contents: '+text_contents+'',
		NOW(), comment_username,company_page);


END