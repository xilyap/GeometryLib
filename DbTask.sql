/*
В базе данных MS SQL Server есть продукты и категории. Одному продукту 
может соответствовать много категорий, в одной категории может быть 
много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта –
 Имя категории». Если у продукта нет категорий, то его имя все равно 
должно выводиться.

*/

-- Инициализация БД
CREATE TABLE Products(
	Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(255)
)
CREATE TABLE Category(
	Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(255)
)
CREATE TABLE ProductCategory(
	ProductId int NOT NULL,
	CategoryId int NOT NULL,
	CONSTRAINT FK_ProductCategory_CategoryId FOREIGN KEY(CategoryId) REFERENCES Category(Id) ON DELETE CASCADE,
	CONSTRAINT FK_ProductCategory_ProductId FOREIGN KEY(ProductId) REFERENCES Products(Id) ON DELETE CASCADE
)


INSERT INTO Products (Name) VALUES ('Ручка'), ('Карандаш'), ('Ластик'), ('Телефон'), ('Аккумулятор'), ('Маска'), ('Лист тефлона')
INSERT INTO Category (Name) VALUES ('Канцтовары'), ('Мебель'), ('Материалы'), ('Электроника'), ('Взрывоопасные'), ('Косметика'), ('Одежда')
INSERT INTO ProductCategory (ProductId, CategoryId) VALUES (1,1), (1,2), (2,1), (3,1), (4, 4)

-- Требуемый запрос
SELECT p.Name, c.Name FROM Products p 
	LEFT OUTER JOIN ProductCategory pk ON p.Id = pk.ProductId 
	LEFT JOIN Category c ON pk.CategoryId = c.Id ORDER BY p.Id

