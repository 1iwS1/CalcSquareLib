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
