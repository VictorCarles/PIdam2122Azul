CREATE TRIGGER `comentario_after_delete` AFTER DELETE ON `comentario` FOR EACH ROW BEGIN

UPDATE empresa SET avgscore=AVG(score) WHERE cif=OLD.company_page;

END