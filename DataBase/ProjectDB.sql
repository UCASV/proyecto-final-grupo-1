-- Conection string
/* 
dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS;Database=GestorVaccination;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o ProjectPOOContext -f
*/
-- Creating DATABASE
CREATE DATABASE GestorVaccination;
SET LANGUAGE 'us_english';
USE GestorVaccination;
-- DROP DATABASE GestorVaccination;

-- Create Tables
CREATE TABLE CITIZEN(
DUI VARCHAR (10) PRIMARY KEY,
c_name VARCHAR (50) NOT NULL,
c_address VARCHAR (100) NOT NULL,
tel VARCHAR (9) NOT NULL,
email VARCHAR (100) NOT NULL,
age TINYINT NOT NULL,
id_institution int NULL
);

CREATE TABLE INSTITUTION(
id INT PRIMARY KEY IDENTITY,
i_name VARCHAR (50) NOT NULL
);

CREATE TABLE CHRONIC_DISEASE(
id INT PRIMARY KEY IDENTITY,
ch_name VARCHAR (50) NOT NULL
);

CREATE TABLE CITIZENXCHRONIC_DISEASE(
id_citizen VARCHAR(10) NOT NULL,
id_chronic_disease INT NOT NULL,
CONSTRAINT PK_CITIZENXCHRONIC_DISEASE PRIMARY KEY (id_citizen, id_chronic_disease)
);

CREATE TABLE TYPE_APPOINTMENT(
id INT PRIMARY KEY IDENTITY,
ta_name VARCHAR (50) NOT NULL
);

CREATE TABLE APPOINTMENT(
id INT PRIMARY KEY IDENTITY,
a_datetime DATETIME NOT NULL,
a_status BIT DEFAULT 0 NOT NULL,
start_time TIME NULL,
final_time TIME NULL,
id_type_appointment INT DEFAULT 1 NOT NULL,
id_citizen VARCHAR(10) NOT NULL,
id_employee INT NOT NULL,
id_cabin INT NOT NULL,
id_vaccination_center INT NOT NULL
);

CREATE TABLE EMPLOYEE(
id INT PRIMARY KEY IDENTITY,
e_name VARCHAR (50) NOT NULL,
email VARCHAR (100) NOT NULL,
pass VARCHAR (100) NOT NULL,
e_address VARCHAR (100) NOT NULL,
id_type_employee INT NOT NULL
);

CREATE TABLE TYPE_EMPLOYEE(
id INT PRIMARY KEY IDENTITY,
te_name VARCHAR (50) NOT NULL
);

CREATE TABLE SECONDARY_EFFECT(
id INT PRIMARY KEY IDENTITY,
se_name VARCHAR (50) NOT NULL
);

CREATE TABLE APPOINTMENTXSECONDARY_EFFECT(
id_appointment INT NOT NULL,
id_secondary_effect INT NOT NULL,
duration INT NOT NULL CHECK (duration > 0),
CONSTRAINT PK_APPOINTMENTXSECONDARY_EFFECT PRIMARY KEY (id_appointment, id_secondary_effect)
);

CREATE TABLE CENTER(
id INT PRIMARY KEY IDENTITY,
center_address VARCHAR (100) NOT NULL,
tel VARCHAR (9) NOT NULL,
center_email VARCHAR (100) NOT NULL,
id_center_type INT NOT NULL,
id_employee_in_charge INT NOT NULL
);

CREATE TABLE TYPE_CENTER(
id INT PRIMARY KEY IDENTITY,
tc_name VARCHAR (50) NOT NULL
);

CREATE TABLE EMPLOYEEXCENTER(
id INT PRIMARY KEY IDENTITY,
id_employee INT NOT NULL,
id_center INT NOT NULL,
eXc_datetime DATETIME NOT NULL
);

