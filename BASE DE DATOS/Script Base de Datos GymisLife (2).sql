create database GymisLife

USE GymisLife

----------------------
---- CREAR TABLAS ----
----------------------

--- TABLA 1 --- PROMOCION

create table promocion(
	id_promocion int,
    nombre varchar(100),
    descripcion text,
    descuento int,
    fecha_ini date,
    fecha_fin date,
	CONSTRAINT id_promocion_PK PRIMARY KEY (id_promocion));

--- TABLA 2 --- PLANES

create table planes(
	id_planes int,
    planes varchar(100),
    precio int,
    descripcion text,
	CONSTRAINT id_planes_PK PRIMARY KEY (id_planes));

--- TABLA 3 --- PERSONA

create table persona(
	id_persona int,
	dni int,
    nombre varchar(100),
    direccion varchar(100),
    telefono int,
    correo varchar(100),
    fecha_nacimiento date,
    sexo varchar(100),
	CONSTRAINT id_persona_PK PRIMARY KEY (id_persona));

--- TABLA 4 --- CLIENTES

create table cliente(
	id_dni int,
	dni int,
    fecha_ini date,
    fecha_fin date,
    ocupacion varchar(100),
    telefono_emergencia int,
    id_planes int,
    id_promocion int,
    num_boleta varchar(100),
CONSTRAINT id_dni_PK PRIMARY KEY (id_dni),
CONSTRAINT id_planes_FK FOREIGN KEY (id_planes)
REFERENCES planes(id_planes),
CONSTRAINT id_promocion_FK FOREIGN KEY (id_promocion)
REFERENCES promocion(id_promocion));

--- TABLA 5 --- EMPLEADO

create table empleado(
	id_empleado int,
	id_persona int,
    sueldo varchar(100),
	usuario VARCHAR(100),
	contraseña VARCHAR(100),
CONSTRAINT id_empleado_PK PRIMARY KEY (id_empleado),
CONSTRAINT id_persona_FK FOREIGN KEY (id_persona)
REFERENCES persona(id_persona));

--- TABLA 6 --- AREA

create table areas(
	id_areas int,
    nombre varchar(100),
CONSTRAINT id_areas_PK PRIMARY KEY (id_areas));

--- TABLA 7 --- PUESTO

create table puesto(
	id_puesto int,
    nombre varchar(100),
	id_areas int,
CONSTRAINT id_puesto_PK PRIMARY KEY (id_puesto),
CONSTRAINT id_areas_FK FOREIGN KEY (id_areas)
REFERENCES areas(id_areas));

--- TABLA 8 --- ENTRENADOR

create table entrenador(
	id_entrenador int,
    descripcion varchar(100),
	id_persona int,
CONSTRAINT id_entrenador_PK PRIMARY KEY (id_entrenador),
CONSTRAINT id_persona_LK FOREIGN KEY (id_persona)
REFERENCES persona(id_persona));

--- TABLA 9 --- PROVEEDOR

create table proveedor(
	id_proveedor int,
    nombre varchar(100),
    ruc varchar(100),
	direccion varchar(100),
    telefono int,
    correo varchar(100),
	CONSTRAINT id_proveedor_PK PRIMARY KEY (id_proveedor));

--- TABLA 10 --- PRODUCTO

create table producto(
	id_producto int,
    nombre varchar(100),
    cantidad int,
    precio_compra int,
    precio_venta int,
	id_proveedor int,
	CONSTRAINT id_producto_PK PRIMARY KEY (id_producto),
	CONSTRAINT id_proveedor_FK FOREIGN KEY (id_proveedor)
	REFERENCES proveedor(id_proveedor));


-----------------------
--- INSERTAR DATOS ----
-----------------------

--- TABLA 1 --- PROMOCION

INSERT INTO promocion VALUES (001,'Navidenia','Descuento del 10% en cualquier plan. Acumulable con otras promociones.',10,'2018-12-01','2018-12-31');
INSERT INTO promocion VALUES (002,'Universitario','Descuento del 20% en cualquier plan. No acumulable con otras promociones.',20,'2018-01-01','2018-12-31');
INSERT INTO promocion VALUES (003,'Deportista','Descuento del 10% los tres primeros meses en plan semestral y anual. No acumulable con otras promociones.',10,'2018-06-01','2018-10-15');

