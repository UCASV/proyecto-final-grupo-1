-- Grupo #1
-- Integrantes
-- Carlos Eduardo Mercado Guti?rrez	-	00058820
-- Daniel Vladimir Solis Marroquin	-	00209020
-- Jos? Miguel Acosta V?squez		-	00008020
-- Rodrigo Jose Aguirre Arevalo		-	00004120

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
INSERT INTO TYPE_EMPLOYEE VALUES('Gestor de centro de vacunaci?n'); -- ID 3
INSERT INTO TYPE_EMPLOYEE VALUES('Administrador de centro de vacunaci?n'); -- ID 4
INSERT INTO TYPE_EMPLOYEE VALUES('Administrador general'); -- ID 5

INSERT INTO TYPE_CENTER VALUES('Cabina'); -- ID 1
INSERT INTO TYPE_CENTER VALUES('Centro de vacunaci?n'); -- ID 2

INSERT INTO TYPE_APPOINTMENT VALUES('Primera cita'); -- ID 1
INSERT INTO TYPE_APPOINTMENT VALUES('Segunda cita'); -- ID 2

-- INSERT to Main Entities

-- EMPLOYEES
-- Cabin Employees in Charge
INSERT INTO EMPLOYEE VALUES(  -- ID 1
'Carlos Mercado',
'carlos@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'La Cima 4, Pol?gono #6, Casa #40, San Salvador',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 2
'Daniel Solis',
'dsolismarroquin@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Sina?, Av. 1, Pol?gono #6, Casa #65, Santa Ana',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 3
'Jose Acosta',
'acosta@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Linda vista, Av. 4, Pol?gono #3, Casa #5, Santa Tecla',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 4
'Rodrigo Aguirre',
'rodrigo@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Casitas de pollo, Av. 4, Pol?gono #10, Casa #2, Armenia',
2
);
INSERT INTO EMPLOYEE VALUES(  -- ID 5
'Paco Flores',
'paquito@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Col. Piedraz Azules, Calle 3, Pol?gono #2, Casa #1, Candelaria de la Frontera',
2
);
-- Vaccinate_Center Employees in Charge
INSERT INTO EMPLOYEE VALUES(  -- ID 6
'Mayra Gonzalez',
'mayragonzalez@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Los Pinos, Av. 2, Pol?gono #2, Casa #25, Santa Ana',
4
);
INSERT INTO EMPLOYEE VALUES(  -- ID 7
'Leonardo Torres',
'leo@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Los Flores Blancas, Calle Principal, Pol?gono #1, Casa #45, Chalatenango',
4
);

-- Cabin Employees 
INSERT INTO EMPLOYEE VALUES(  -- ID 8
'Cristiano Ronaldo',
'cr7@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Las abejas, San Salvador',
1
);

-- Vaccinate_Center Employees 
INSERT INTO EMPLOYEE VALUES(  -- ID 9
'Sofia Reyes',
'sofia@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Las manzanas, Santa Tecla',
3
);

-- General administrator 
INSERT INTO EMPLOYEE VALUES(  -- ID 10
'Leonel Messi',
'messi@gmail.com',
'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5',
'Urb. Los aguacates',
5
);

-- INSTITUTIONS
INSERT INTO INSTITUTION (i_name) VALUES ('Educaci?n');
INSERT INTO INSTITUTION (i_name) VALUES ('Salud');
INSERT INTO INSTITUTION (i_name) VALUES ('Policia nacional civil');
INSERT INTO INSTITUTION (i_name) VALUES ('Fuerza armada');
INSERT INTO INSTITUTION (i_name) VALUES ('Gobierno');
INSERT INTO INSTITUTION (i_name) VALUES ('Periodismo');

-- DISEASES
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Diabetes');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Asma');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('EPOC');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Obesidad');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Enfermedad cardio vascular');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Hipertensi?n arterial');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Hepatopat?as cr?nicas');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Enfermedad renal cr?nica');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('VIH');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('C?ncer');
INSERT INTO CHRONIC_DISEASE (ch_name) VALUES ('Trasplante de ?rganos');

-- SECONDARY EFFECTS
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Hinchaz?n');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Cansancio'); 
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Dolor de cabeza');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Dolor muscular');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Escalofr?os');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('N?useas');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Diarrea');
INSERT INTO SECONDARY_EFFECT (se_name) VALUES ('Inflamaci?n de los ganglios linf?ticos');
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
1,
5
);

-- INSERT VACCINATION_CENTER
INSERT INTO CENTER VALUES (
'La Gran Via - Parqueo Este, Antiguo Cuscatl?n',
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

-- INSERT USERS AND APPOINTMETNS
-- Citizen
INSERT INTO CITIZEN VALUES (
	'12345678-9',
	'Miguel Angel',
	'Casa del maestro splinter',
	'2287-4555',
	'miguelangel@gmail.com',
	35,
	1
);

-- Citizen diseases
INSERT INTO CITIZENXCHRONIC_DISEASE VALUES ('12345678-9', 4);

-- Citizen first date
INSERT INTO APPOINTMENT VALUES (
	'2021-07-02 07:00:00.000',
	1,
	'07:15:00',
	'08:30:00',
	1,
	'12345678-9',
	1,
	5,
	6
);

-- Citizen first date secondary effects
INSERT INTO APPOINTMENTXSECONDARY_EFFECT VALUES (1, 1, 10);
INSERT INTO APPOINTMENTXSECONDARY_EFFECT VALUES (1, 2, 45);

-- Citizen second date pending
INSERT INTO APPOINTMENT VALUES (
	'2021-08-13 07:00:00.000',
	0,
	null,
	null,
	2,
	'12345678-9',
	1,
	6,
	6
);


-- Pruebas
SELECT * FROM TYPE_EMPLOYEE; 
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

-- Connection string
/* 
dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS;Database=GestorVaccination;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o ProjectPOOContext -f
*/
