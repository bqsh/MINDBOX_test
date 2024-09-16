CREATE TABLE IF NOT EXISTS product
(
    id   INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS category
(
    id   INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS product_category
(
    id          INT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    category_id INT,
    product_id  INT,
    CONSTRAINT product_category_category_id_fk FOREIGN KEY (category_id) REFERENCES category (id),
    CONSTRAINT product_category_product_id_fk FOREIGN KEY (product_id) REFERENCES product (id)
);

INSERT INTO product (name) VALUES ('Product 1');
INSERT INTO product (name) VALUES ('Product 2');
INSERT INTO product (name) VALUES ('Product 3');

INSERT INTO category (name) VALUES ('Category 1');
INSERT INTO category (name) VALUES ('Category 2');
INSERT INTO category (name) VALUES ('Category 3');


INSERT INTO product_category (category_id, product_id) VALUES (1, 1);
INSERT INTO product_category (category_id, product_id) VALUES (1, 2);
INSERT INTO product_category (category_id, product_id) VALUES (3, 3);
