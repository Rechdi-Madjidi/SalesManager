USE [C:\USERS\BOU\DESKTOP\SALESMANAGER\BIN\DEBUG\SDB.MDF]
GO

CREATE TABLE login_program(
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	is_active bit NULL,
)
CREATE TABLE bg_font_Setting(
	r int NULL,
	g int NULL,
	b int NULL,
	fs int NULL
	) 
CREATE TABLE category(
	category_num int primary key,
	category_name varchar(70) NULL,
    category_detail varchar(max)
)
CREATE TABLE employee(
	employee_num int primary key,
	employee_name varchar(150) not NULL,
    gender varchar(10) not NULL,
	address varchar(200)not NULL,
	id_num varchar(25)UNIQUE,
	birth_date date,
	qualification varchar(250),
	employee_state varchar(100)
)
create table employee_phone(
employee_num int,
employee_phone varchar(50),
primary key(employee_num,employee_phone),
foreign key(employee_num)references employee(employee_num)
);
create table employee_image(
employee_num int primary key,
employee_image image,
foreign key(employee_num)references employee(employee_num)
);



