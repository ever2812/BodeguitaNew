USE bodeguita;

--PROCEDIMIENTO LISTAR CATEGORIA
DELIMITER //
CREATE PROCEDURE categoria_listar()
BEGIN
	SELECT idcategoria,nombre,descripcion,estado FROM categoria ORDER BY idcategoria;
END
//

--PROCEDIMIENTO BUSCAR CATEGORIA
use bodeguita;
DELIMITER //
CREATE PROCEDURE categoria_buscar(IN Valor varchar(50))
BEGIN
	SELECT idcategoria AS ID, nombre AS Nombre, descripcion AS Descripcion, estado AS Estado
	FROM categoria
	WHERE nombre LIKE '%' + Valor + '%' or descripcion LIKE '%' + Valor + '%'
	ORDER BY nombre;
END
//

--PEROCEDIMIENTO ACTUALIZAR CATEGORIA

DELIMITER //
create PROCEDURE categoria_actualizar (IN id_cat int, nombre_cat varchar(100), descripcion_cat varchar(200) )
 BEGIN
	 update categoria set categoria.nombre=nombre_cat, categoria.descripcion=descripcion_cat where categoria.idcategoria=id_cat;
 END;
//

--PROCEDIMIENTO DESACTIVAR CATEGORIA
DELIMITER //
CREATE PROCEDURE categoria_desactivar (IN id_cat int) 
BEGIN update categoria set estado=0 where idcategoria=id_cat; 
END;
//

--.PROCEDIMIENTO ACTIVAR CATEGORIA

DELIMITER //
CREATE PROCEDURE categoria_activar (IN id_cat int) 
BEGIN update categoria set estado=1 where idcategoria=id_cat; 
END;
//


DELIMITER //
CREATE PROCEDURE categoria_eliminar (IN id_cat int)
BEGIN
	DELETE FROM categoria WHERE idcategoria=id_cat;
END
//