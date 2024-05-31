CREATE DATABASE prodb;

use prodb;

CREATE TABLE  Products
(
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) ,
    price DECIMAL(10, 2),
    description VARCHAR(255)
);


INSERT INTO  Products(name, price, description) values ('Apple', 1.99, 'Iphone 12');
INSERT INTO  Products(name, price, description) values ('Samsung', 1.50, 'Samsung s20 ultra');

SELECT * FROM  Products;
