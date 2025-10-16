
CREATE SCHEMA fastline;
USE fastline;

CREATE TABLE Estados(
ID_estado int NOT NULL auto_increment,
tipo varchar(100),
primary key (ID_estado)
);

CREATE TABLE Ciudades(
ID_ciudad int NOT NULL auto_increment,
nombre varchar(150) NOT NULL,
PRIMARY KEY(ID_ciudad));

CREATE TABLE Pasajeros(
Id_pasajero int NOT NULL auto_increment,
id_ciudad_residencia int NOT NULL,
nombre varchar(100) NOT NULL,
apellido_1 varchar(100) NOT NULL,
apellido_2 varchar(100),
correo varchar(150) NOT NULL,
telefono Varchar(30) NOT NULL,
PRIMARY KEY(Id_pasajero),
FOREIGN KEY(id_ciudad_residencia) REFERENCES Ciudades(ID_ciudad)
);


CREATE TABLE Rutas(
ID_ruta int NOT NULL auto_increment,
id_ciudad_origen int NOT NULL,
id_ciudad_destino int NOT NULL,
estado_ruta int NOT NULL,
precio_base numeric(10,2),
PRIMARY KEY(ID_ruta),
FOREIGN KEY(id_ciudad_origen) REFERENCES Ciudades(ID_ciudad),
FOREIGN KEY(id_ciudad_destino) REFERENCES Ciudades(ID_ciudad)
 );
 
CREATE TABLE Empleados(
ID_empleado int NOT NULL auto_increment,
estado_empleado int NOT NULL,
nombre varchar(100) NOT NULL,
apellido_1 varchar(100) NOT NULL,
apellido_2 varchar(100),
direccion varchar(150) NOT NULL,
fecha_vinculacion date NOT NULL,
cargo varchar(150),
PRIMARY KEY(ID_empleado),
FOREIGN KEY(estado_empleado) REFERENCES Estados(ID_estado)
);

CREATE TABLE Aviones(
  ID_avion int NOT NULL auto_increment,
  Estado_avion int NOT NULL,
  Referencia varchar(100),
  Aforo_maximo int NOT NULL,
  Size varchar(100),
  fecha_ensamblaje_avion date,
  matricula varchar(10),
  PRIMARY KEY(ID_avion),
  FOREIGN KEY (Estado_avion) REFERENCES Estados(ID_estado)
);
CREATE TABLE vuelos(
  ID_vuelo int NOT NULL auto_increment,
  id_ruta int NOT NULL,
  id_estado_vuelo int NOT NULL,
  id_avion int NOT NULL,
  fecha_hora_salida timestamp NOT NULL,
  fecha_hora_llegada timestamp NOT NULL,
  PRIMARY KEY (ID_vuelo),
  FOREIGN KEY (id_ruta) REFERENCES Rutas(ID_ruta),
  FOREIGN KEY (id_estado_vuelo) REFERENCES Estados(ID_estado),
  FOREIGN KEY (id_avion) REFERENCES Aviones(ID_avion)
);

CREATE TABLE Reservas(
ID_reserva int NOT NULL auto_increment,
id_vuelo int NOT NULL,
id_estado_reserva int NOT NULL,
codigo_reserva varchar(6),
fecha_emision date,
PRIMARY KEY(ID_reserva),
FOREIGN KEY(id_vuelo) REFERENCES vuelos(ID_vuelo),
FOREIGN KEY(id_estado_reserva) REFERENCES Estados(ID_estado)
);

CREATE TABLE tickets(
ID_ticket int NOT NULL auto_increment,
id_pasajero int NOT NULL,
id_reserva int NOT NULL,
numero_asiento varchar(5),
precio numeric(10,2),
PRIMARY KEY(ID_ticket),
FOREIGN KEY(id_pasajero) REFERENCES Pasajeros(Id_pasajero),
FOREIGN KEY(id_reserva) REFERENCES Reservas(ID_reserva)
);

 CREATE TABLE Empleado_vuelos(
    ID_vuelo int NOT NULL,
    ID_empleado int NOT NULL,
    ID_estado int NOT NULL,
    PRIMARY KEY (ID_vuelo, ID_empleado, ID_estado),
    FOREIGN KEY (ID_vuelo) REFERENCES Vuelos(ID_vuelo),
    FOREIGN KEY (ID_empleado) REFERENCES Empleados(ID_empleado), 
    FOREIGN KEY (ID_estado) REFERENCES Estados(ID_estado) 
);

INSERT INTO Estados (tipo) VALUES ('Activo');
INSERT INTO Estados (tipo) VALUES ('Inactivo');
INSERT INTO Estados (tipo) VALUES ('Pendiente');
INSERT INTO Estados (tipo) VALUES ('En Espera');

SELECT* FROM Estados;

INSERT INTO Ciudades (nombre) VALUES ('Medellin');
INSERT INTO Ciudades (nombre) VALUES ('Bogota');
INSERT INTO Ciudades (nombre) VALUES ('San Andres');
INSERT INTO Ciudades (nombre) VALUES ('Barranquilla');
INSERT INTO Ciudades (nombre) VALUES ('Cali');

SELECT* FROM Ciudades;