-- ALTER for FOREIGN KEY
	-- CITIZEN TABLE 
	ALTER TABLE CITIZEN ADD FOREIGN KEY (id_institution) REFERENCES INSTITUTION (id);

	-- CITIZENXCHRONIC_DISEASE TABLE (N:N)
	ALTER TABLE CITIZENXCHRONIC_DISEASE ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN (DUI);
	ALTER TABLE CITIZENXCHRONIC_DISEASE ADD FOREIGN KEY (id_chronic_disease) REFERENCES CHRONIC_DISEASE (id);

	-- APPOINTMENT TABLE
	ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_type_appointment) REFERENCES TYPE_APPOINTMENT (id);
	ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN (DUI);
	ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id);
	ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_cabin) REFERENCES CENTER (id);
	ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_vaccination_center) REFERENCES CENTER (id);

	-- APPOINTMENTXSECONDARY_EFFECT TABLE (N:N)
	ALTER TABLE APPOINTMENTXSECONDARY_EFFECT ADD FOREIGN KEY (id_appointment) REFERENCES APPOINTMENT (id);
	ALTER TABLE APPOINTMENTXSECONDARY_EFFECT ADD FOREIGN KEY (id_secondary_effect) REFERENCES SECONDARY_EFFECT (id);

	-- CENTER TABLE 
	ALTER TABLE CENTER ADD FOREIGN KEY (id_center_type) REFERENCES TYPE_CENTER (id);
	ALTER TABLE CENTER ADD FOREIGN KEY (id_employee_in_charge) REFERENCES EMPLOYEE (id);

	-- EMPLOYEEXCENTER TABLE (N:N)
	ALTER TABLE EMPLOYEEXCENTER ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id);
	ALTER TABLE EMPLOYEEXCENTER ADD FOREIGN KEY (id_center) REFERENCES CENTER (id);

	-- EMPLOYEE TABLE
	ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_type_employee) REFERENCES TYPE_EMPLOYEE (id)

-- INSERT default data
-- TABLES of TYPES
INSERT INTO TYPE_EMPLOYEE VALUES('Gestor de cabina'); -- ID 1
INSERT INTO TYPE_EMPLOYEE VALUES('Administrador de cabina'); -- ID 2
INSERT INTO TYPE_EMPLOYEE VALUES('Gestor de centro de vacunación'); -- ID 3
INSERT INTO TYPE_EMPLOYEE VALUES('Administrador de centro de vacunación'); -- ID 4

INSERT INTO TYPE_CENTER VALUES('Cabina'); -- ID 1
INSERT INTO TYPE_CENTER VALUES('Centro de vacunación'); -- ID 2

INSERT INTO TYPE_APPOINTMENT VALUES('Primera cita'); -- ID 1
INSERT INTO TYPE_APPOINTMENT VALUES('Segunda cita'); -- ID 2

-- INSERT to Main Entities

-- EMPLOYEES
-- Cabin Employees in Charge
INSERT INTO EMPLOYEE VALUES(  -- ID 1
'Carlos Mercado',
'CarlosMercado@gmail.com',
'Merca',
'La Cima 4, Polígono #6, Casa #40, San Salvador',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 2
'Daniel Solis',
'dsolismarroquin@gmail.com',
'Daniel',
'Urb. Sinaí, Av. 1, Polígono #6, Casa #65, Santa Ana',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 3
'Jose Acosta',
'JoseAcosta@gmail.com',
'12345',
'Linda vista, Av. 4, Polígono #3, Casa #5, Santa Tecla',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 4
'Rodrigo Aguirre',
'RodrigoAguirre@gmail.com',
'00000',
'Urb. Casitas de pollo, Av. 4, Polígono #10, Casa #2, Armenia',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 5
'Paco Flores',
'Paquito@gmail.com',
'11111',
'Col. Piedraz Azules, Calle 3, Polígono #2, Casa #1, Candelaria de la Frontera',
2
);
-- Vaccinate_Center Employees in Charge
INSERT INTO EMPLOYEE VALUES(  -- ID 6
'Mayra Gonzalez',
'MayraGonzalez@gmail.com',
'1314713',
'Urb. Los Pinos, Av. 2, Polígono #2, Casa #25, Santa Ana',
4
);
INSERT INTO EMPLOYEE VALUES(  -- ID 7
'Leonardo Torres',
'LeoTorres@gmail.com',
'54321',
'Urb. Los Flores Blancas, Calle Principal, Polígono #1, Casa #45, Chalatenango',
4
);

