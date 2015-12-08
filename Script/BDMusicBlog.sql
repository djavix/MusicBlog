-- -----------Tablas------------------
CREATE TABLE USUARIO
(
	ID int primary key IDENTITY(1,1),
	NICK varchar(50) not null,
	PASSWORD varchar(50) not null	
)

CREATE TABLE PERFIL
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null,
	APELLIDO varchar(50) not null,
	FECHANACIMIENTO date not null,
	SEXO char(1) not null,
	CORREO varchar(50) not null,
	FK_USUARIO int
)

CREATE TABLE ARTISTA
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null
)

CREATE TABLE GRUPO
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null
)

CREATE TABLE PERTENECE
(
	FK_ARTISTA int,
	FK_GRUPO int,
	FECHAINGRESO date not null,
	FECHASALIDA date
)

CREATE TABLE BIOGRAFIA
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null,
	APELLIDO varchar(50),
	FECHANACIMIENTO date not null,
	HISTORIA varchar(max) not null,
	FK_ARTISTA int,
	FK_GRUPO int
)

CREATE TABLE GENERO
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null
)

CREATE TABLE DISCO
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null,
	FK_ARTISTA int,
	FK_GRUPO int
)

CREATE TABLE CANCION
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null,
	DURACION time not null,
	BPM int,
	FK_DISCO int,
	FK_GENERO int
)

CREATE TABLE LISTADEREPRODUCCION
(
	ID int primary key IDENTITY(1,1),
	NOMBRE varchar(50) not null,
	FECHA date not null,
	DESCRIPCION varchar(max) not null,
	FK_USUARIO int
)

CREATE TABLE MENU
(
	ID int primary key IDENTITY(1,1),
	NOMBREPAGINA varchar(max) not null,
	URL varchar(max) not null
)

CREATE TABLE CANCION_LISTA
(
	FK_CANCION int,
	FK_LISTA int
)

CREATE TABLE MENU_USUARIO
(
	FK_USUARIO int,
	FK_MENU int
)

-- -------------------Claves foraneas------------------------------

--PERFIL
alter table perfil add constraint FK_USUARIO_PERFIL foreign key (fk_usuario) references usuario(id)

--MENU_USUARIO
alter table menu_usuario add constraint FK_USUARIO_MENU_USUARIO foreign key (fk_usuario) references usuario(id)
alter table menu_usuario add constraint FK_MENU_MENU_USUARIO foreign key (fk_menu) references menu(id)

--LISTADEREPRODUCION
alter table listadereproduccion add constraint FK_USUARIO_LISTADEREPRODUCCION foreign key (fk_usuario) references usuario(id)

--CANCION_LISTA
alter table cancion_lista add constraint FK_LISTA_CANCION_LISTA foreign key (fk_lista) references listadereproduccion(id)
alter table cancion_lista add constraint FK_CANCION_CANCION_LISTA foreign key (fk_cancion) references cancion(id)

--CANCION
alter table cancion add constraint FK_DISCO_CANCION foreign key (fk_disco) references disco(id)
alter table cancion add constraint FK_GENERO_CANCION foreign key (fk_genero) references genero(id)

--DISCO
alter table disco add constraint FK_ARTISTA_DISCO foreign key (fk_artista) references artista(id)
alter table disco add constraint FK_GRUPO_DISCO foreign key (fk_grupo) references grupo(id)

--PERTENECE
alter table pertenece add constraint FK_ARTISTA_PERTENECE foreign key (fk_artista) references artista(id)
alter table pertenece add constraint FK_GRUPO_PERTENECE foreign key (fk_grupo) references grupo(id)

--BIOGRAFIA
alter table biografia add constraint FK_ARTISTA_BIOGRAFIA foreign key (fk_artista) references artista(id)
alter table biografia add constraint FK_GRUPO_BIOGRAFIA foreign key (fk_grupo) references grupo(id)