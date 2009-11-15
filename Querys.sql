USE cd 

-- BRYAN ADAMS

UPDATE grupo
SET descripcion = 'Bryan Adams'
WHERE id_grupo = 1

UPDATE album
SET titulo = 'Reckless',
	costo = 45.98,
	fecha_terminado = '01/02/1985',
	fecha_lanzamiento = '01/06/1985',
	cant_temas = 10,
	duracion_album = 38
WHERE id_album = 3

-- DEPECHE MODE

INSERT INTO temas
VALUES (12, 3, 2, 342, 'The Sweetest Condition', null)

INSERT INTO temas
VALUES (12, 4, 2, 450, 'The Dead of Night', null)

INSERT INTO autores
VALUES ('David Gahan', 'M', null, null, null, null)

INSERT INTO generos (descricpion)
VALUES ('Electropop')

INSERT INTO grupo (descripcion, id_compania, cant_integrantes, solista_conjunto)
VALUES ('Depeche Mode', 4, 3, 0)

INSERT INTO album (id_genero, id_disqueria, id_compania, id_grupo, varios_artistas, titulo, costo, fecha_terminado, fecha_lanzamiento, cant_temas, duracion_album, observaciones)
VALUES ( 7, 2, 4, 2, 1, 'Sound of the Universe', 60.00, '15/09/2008', '09/06/2009', 13, 60, 'Ultimo disco de Depeche mode')

INSERT INTO album (id_genero, id_disqueria, id_compania, id_grupo, varios_artistas, titulo, costo, fecha_terminado, fecha_lanzamiento, cant_temas, duracion_album, observaciones)
VALUES ( 7, 2, 4, 2, 1, 'Playing the Angel', 10.00, '15/10/2006', '01/02/2007', 15, 75, 'Disco del año 2006-2007 - Temas recomendados: Suffer Well')

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
VALUES ('Grunge')

--#######################################################
--## Programacion II ####################################
--#######################################################

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
	@idGrupo int
AS
	SELECT *
	FROM album AS A
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
	WHERE A.id_grupo IN (
		SELECT G.id_grupo
		FROM grupo AS G 
		WHERE G.id_grupo = @idGrupo
		)

EXEC sp_SeleccionAlbumPorGrupo 2

-- Eliminacion de un album

SELECT * FROM album

CREATE PROCEDURE sp_EliminacionAlbum
	@idAlbum int
AS
	DELETE FROM album
	WHERE id_album = @idAlbum

EXEC sp_EliminacionAlbum 6

-- Agregar un album

SELECT * FROM album

CREATE PROCEDURE sp_AgregarAlbum
	@idGenero int,
	@idDisqueria int,
	@idCompania int,
	@idGrupo int,
	@variosArtistas bit,
	@titulo nvarchar(50),
	@costo decimal,
	@fechaTerminado datetime,
	@fechaLanzamiento datetime,
	@cantidadTemas int,
	@duracionAlbum int,
	@observaciones nvarchar(80)
AS
	INSERT INTO album (id_genero, id_disqueria, id_compania, id_grupo, varios_artistas, titulo, costo, fecha_terminado, fecha_lanzamiento, cant_temas, duracion_album, observaciones)
	VALUES ( @idGenero, @idDisqueria, @idCompania, @idGrupo, @variosArtistas, @titulo, @costo, @fechaTerminado, @fechaLanzamiento, @cantidadTemas, @duracionAlbum, @observaciones)

EXEC sp_AgregarAlbum 7, 2, 4, 2, 1, 'Exciter', 30.00, '01/12/2000','14/05/2001', 13, 56, 'Es el décimo álbum del grupo inglés de música electrónica'

-- Modificar un Album

SELECT * FROM album

CREATE PROCEDURE sp_ModificarAlbum
	@idAlbum int,
	@idGenero int,
	@idDisqueria int,
	@idCompania int,
	@idGrupo int,
	@variosArtistas bit,
	@titulo nvarchar(50),
	@costo decimal,
	@fechaTerminado datetime,
	@fechaLanzamiento datetime,
	@cantidadTemas int,
	@duracionAlbum int,
	@observaciones nvarchar(80)
AS
	UPDATE album
	SET id_genero = @idGenero, 
		id_disqueria = @idDisqueria, 
		id_compania = @idCompania, 
		id_grupo = @idGrupo, 
		varios_artistas = @variosArtistas, 
		titulo = @titulo, 
		costo = @costo, 
		fecha_terminado = @fechaTerminado, 
		fecha_lanzamiento = @fechaLanzamiento, 
		cant_temas = @cantidadTemas, 
		duracion_album = @duracionAlbum, 
		observaciones = @observaciones
	WHERE id_album = @idAlbum

EXEC sp_ModificarAlbum 8, 7, 2, 4, 2, 1, 'Exciter', 30.00, '01/12/2000','14/05/2001', 13, 56, 'Es el décimo álbum del grupo inglés de música electrónica'

-- Cargar Companias

CREATE PROCEDURE sp_CargarCompanias
AS
	SELECT *
	FROM companias

EXEC sp_CargarCompanias

--#######################################################
--## ABM Disquerias #####################################
--####################################################### 

SELECT * FROM disquerias

-- Cargar Disquerias

CREATE PROCEDURE sp_CargarDisquerias
AS
	SELECT *
	FROM disquerias

EXEC sp_CargarDisquerias

-- Agregar una Disquera

CREATE PROCEDURE sp_AgregarDisqueria
	@descripcion nvarchar(30)
AS
	INSERT INTO disquerias (descripcion)
	VALUES (@descripcion)

EXEC sp_AgregarDisqueria 'Musique'  

-- Eliminacion de una Disqueria

CREATE PROCEDURE sp_EliminarDisqueria
	@idDisqueria int
AS
	DELETE FROM disquerias
	WHERE id_disqueria = @idDisqueria

EXEC sp_EliminarDisqueria 3

-- Modificar una Disqueria

CREATE PROCEDURE sp_ModificarDisqueria
	@idDisqueria int,
	@descripcion nvarchar(30)
AS
	UPDATE disquerias
	SET descripcion = @descripcion
	WHERE id_disqueria = @idDisqueria

EXEC sp_ModificarDisqueria 4, 'Musique'