--- TABLA 2 --- PAQUETES

INSERT INTO planes VALUES (1,'Mensual',140,'Incluye control nutricional.');
INSERT INTO planes VALUES (2,'Trimestral',250,'Incluye control nutricional. Acceso gratis a 1 evento.');
INSERT INTO planes VALUES (3,'Semestral',370,'Incluye control nutricional. Acceso gratis a 3 eventos.');
INSERT INTO planes VALUES (4,'Anual',599,'Incluye control nutricional. Acceso gratis a todos los eventos.');

--- TABLA 3 --- PERSONA

INSERT INTO persona VALUES (1,70000001,'Jose Trauco','Arequipa 100',600001,'joset@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (2,70000002,'Marco Martinez','Arequipa 200',600002,'marcom@gmail.com','1980-12-21','M');
INSERT INTO persona VALUES (3,70000003,'Martin Vizcarra','Arequipa 300',600003,'martinv@gmail.com','1980-10-21','M');
INSERT INTO persona VALUES (4,70000004,'Alan Garcia','Arequipa 400',600004,'alang@gmail.com','1980-01-21','M');
INSERT INTO persona VALUES (5,70000005,'Ollanta Humala','Arequipa 500',600005,'ollantah@gmail.com','1981-03-21','M');
INSERT INTO persona VALUES (6,70000006,'Popi Olivera','Arequipa 600',600006,'popio@gmail.com','1978-05-21','M');
INSERT INTO persona VALUES (7,70000007,'Maria Gomez','Arequipa 700',600007,'mariag@gmail.com','1978-05-21','F');
INSERT INTO persona VALUES (8,70000008,'Mario Olivera','Arequipa 800',600008,'marioo@gmail.com','1979-06-22','M');
INSERT INTO persona VALUES (9,70000009,'Fernanda Olivera','Arequipa 900',600009,'fernandao@gmail.com','1979-07-23','F');

INSERT INTO persona VALUES (10,70000010,'Luz Martinez','Arequipa',6000010,'luz@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (11,70000011,'Miguel Martinez','Arequipa',6000011,'miguel@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (12,70000012,'Jesus Martinez','Arequipa',6000012,'jesus@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (13,70000013,'Lucia Martinez','Arequipa',6000013,'lucia@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (14,70000014,'Mario Martinez','Arequipa',6000014,'mario@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (15,70000015,'Sebastian Martinez','Arequipa',6000015,'sebastian@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (16,70000016,'Marcelo Martinez','Arequipa',6000016,'marcelo@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (17,70000017,'Melo Martinez','Arequipa',6000017,'melo@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (18,70000018,'Rodrigo Martinez','Arequipa',600018,'rodrigo@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (19,70000019,'Rocio Martinez','Arequipa',6000019,'rocio@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (20,70000020,'Mariano Martinez','Arequipa',6000020,'mariano@gmail.com','1980-11-21','M');

INSERT INTO persona VALUES (21,70000021,'Elon Musk','Lima',600021,'elon@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (22,70000022,'Jacinto Martinez','Arequipa',6000022,'j@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (23,70000023,'Lourdez Martinez','Arequipa',6000023,'l@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (24,70000024,'Martin Martinez','Arequipa',6000024,'m@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (25,70000025,'Sejota Martinez','Arequipa',6000025,'se@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (26,70000026,'Marco Polo Martinez','Arequipa',6000026,'m@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (27,70000027,'Pepe Martinez','Arequipa',6000027,'pp@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (28,70000028,'Rosa Martinez','Arequipa',600028,'ro@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (29,70000029,'Rio Martinez','Arequipa',6000029,'rio@gmail.com','1980-11-21','F');
INSERT INTO persona VALUES (30,70000030,'Miguel Martinez','Arequipa',6000030,'m@gmail.com','1980-11-21','M');
INSERT INTO persona VALUES (31,70000031,'Diego Maradon','Lima',600031,'diego@gmail.com','1980-11-21','M');

--- TABLA 4 --- CLIENTE

INSERT INTO cliente VALUES (1,70000001,'2019-10-01','2019-11-01','Universitario',600011,1,002,300);
INSERT INTO cliente VALUES (2,70000010,'2019-05-01','2019-07-01','Universitario',600010,1,002,300);
INSERT INTO cliente VALUES (3,70000011,'2019-05-01','2019-07-01','Deportista',600011,1,002,300);
INSERT INTO cliente VALUES (4,70000012,'2020-03-01','2020-05-01','Deportista',600012,1,002,400);
INSERT INTO cliente VALUES (5,70000013,'2020-03-01','2020-05-01','Deportista',600013,1,002,400);
INSERT INTO cliente VALUES (6,70000014,'2020-04-01','2020-06-01','Docente',600014,1,002,400);
INSERT INTO cliente VALUES (7,70000015,'2021-04-01','2021-06-01','Docente',600015,1,002,500);
INSERT INTO cliente VALUES (8,70000016,'2021-02-01','2021-11-01','Estudiante',600016,1,002,500);
INSERT INTO cliente VALUES (9,70000017,'2022-02-01','2022-11-01','Estudiante',600017,1,002,500);
INSERT INTO cliente VALUES (10,70000018,'2022-01-01','2022-07-01','Universitario',600018,1,002,600);
INSERT INTO cliente VALUES (11,70000019,'2022-01-01','2022-07-01','Universitario',600018,1,002,600);
INSERT INTO cliente VALUES (12,70000020,'2022-10-01','2022-12-01','Universitario',600020,1,002,600);

--- TABLA 5 --- EMPLEADO

INSERT INTO empleado VALUES (1,3,2500,70000003,70000003);
INSERT INTO empleado VALUES (2,5,1500,70000005,70000005);

--- TABLA 6 --- AREA

INSERT INTO areas VALUES (1,'Administracion');
INSERT INTO areas VALUES (2,'Dirección General');
INSERT INTO areas VALUES (3,'Logistica');
INSERT INTO areas VALUES (4,'Asesor Comercial');

--- TABLA 7 --- PUESTO

INSERT INTO puesto VALUES (1,'Personal Administrativo',1);
INSERT INTO puesto VALUES (2,'Atención al Cliente',4);
INSERT INTO puesto VALUES (3,'Encargado de Tienda',3);

--- TABLA 8 --- ENTRENADOR

INSERT INTO entrenador VALUES (1,'Rutinas de Baile',8);
INSERT INTO entrenador VALUES (2,'Rutinas de Maquinas',10);
INSERT INTO entrenador VALUES (3,'Rutinas de Cardio',16);

--- TABLA 9 --- PROVEEDOR

INSERT INTO proveedor VALUES (1,'Saga Falabella',20348255963,'Calle Proceres 140',2745380,'atencionsaga@sagafalabella.com');
INSERT INTO proveedor VALUES (2,'Ripley',20348003963,'Calle Proceres 140',2745380,'atencionripley@ripley.com');
INSERT INTO proveedor VALUES (3,'Mesajil Hermanos',20348293363,'Calle Proceres 140',2745380,'atencionmesajil@mesajil.com');
INSERT INTO proveedor VALUES (4,'Coolbox',20348200063,'Calle Proceres 140',2745380,'atencioncolbox@coolbox.com');
INSERT INTO proveedor VALUES (5,'Fitnees',21119855963,'Calle Proceres 140',2745380,'atencionfitness@fitnees.com');
INSERT INTO proveedor VALUES (6,'FitnessArticulos',20003255963,'Calle Proceres 140',2745380,'atencionfitness@fitnessarticulos.com');


--- TABLA 10 --- PRODUCTO

INSERT INTO producto VALUES (1,'Botella Tritan',12,40,49,3);
INSERT INTO producto VALUES (2,'Colchoneta',12,35,46,1);
INSERT INTO producto VALUES (3,'Cuerda Saltar',12,45,53,1);
INSERT INTO producto VALUES (4,'Toalla',12,22,28,2);
INSERT INTO producto VALUES (5,'Banda Resistencia',12,24,32,6);
INSERT INTO producto VALUES (6,'Meñisquera',12,43,59,5);
INSERT INTO producto VALUES (7,'Pelota',12,41,51,4);

