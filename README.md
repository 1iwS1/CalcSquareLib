# Тестовое задание
## 1) Библиотека на C#
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Дополнительные критерии:
 - **Юнит тесты** (находятся в папке https://github.com/1iwS1/CalcSquareLib/tree/main/CalcSquareLibTests)
 - **Легкость добавления других фигур.** Момент на самом деле субъктивный. На мой взгляд я реализовал довольно простую возможность добавить новую фигуру (по крайней мере, простую в понимании: сложно ошибиться):
Создать класс новой фигуры, унаследовав его от интерфейса IShape и реализовав в нем метод подсчета площади, а после добавить static метод в CalcSquareUsage для обращения к этой фигуре.
 - **Вычисление площади фигуры без знания типа фигуры в compile-time**. Реализуется благодаря интерфейсу IShape.
 - **Проверку на то, является ли треугольник прямоугольным**. Реализуется вызовом соответствующего метода.

Папка с библиотекой - https://github.com/1iwS1/CalcSquareLib/tree/main/CalcSquareLib

## 2) SQL задание
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Ниже представлены все запросы: создания таблиц Продукта, Категории и их Совместной таблицы, затем заполнение тестовыми данными и сам запрос на выборку пар "Имя продукта – Имя категории".
```
CREATE TABLE Products (
  id int primary key identity,
  name varchar(255) not null
);

CREATE TABLE Categories (
  id int primary key identity,
  name varchar(255)
);

CREATE TABLE PrCt (
  product_id int references Products(id) on delete CASCADE,
  category_id int references Categories(id) on delete CASCADE
);

INSERT INTO Products VALUES('Paper'), ('Scisors'), ('Spoon'), ('BMW'), ('Audi');
INSERT INTO Categories VALUES('Office'), ('Cutlery'), ('Metal'), ('');
INSERT INTO PrCt VALUES(1, 1), (2, 1), (3, 2), (3, 3), (4, 4), (5, 4);

SELECT Products.name AS product, Categories.name AS category FROM Products
LEFT JOIN PrCt ON Products.id = PrCt.product_id
JOIN Categories ON Categories.id = PrCt.category_id
ORDER BY product;
```



# Test Assignment
## 1) C# library
Write a C# library for delivery to external clients that can calculate the area of a circle by radius and of a triangle by three sides.

Additional criteria:
 - **Unit tests** (found in the https://github.com/1iwS1/CalcSquareLib/tree/main/CalcSquareLibTests folder)
 - **Ease of adding other shapes.** The point is actually subjctive. In my opinion, I have implemented a fairly easy way to add a new shape (at least easy to understand: hard to get wrong):
Create a new shape class, inheriting it from the IShape interface and implementing an area calculation method in it, and then add a static method in CalcSquareUsage to refer to that shape.
 - **Calculating the area of a shape without knowing the shape type in compile-time**. This is implemented thanks to the IShape interface.
 - **Check if a triangle is rectangular**. It is realized by calling the corresponding method.

The folder with the library is https://github.com/1iwS1/CalcSquareLib/tree/main/CalcSquareLib.

## 2) SQL task
In MS SQL Server database there are products and categories. One product can have many categories, one category can have many products.
Write a SQL query to select all the “Product Name - Category Name” pairs. If a product has no categories, its name should still be displayed.

Below are all the queries: creating the Product, Category and their Joint table, then populating with test data and the query itself to select the “Product Name - Category Name” pairs.
```
CREATE TABLE Products (
  id int primary key identity,
  name varchar(255) not null
);

CREATE TABLE Categories (
  id int primary key identity,
  name varchar(255)
);

CREATE TABLE PrCt (
  product_id int references Products(id) on delete CASCADE,
  category_id int references Categories(id) on delete CASCADE
);

INSERT INTO Products VALUES('Paper'), ('Scisors'), ('Spoon'), ('BMW'), ('Audi');
INSERT INTO Categories VALUES('Office'), ('Cutlery'), ('Metal'), ('');
INSERT INTO PrCt VALUES(1, 1), (2, 1), (3, 2), (3, 3), (4, 4), (5, 4);

SELECT Products.name AS product, Categories.name AS category FROM Products
LEFT JOIN PrCt ON Products.id = PrCt.product_id
JOIN Categories ON Categories.id = PrCt.category_id
ORDER BY product;
```
