# Тестовое задание для MindBox

## Задание 1

### Цель
Разработать библиотеку на C# для внешних клиентов, которая сможет вычислять площадь круга по радиусу и площадь треугольника по трем сторонам. Кроме функциональности, будут оцениваться следующие критерии:

### Требования
- **Юнит-тесты**: Реализовать полные юнит-тесты для обеспечения корректности работы библиотеки.

- **Легкость добавления других фигур**: Спроектировать библиотеку таким образом, чтобы было удобно добавлять поддержку дополнительных геометрических фигур в будущем.

- **Динамическое вычисление площади**: Реализовать метод для вычисления площади фигуры без знания типа фигуры во время компиляции.

- **Проверка на прямоугольный треугольник**: Включить функциональность для проверки, является ли треугольник прямоугольным.

### Замечания по реализации
- Использовать подходящие паттерны проектирования и интерфейсы для обеспечения расширяемости и удобства сопровождения.
- Обеспечить правильную валидацию входных данных для обработки крайних случаев (например, отрицательные значения, недопустимые стороны треугольника).

### Ожидаемые результаты
- Библиотека на C# с описанными функциональными возможностями.
- Юнит-тесты, охватывающие все критические сценарии.
- Документация для API библиотеки, включая примеры использования.

### Примеры
#### Фигура Circle
```csharp

var circle = new Circle(4.0);
var area = cicle.CalculateArea();

```
#### Фигура Triangle
```csharp

double x = 3.0, y = 4.0, z = 5.0;
var triangle = new Triangle(x, y, z);
var area = cicle.CalculateArea();

```

## Задание 2

### Цель
Разработать SQL запрос для выбора всех пар «Имя продукта – Имя категории» из базы данных MS SQL Server. Одному продукту может соответствовать много категорий, 
а в одной категории может быть много продуктов. Запрос должен возвращать имя продукта даже в том случае, если у него нет связанных категорий.

### Требования
- **Выборка данных**: Написать SQL запрос, который возвращает все пары «Имя продукта – Имя категории».
- **Обработка отсутствия категорий**: Убедиться, что продукт отображается в результате, даже если у него нет связанных категорий.

### Замечания по реализации
- Убедиться, что запрос корректно обрабатывает случаи, когда у продукта нет категорий.

### Ожидаемые результаты
- SQL запрос, который возвращает список всех продуктов с их категориями, включая продукты без категорий.
- Пример запроса, который демонстрирует правильность работы.

## Результат
| product_name | category_name |
|--------------|:-------------:|
| Product 1    |  Category 1   |
| Product 2    |  Category 1   |
| Product 3    |    <null>     |

## Создание БД

```sql
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

```

## Запрос

```sql
select p.name as product_name, c.name as category_name
FROM product p
    LEFT JOIN product_category pc on p.id = pc.product_id
    LEFT JOIN category c on pc.category_id = c.id
```
