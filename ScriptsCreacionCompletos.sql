Drop database IF EXISTS  BASEDEDATOS ; 

create database BASEDEDATOS ;
use BASEDEDATOS; 

SET FOREIGN_KEY_CHECKS=0;   
CREATE TABLE  `states` (
  `id_state` INT NOT NULL AUTO_INCREMENT,
  `Name_State` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_state`));

 CREATE TABLE  `Types_Clients` (
  `id_type` INT NOT NULL AUTO_INCREMENT,
  `Name_Type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_type`));


CREATE TABLE `users` (
  `Id_User` int NOT NULL AUTO_INCREMENT,
  `Name_User` varchar(50) NOT NULL,
  `LName_User` varchar(50) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `UserApps` varchar(40) not null,
   `Password` varchar(45) NOT NULL,
  `Client_Type` int NOT NULL,
  `State_user` int NOT NULL,
  PRIMARY KEY (`Id_User`)
) ;
 
ALTER TABLE  `users` 
ADD CONSTRAINT `EstadoUsers`
  FOREIGN KEY (`State_user`)
  REFERENCES  `states` (`id_state`);
  

   
    CREATE TABLE `Categories` (
  `Id_Category` int NOT NULL AUTO_INCREMENT,
  `Description_Category` varchar(50) NOT NULL, 
  `State_Category` int NOT NULL,
  PRIMARY KEY (`Id_Category`)
) ;
ALTER TABLE  `Categories` 
ADD CONSTRAINT `StateCategory`
  FOREIGN KEY (`State_Category`)
  REFERENCES  `states` (`id_state`);
  
  
 
  CREATE TABLE `Products` (
  `Id_Product` int NOT NULL AUTO_INCREMENT,
  `Description_Product` varchar(50) NOT NULL,
  `Price_Product` double(12,2) NOT NULL,
  `Category` int NOT NULL,
  `State_Product` int NOT NULL,
  PRIMARY KEY (`Id_Product`)
) ;
 
ALTER TABLE  `Products` 
ADD CONSTRAINT `StateProduct`
  FOREIGN KEY (`State_Product`)
  REFERENCES  `states` (`id_state`);
  
  ALTER TABLE  `Products` 
ADD CONSTRAINT `FKCategory`
  FOREIGN KEY (`Category`)
  REFERENCES  `Categories` (`Id_Category`);
  
  CREATE TABLE Aviones (
  ID_avion INT NOT NULL AUTO_INCREMENT,
  Referencia VARCHAR(100),
  Aforo_maximo INT NOT NULL,
  Size VARCHAR(100),
  fecha_ensamblaje_avion DATE,
  matricula VARCHAR(10) UNIQUE, 
  Estado_avion INT NOT NULL,
  PRIMARY KEY (ID_avion)
);
ALTER TABLE  Aviones 
ADD CONSTRAINT EstadoAviones
  FOREIGN KEY (Estado_avion)
  REFERENCES  states (id_state);


  
insert into states(Name_State) values ('Activo');
insert into states(Name_State) values ('Inactivo'); 
insert into Types_Clients(Name_Type) values ('Cliente');
insert into Types_Clients(Name_Type) values ('Colaborador');
insert into users (Name_User,LName_User,Email,UserApps,Password,Client_Type,State_user) values ('ANDRES','LOPEZ','alopeza10@eafit.com','alopez','1234',1,1);

INSERT INTO Aviones (Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula)
VALUES (1, 'Airbus A320neo', '200','Mediano', '2021-06-21', 'HK-4801');


insert into Categories(Description_Category,State_Category) values ('gaseosas',1);
insert into Categories(Description_Category,State_Category) values ('alimentos',1);

DELIMITER $$

CREATE PROCEDURE  ActualizarUsuario ( VI_Name_user varchar(50), VI_LName_User varchar(50), VI_Email varchar(45), VI_UserApps varchar(40), VI_Password varchar(45),VI_Client_Type int,VI_State_user int)
/****** 
Nombre: ActualizarUsuario 
Fecha:	2025/05/01
Autor:	Andres Lopez Alvarez
Objetivo: Procedimiento que actualiza un usuario de la base de datos de la tabla users. 	
--========================VERSIONAMIENTO==========================--
____________________________________________________________________
Versión |     Fecha    |     Autor    |   Descripción				|
________|______________|______________|_____________________________|
  1.0	    2025/05/01    Andrés Lopez   Creación de procedimiento
--================================================================-- 
******/
BEGIN
DECLARE SQL_Query Varchar(2000);
DECLARE Exec bool;
SET exec = false;

SET SQL_Query = 'UPDATE users set  '; 
IF (VI_Name_user is not null) THEN	 
	SET SQL_Query =  concat(SQL_Query,' Name_user= ''', VI_Name_user ,''''); 
	SET exec =  True; 
END IF;

IF (VI_LName_User is not null) THEN
	IF (Exec) THEN
		SET SQL_Query =  concat(SQL_Query,' , LName_User= ''',VI_LName_User ,'''');
	ELSE
		SET SQL_Query =  concat(SQL_Query,' LName_User= ''',VI_LName_User ,'''');
        SET exec =  True;
	END IF;  
END IF;

IF (VI_Email is not null) THEN
	IF (Exec) THEN
		SET SQL_Query =  concat(SQL_Query,' , Email= ''',VI_Email ,'''');
	ELSE
		SET SQL_Query =  concat(SQL_Query,' Email= ''', VI_Email ,'''');
        SET exec =  True;
	END IF;  
END IF;

IF (VI_Password is not null) THEN
	IF (Exec) THEN
		SET SQL_Query =  concat(SQL_Query,' , Password= ''',VI_Password ,'''');
	ELSE
		SET SQL_Query =  concat(SQL_Query,' Password= ''',VI_Password ,'''');
        SET exec =  True;
	END IF;  
END IF;

IF (VI_Client_Type is not null) THEN
	IF (Exec) THEN
		SET SQL_Query =  concat(SQL_Query,' , Client_Type= ''',VI_Client_Type ,'''');
	ELSE
		SET SQL_Query =  concat(SQL_Query,' Client_Type= ''',VI_Client_Type ,'''');
        SET exec =  True;
	END IF;  
END IF;

IF (VI_State_user is not null) THEN
	IF (Exec) THEN
		SET SQL_Query =  concat(SQL_Query,' , State_user= ''',VI_State_user ,'''');
	ELSE
		SET SQL_Query =  concat(SQL_Query,' State_user= ''',VI_State_user ,'''');
        SET exec =  True;
	END IF; 
END IF;

Set SQL_Query = CONCAT( SQL_Query,' where UserApps= ? ');
 
IF (Exec) THEN 
	 SET @mi_id= VI_UserApps;
	 set @aejecutar= SQL_Query; 
	  PREPARE SQL_QueryFinal FROM @aejecutar;  
	 EXECUTE SQL_QueryFinal using  @mi_id;
END IF;

END$$



DELIMITER $$

CREATE  PROCEDURE  InsertarUsuario ( VI_Name_user varchar(50), VI_LName_User varchar(50), VI_Email varchar(45), VI_UserApps varchar(40), VI_Password varchar(45),VI_Client_Type int,VI_State_user int)
/****** 
Nombre: InsertarUsuario 
Fecha:	2025/05/01
Autor:	Andres Lopez Alvarez
Objetivo: Procedimiento que inserta un usuario de la base de datos de la tabla users. 	
--========================VERSIONAMIENTO==========================--
____________________________________________________________________
Versión |     Fecha    |     Autor    |   Descripción				|
________|______________|______________|_____________________________|
  1.0	    2025/05/01    Andrés Lopez   Creación de procedimiento
--================================================================-- 
******/
BEGIN

 INSERT INTO users (Name_User,LName_User,Email,UserApps,Password,Client_Type,State_user) 
 VALUES (VI_Name_user,VI_LName_User,VI_Email,VI_UserApps,VI_Password, VI_Client_Type,VI_State_user);

END$$
DELIMITER $$

CREATE PROCEDURE InsertarAvion ( 
    VI_Estado_avion INT, 
    VI_Referencia VARCHAR(100), 
    VI_Aforo_maximo INT, 
    VI_Size VARCHAR(100), 
    VI_fecha_ensamblaje_avion DATE, 
    VI_matricula VARCHAR(10)
)
/****** Nombre: InsertarAvion 
Fecha:	2025/10/15
Autor:	Andres Lopez Alvarez
Objetivo: Procedimiento que inserta un avión en la tabla Aviones. 	
--========================VERSIONAMIENTO==========================--
____________________________________________________________________
Versión |     Fecha    |     Autor    |   Descripción				|
________|______________|______________|_____________________________|
  1.0	    2025/10/15    Andrés Lopez   Creación de procedimiento
--================================================================-- 
******/
BEGIN
  INSERT INTO Aviones (
    Estado_avion, Referencia, Aforo_maximo, Size, fecha_ensamblaje_avion, matricula
  ) 
  VALUES (
    VI_Estado_avion, VI_Referencia, VI_Aforo_maximo, VI_Size, VI_fecha_ensamblaje_avion, VI_matricula
  );
END$$


DELIMITER $$

CREATE PROCEDURE ActualizarAvion ( 
    VI_Referencia VARCHAR(100), 
    VI_Aforo_maximo INT, 
    VI_Size VARCHAR(100), 
    VI_fecha_ensamblaje_avion DATE, 
    VI_Estado_avion INT,
    VI_matricula VARCHAR(10) -- La matrícula se usa para identificar el avión a actualizar
)
/****** Nombre: ActualizarAvion 
Fecha:	2025/10/15
Autor:	Andres Lopez Alvarez
Objetivo: Procedimiento que actualiza un avión de la base de datos de la tabla Aviones. 	
--========================VERSIONAMIENTO==========================--
____________________________________________________________________
Versión |     Fecha    |     Autor    |   Descripción				|
________|______________|______________|_____________________________|
  1.0	    2025/10/15    Andrés Lopez   Creación de procedimiento
--================================================================-- 
******/
BEGIN
  UPDATE Aviones 
  SET 
    Referencia = VI_Referencia, 
    Aforo_maximo = VI_Aforo_maximo, 
    Size = VI_Size, 
    fecha_ensamblaje_avion = VI_fecha_ensamblaje_avion, 
    Estado_avion = VI_Estado_avion
  WHERE 
    Matricula = VI_matricula;
END$$

DELIMITER ;