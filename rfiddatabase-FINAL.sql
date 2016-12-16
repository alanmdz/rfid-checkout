DROP DATABASE IF EXISTS STOREDATA;
CREATE DATABASE STOREDATA;
USE STOREDATA;

CREATE TABLE Department (
    departmentID INT PRIMARY KEY,
    name VARCHAR(20)
);

CREATE TABLE Item (
    tag INT PRIMARY KEY,
    cost DOUBLE,
    description VARCHAR(20),
    departmentID INT,
    FOREIGN KEY (departmentID)
        REFERENCES Department (departmentID)
);

CREATE TABLE Store (
    storeID INT PRIMARY KEY,
    phone VARCHAR(20),
    address VARCHAR(20)
);

CREATE TABLE StoreContainsDepartment (
    storeID INT,
    departmentID INT,
    PRIMARY KEY (storeID , departmentID),
    FOREIGN KEY (storeID)
        REFERENCES Store (storeID),
    FOREIGN KEY (departmentID)
        REFERENCES Department (departmentID)
);

CREATE TABLE ItemFoundInDepartmentAtStore (
    tag INT,
    storeID INT,
    departmentID INT,
    quantity INT,
    PRIMARY KEY (tag , storeID , departmentID),
    FOREIGN KEY (tag)
        REFERENCES Item (tag),
    FOREIGN KEY (storeID , departmentID)
        REFERENCES StoreContainsDepartment (storeID , departmentID)
);

INSERT INTO Department(departmentID, name) VALUES (1000000, 'Electronics');
INSERT INTO Department(departmentID, name) VALUES (2000000, 'Outdoors');
INSERT INTO Department(departmentID, name) VALUES (3000000, 'Appliances');

INSERT INTO Item(tag, cost, departmentID, description) VALUES (123456, 24.99, 1000000, 'Anker iPhone Charger');
INSERT INTO Item(tag, cost, departmentID, description) VALUES (234322, 56.99, 2000000, 'Magellan Tent');
INSERT INTO Item(tag, cost, departmentID, description) VALUES (643242, 399.99, 3000000, 'George Foreman Grill');
INSERT INTO Item(tag, cost, departmentID, description) VALUES (324123, 600.99, 1000000, 'iPad Air');
INSERT INTO Item(tag, cost, departmentID, description) VALUES (754332, 1199.99, 1000000, 'Macbook Pro');

INSERT INTO Store(storeID, phone, address) VALUES (000001, '956-123-4568', '1235 Ware Rd.');
INSERT INTO Store(storeID, phone, address) VALUES (000002, '956-533-2328', '5223 Trenton Rd.');
INSERT INTO Store(storeID, phone, address) VALUES (000003, '956-633-4568', '2322 10th St.');
INSERT INTO Store(storeID, phone, address) VALUES (000004, '956-542-6233', '4200 Raul Longoria');

/*all 4 locations contain Electronics, Outdoors, and Appliances*/
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000001, 1000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000001, 2000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000001, 3000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000002, 1000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000002, 2000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000002, 3000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000003, 1000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000003, 2000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000003, 3000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000004, 1000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000004, 2000000);
INSERT INTO StoreContainsDepartment(storeID, departmentID) VALUES (000004, 3000000);

INSERT INTO ItemFoundInDepartmentAtStore(tag, storeID, departmentID, quantity) VALUES (643242, 000001, 3000000, 100);
INSERT INTO ItemFoundInDepartmentAtStore(tag, storeID, departmentID, quantity) VALUES (324123, 000002, 1000000, 150);
INSERT INTO ItemFoundInDepartmentAtStore(tag, storeID, departmentID, quantity) VALUES (234322, 000003, 2000000, 20);
INSERT INTO ItemFoundInDepartmentAtStore(tag, storeID, departmentID, quantity) VALUES (754332, 000004, 1000000, 200);
