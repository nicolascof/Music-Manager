USE cd 

SELECT G.descripcion
FROM grupo AS g, album AS A
WHERE A.id_grupo = G.id_grupo

-- COMPANIAS

SELECT * FROM companias

INSERT INTO companias
VALUES ('Universal Music Group',NULL)

-- DISQUERIAS

SELECT * FROM disquerias

INSERT INTO disquerias
VALUES ('Musimundo')

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
	ORDER BY 2

EXEC sp_SeleccionNombreGrupo

-- Seleccion de album's por grupo

SELECT * FROM grupo
SELECT * FROM album

CREATE 
ALTER PROCEDURE sp_SeleccionAlbumPorGrupo
	@nombreGrupo nvarchar(25)
AS
	SELECT *
	FROM album AS A, grupo AS G
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