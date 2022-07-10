delete from cliente

INSERT INTO cliente VALUES (1,70000001,'2019-10-01','2019-11-01','Universitario',600011,1,2,300);
INSERT INTO cliente VALUES (2,70000010,'2019-05-01','2019-07-01','Universitario',600010,2,2,100);
INSERT INTO cliente VALUES (3,70000011,'2019-05-01','2019-07-01','Deportista',600011,1,1,300);
INSERT INTO cliente VALUES (4,70000012,'2020-03-01','2020-05-01','Deportista',600012,3,1,200);
INSERT INTO cliente VALUES (5,70000013,'2020-03-01','2020-05-01','Deportista',600013,4,3,500);
INSERT INTO cliente VALUES (6,70000014,'2020-04-01','2020-06-01','Docente',600014,2,2,600);
INSERT INTO cliente VALUES (7,70000015,'2021-04-01','2021-06-01','Docente',600015,2,3,700);
INSERT INTO cliente VALUES (8,70000016,'2021-02-01','2021-11-01','Estudiante',600016,3,3,800);
INSERT INTO cliente VALUES (9,70000017,'2022-02-01','2022-11-01','Estudiante',600017,3,1,900);
INSERT INTO cliente VALUES (10,70000018,'2022-01-01','2022-07-01','Universitario',600018,4,2,625);
INSERT INTO cliente VALUES (11,70000019,'2022-01-01','2022-07-01','Universitario',600018,1,3,730);
INSERT INTO cliente VALUES (12,70000020,'2022-10-01','2022-12-01','Universitario',600020,4,1,422);

create PROC sp_reporte_clientes
as
begin

select persona.nombre as cliente, cliente.dni, cliente.fecha_ini, cliente.fecha_fin, cliente.ocupacion, planes.planes as planes, promocion.nombre as promocion from cliente
inner join persona on cliente.dni = persona.dni
inner join planes on cliente.id_planes = planes.id_planes
inner join promocion on cliente.id_promocion = promocion.id_promocion

end