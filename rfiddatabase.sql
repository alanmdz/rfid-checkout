--create database RFIDProjectDatabase

use RFIDProjectDatabase

create table department

(id integer not null identity (1,1) constraint pk_department PRIMARY KEY, 
Name varchar(30)); 

create table store
(id integer not null identity (1,1) constraint pk_store PRIMARY KEY, 
Addres varchar(100), 
Name varchar(30),
phone varchar(100)); 

create table Product
(id integer not null identity (1,1) constraint pk_Product PRIMARY KEY, 
Tag varchar(100), 
Name varchar(30),
cost  decimal (5,2),
department_SID integer,
FOREIGN KEY ( department_SID) REFERENCES department (id));


CREATE TABLE contains 
(id integer not null identity (1,1) constraint pk_contains PRIMARY KEY, 
store_sid integer,
department_SID integer, 
FOREIGN KEY (store_sid) REFERENCES store (id),
FOREIGN KEY ( department_SID) REFERENCES department (id));