INSERT INTO Pasajeros (id_ciudad_residencia, nombre, apellido_1, apellido_2, correo, telefono) 
VALUES (1, 'Samuel', 'Correa', 'Velasquez','samcorr@gmail.com', '3008292389');
INSERT INTO Pasajeros (id_ciudad_residencia, nombre, apellido_1, apellido_2, correo, telefono) 
VALUES (2, 'Antonia', 'Torres', '','mariantoni@gmail.com', '30088994774');
INSERT INTO Pasajeros (id_ciudad_residencia, nombre, apellido_1, apellido_2, correo, telefono) 
VALUES (3, 'Juliana', 'Valencia', '','juliana34@gmail.com', '30132242441');

SELECT* FROM Pasajeros;

INSERT INTO Rutas (id_ciudad_origen, id_ciudad_destino, estado_ruta, precio_base) 
VALUES (1, 2, 1, 320000.00);
INSERT INTO Rutas (id_ciudad_origen, id_ciudad_destino, estado_ruta, precio_base) 
VALUES (4, 3, 1, 400000.00);
INSERT INTO Rutas (id_ciudad_origen, id_ciudad_destino, estado_ruta, precio_base) 
VALUES (1, 5, 3, 120000.20);

SELECT* FROM Rutas;

INSERT INTO Empleados (estado_empLeado, nombre, apellido_1, apellido_2, direccion, fecha_vinculacion, cargo) 
VALUES (1, 'Pepe', 'Garcia', 'Montes', 'carrera 28-16', '2025-09-30', 'Piloto');
INSERT INTO Empleados (estado_empLeado, nombre, apellido_1, apellido_2, direccion, fecha_vinculacion, cargo) 
VALUES (1, 'Julia', 'Lopez', '', 'Calle 27 #34-89', '2023-08-23', 'Asafata');
INSERT INTO Empleados (estado_empLeado, nombre, apellido_1, apellido_2, direccion, fecha_vinculacion, cargo) 
VALUES (4, 'Miguel', 'Velez', 'Hernandez', 'Av. San Juan, Calle 27-78', '1999-07-19', 'Gerente');

SELECT* FROM Empleados;

INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (1, 'Airbus A320neo', '200','Mediano', '2021-06-21', 'HK-4801');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (1, 'Boeing 737-800', '180','Mediano', '1999-02-19', 'HK-5328');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (4, 'Embraer E190', '210','Mediano', '2000-01-09', 'HK-4567');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (2, 'Airbus A321XLR', '300','Grande', '2019-03-10', 'HK-5212');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (3, 'Boeing 787-9 Dreamliner', '310','Grande', '2017-05-11', 'HK-4920');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (1, 'Airbus A350-900', '320','Grande', '2015-01-12', 'HK-5075');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (1, 'Bombardier CRJ900', '120','small', '2010-10-23', 'HK-4539');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (2, 'Boeing 777-300ER', '100','small', '1978-09-12', 'HK-5278');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (3, 'Airbus A319', '90','small', '1980-07-11', 'HK-4813');
INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (3, 'ATR 72-600', '130','small', '1989-03-25', 'HK-4457');

SELECT* FROM Aviones;

INSERT INTO vuelos (id_ruta, id_estado_vuelo, id_avion, fecha_hora_salida, fecha_hora_llegada) 
VALUES (1, 1, 2, '2025-10-15 08:30:00','2025-10-15 9:30:00');
INSERT INTO vuelos (id_ruta, id_estado_vuelo, id_avion, fecha_hora_salida, fecha_hora_llegada) 
VALUES (2, 3, 2, '2025-08-03 14:00:00','2025-08-03 16:00:00');
INSERT INTO vuelos (id_ruta, id_estado_vuelo, id_avion, fecha_hora_salida, fecha_hora_llegada) 
VALUES (3, 4, 2, '2025-12-24 13:00:00','2025-12-24 14:00:00');

SELECT* FROM vuelos;

INSERT INTO Reservas (id_vuelo, id_estado_reserva, codigo_reserva, fecha_emision)
VALUES (1, 1, 'A4545', '2025-08-10');
INSERT INTO Reservas (id_vuelo, id_estado_reserva, codigo_reserva, fecha_emision)
VALUES (2, 4, 'A4546', '2025-09-12');
INSERT INTO Reservas (id_vuelo, id_estado_reserva, codigo_reserva, fecha_emision)
VALUES (3, 3, 'A4547', '2025-10-15');

SELECT* FROM Reservas;

INSERT INTO tickets(id_pasajero, id_reserva, numero_asiento, precio)
VALUES (1, 1, '1A', 345000.50);
INSERT INTO tickets(id_pasajero, id_reserva, numero_asiento, precio)
VALUES (2, 2, '7B', 255000.20);
INSERT INTO tickets(id_pasajero, id_reserva, numero_asiento, precio)
VALUES (3, 3, '4C', 295000.10);

SELECT* FROM tickets;

INSERT INTO Empleado_vuelos (ID_vuelo, ID_empleado, ID_estado)
VALUES(1, 1, 1);
INSERT INTO Empleado_vuelos (ID_vuelo, ID_empleado, ID_estado)
VALUES(1, 2, 1);
INSERT INTO Empleado_vuelos (ID_vuelo, ID_empleado, ID_estado)
VALUES(2, 3, 4);

SELECT* FROM Empleado_vuelos;











































