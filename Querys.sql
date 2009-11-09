USE cd 

-- BRYAN ADAMS

UPDATE album
SET titulo = 'Reckless',
	costo = 45.98,
	fecha_terminado = '01/02/1985',
	fecha_lanzamiento = '01/06/1985',
	cant_temas = 10,
	duracion_album = 38
WHERE id_album = 3

-- DEPECHE MODE

INSERT INTO generos (descricpion)
VALUES ('Electropop')

INSERT INTO grupo (descripcion, id_compania, cant_integrantes, solista_conjunto)
VALUES ('Depeche Mode', 4, 3, 0)

INSERT INTO album (id_genero, id_disqueria, id_compania, id_grupo, varios_artistas, titulo, costo, fecha_terminado, fecha_lanzamiento, cant_temas, duracion_album, observaciones)
VALUES ( 2, 7, 4, 2, 1, 'Sound of the Universe', 60.00, '15/09/2008', '09/06/2009', 13, 60, 'Ultimo disco de Depeche mode')

INSERT INTO album (id_genero, id_disqueria, id_compania, id_grupo, varios_artistas, titulo, costo, fecha_terminado, fecha_lanzamiento, cant_temas, duracion_album, observaciones)
VALUES ( 2, 7, 4, 2, 1, 'Playing the Angel', 10.00, '15/10/2006', '01/02/2007', 15, 75, 'Disco del a�o 2006-2007 - Temas recomendados: Suffer Well')

-- COMPANIAS

SELECT * FROM companias

INSERT INTO companias
VALUES ('Universal Music Group',NULL)

-- DISQUERIAS

SELECT * FROM disquerias

INSERT INTO disquerias
VALUES ('Musimundo')

-- GENEROS

SELECT * FROM generos

INSERT INTO generos
VALUES ('GRUNGE')

-- PROCEDIMIENTOS ALMACENADOS

-- Seleccion de nombres de grupos

SELECT * FROM grupo

CREATE 
ALTER PROCEDURE sp_SeleccionNombreGrupo
AS
	SELECT G.id_grupo,
		G.descripcion, 
		G.id_compania, 
		G.cant_integrantes, 
		G.solista_conjunto,
		COUNT(A.id_grupo)[cant_albums]
	FROM grupo AS G
		INNER JOIN album AS A
			ON G.id_grupo = A.id_grupo
	GROUP BY G.id_grupo, 
		G.descripcion, 
		G.id_compania, 
		G.cant_integrantes, 
		G.solista_conjunto
	ORDER BY 1

EXEC sp_SeleccionNombreGrupo

-- Seleccion de album's por grupo

SELECT * FROM grupo
SELECT * FROM album

CREATE 
ALTER PROCEDURE sp_SeleccionAlbumPorGrupo
	@nombreGrupo nvarchar(25)
AS
	SELECT *
	FROM album AS A
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
	WHERE A.id_grupo IN (
		SELECT G.id_grupo
		FROM grupo AS G 
		WHERE G.descripcion LIKE '%' + @nombreGrupo + '%'
		)

EXEC sp_SeleccionAlbumPorGrupo 'adams'

-- Seleccion de datos del album

CREATE 
ALTER PROCEDURE sp_SeleccionAlbum
	@nombreAlbum nvarchar(25)
AS
	SELECT *
	FROM album AS A
	WHERE A.titulo LIKE '%' + @nombreAlbum + '%'

EXEC sp_SeleccionAlbum 'verano'