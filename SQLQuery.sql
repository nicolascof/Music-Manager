USE cd

-- 1. Ver las Disquerias y Companias con su respectivo Grupo
-- El nombre del grupo es ingresado por programa

CREATE PROCEDURE sp_Consulta01
	@nombreGrupo nvarchar(25)
AS
	SELECT C.descripcion[Nombre],
		'Compania'[Tipo],
		G.descripcion + ' : ' + A.titulo[Grupo : Album]
	FROM album AS A
		INNER JOIN companias AS C
			ON A.id_compania = C.id_compania
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
	WHERE G.descripcion LIKE '%' + @nombreGrupo + '%'
	UNION
	SELECT D.descripcion, 
		'Disqueria',
		G.descripcion + ' : ' + A.titulo
	FROM album AS A
		INNER JOIN disquerias AS D
			ON A.id_disqueria = D.id_disqueria
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
	WHERE G.descripcion LIKE '%' + @nombreGrupo + '%'
	ORDER BY 3, 2

EXEC sp_Consulta01 'adams'

-- 2. Ver cantidad de temas por autor y album seleccionados por genero
-- El genero es ingresado por programa

CREATE PROCEDURE sp_Consulta02
	@generoDescripcion nvarchar(25)
AS
	SELECT A.nombre[Autor],
		Al.titulo[Album],
		COUNT(T.id_autor)[Cantidad Temas]
	FROM album AS Al
		INNER JOIN temas AS T
			ON Al.id_album = T.id_album
		INNER JOIN autores AS A
			ON T.id_autor = A.id_autor
		INNER JOIN generos AS G
			ON Al.id_genero = G.id_genero
	WHERE G.descricpion LIKE '%' + @generoDescripcion + '%'
	GROUP BY A.nombre, Al.titulo

EXEC sp_Consulta02 'jazz'

-- 3. Ver album's sacados por anio
-- El anio es ingresado por programa ej. 2009

CREATE 
ALTER PROCEDURE sp_Consulta03
	@anio int
AS
	SELECT G.descripcion[Grupo], 
		A.titulo[Titulo],
		Ge.descricpion[Genero],
		CASE ISNULL(MONTH(A.fecha_lanzamiento), 0)
			WHEN 0 THEN 'Falta Fecha Lanzamiento'
			WHEN 1 THEN 'Enero'
			WHEN 2 THEN 'Febrero'
			WHEN 3 THEN 'Marzo'
			WHEN 4 THEN 'Abril'
			WHEN 5 THEN 'Mayo'
			WHEN 6 THEN 'Junio'
			WHEN 7 THEN 'Julio'
			WHEN 8 THEN 'Agosto'
			WHEN 9 THEN 'Septiembre'
			WHEN 10 THEN 'Octubre'
			WHEN 11 THEN 'Noviembre'
			WHEN 12 THEN 'Diciembre'
		END[Mes Lanzamiento]
	FROM album AS A
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
		INNER JOIN generos AS Ge
			ON A.id_genero = Ge.id_genero
	WHERE A.id_album IN (
		SELECT Al.id_album
		FROM album AS Al
		WHERE Al.id_album = A.id_album 
			AND YEAR(Al.fecha_lanzamiento) = @anio
		)
	ORDER BY 1, 4

EXEC sp_Consulta03 1985
	
-- Calcula la antiguedad de los discos de un grupo
-- El nombre del grupo, fechas y duracion son ingresado por programa

CREATE
ALTER PROCEDURE sp_Consulta04
	@nombreGrupo nvarchar(25),
	@fechaInicial datetime,
	@fechaFinal datetime,
	@duracionAlbum int
AS
	SELECT G.descripcion[Grupo], 
		A.titulo[Album],
		Ge.descricpion[Genero],
		C.descripcion[Compania],
		D.descripcion[Disqueria],
		CASE ISNULL(DATEDIFF(year, A.fecha_lanzamiento, getdate()), -1)
			WHEN -1 THEN 'Falta Fecha Lanzamiento'
			WHEN 0 THEN CAST(DATEDIFF(day, A.fecha_lanzamiento, getdate()) AS nvarchar) + ' Dias'
			ELSE CAST(DATEDIFF(year, A.fecha_lanzamiento, getdate()) AS nvarchar) + ' Años'
		END[Antiguedad],
		'U$D ' + CAST(A.costo AS nvarchar)[Costo]
	FROM album AS A
		INNER JOIN grupo AS G
			ON A.id_grupo = G.id_grupo
		INNER JOIN generos AS Ge
			ON A.id_genero = Ge.id_genero
		INNER JOIN companias AS C
			ON A.id_compania = C.id_compania
		INNER JOIN disquerias AS D
			ON A.id_disqueria = D.id_disqueria
	WHERE G.descripcion LIKE '%' + @nombreGrupo + '%'
		OR (ISNULL(A.fecha_lanzamiento, '01/01/1800') BETWEEN @fechaInicial AND @fechaFinal)
		AND ISNULL(A.duracion_album, 0) >= @duracionAlbum
	ORDER BY 1, 2, 6, 7

EXEC sp_Consulta04 null,'01/01/1983','01/01/1990',0
EXEC sp_Consulta04 'adams',null,null,0
EXEC sp_Consulta04 'depeche',null,null,0