-- Cabin Employees 
INSERT INTO EMPLOYEE VALUES(  -- ID 8
'Cristiano Ronaldo',
'cr7@gmail.com',
'elbicho',
'Urb. Las abejas, San Salvador',
2
);

-- Vaccinate_Center Employees 
INSERT INTO EMPLOYEE VALUES(  -- ID 9
'Sofia Reyes',
'sofia@gmail.com',
'12345',
'Urb. Las manzanas, Santa Tecla',
3
);

-- INSTITUTIONS
INSERT INTO INSTITUTION (i_name) VALUES ('Educación');
INSERT INTO INSTITUTION (i_name) VALUES ('Salud');
INSERT INTO INSTITUTION (i_name) VALUES ('Policia nacional civil');
INSERT INTO INSTITUTION (i_name) VALUES ('Fuerza armada');
INSERT INTO INSTITUTION (i_name) VALUES ('Gobierno');
INSERT INTO INSTITUTION (i_name) VALUES ('Periodismo');

-- DISEASES
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Diabetes');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Asma - moderada a grave');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('hipertensión pulmonar');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('EPOC');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Sobrepeso y obesidad');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Insuficiencia cardiaca');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Hipertensión');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Síndrome de Down');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('VIH');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Enfermedad renal crónica');

-- SECONDARY EFFECTS
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Hinchazón');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Cansancio'); 
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Dolor de cabeza');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Dolor muscular');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Escalofríos');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Náuseas');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Diarrea');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Inflamación de los ganglios linfáticos');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Anafilaxia');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('trombosis-trombocitopenia (TTS)');

-- CENTER (CABIN o VACCINATION_CENTER)
-- INSERT CABIN
INSERT INTO CENTER VALUES (
'La Palma, Chalatenango',
'2245-9089',
'LaPalmaCH_Cabina@gmail.com',
1,
1
);
INSERT INTO CENTER VALUES (
'El trebol, Santa Ana, Santa Ana',
'2525-2525',
'TrebolSA_Cabina@gmail.com',
1,
2
);
INSERT INTO CENTER VALUES (
'Colonia San Jose, Santa Tecla',
'2257-7777',
'SanJoseST_Cabina@gmail.com',
1,
3
);
INSERT INTO CENTER VALUES (
'Concepcion de Ataco, Ahuachapan',
'2222-7777',
'AtacoAHU_Cabina@gmail.com',
1,
4
);
INSERT INTO CENTER VALUES (
'Surf City, La Libertad',
'2237-8090',
'SurfCityLL_CentroVacunacion@gmail.com',
2,
5
);
-- INSERT VACCINATION_CENTER
INSERT INTO CENTER VALUES (
'La Gran Via - Parqueo Este, Antiguo Cuscatlán',
'2110-9567',
'LaGranViaAC_CentroVacunacion@gmail.com',
2,
6
);
INSERT INTO CENTER VALUES (
'Hospital El Salvador - CIFCO, San Salvador',
'2134-1134',
'Hospital_ElSalvadorSS_CentroVacunacion@gmail.com',
2,
7
);

-- Pruebas
SELECT * FROM EMPLOYEE;
SELECT * FROM CENTER;
SELECT * FROM CHRONIC_DISEASE;
SELECT * FROM SECONDARY_EFFECT;
SELECT * FROM INSTITUTION;

SELECT * FROM CITIZEN;
SELECT * FROM CITIZENXCHRONIC_DISEASE;

SELECT * FROM APPOINTMENT;
SELECT * FROM APPOINTMENTXSECONDARY_EFFECT;

-- Pruebas complejas
SELECT C.c_name, D.ch_name
FROM CITIZEN c, CITIZENXCHRONIC_DISEASE CD, CHRONIC_DISEASE D
WHERE C.DUI = CD.id_citizen 
	AND CD.id_chronic_disease = D.id;