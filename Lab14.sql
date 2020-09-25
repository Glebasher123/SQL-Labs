USE Lab4


GO
CREATE PROC Procedure_1 AS
SELECT [Название товара], [Вес товара], Цена, [Название склада]
FROM Товар
JOIN Склад on Склад.[ID Склада] = Товар.[ID Склада]
WHERE Цена BETWEEN 5 AND 20

EXEC Procedure_1
DROP PROC Procedure_1

----------

GO
CREATE PROC Procedure_2 AS
SELECT [Название товара], [Вес товара], Цена, [Название склада]
FROM Товар
JOIN Склад on Склад.[ID Склада] = Товар.[№ товара]
where [Вес товара]>(select AVG([Вес товара]) from Товар)

EXEC Procedure_2
DROP PROC Procedure_2

----------

GO
CREATE PROC Procedure_3 AS
SELECT [Дата Продажи], Количество, [Цена продажи], ФИО
FROM Продажи
JOIN Покупатель on Покупатель.[№ Покупателя] = Продажи.[№ Покупателя]
where [Цена продажи] > (SELECT avg([Цена продажи]) from Продажи)

GO
ALTER PROC Procedure_3 AS
SELECT [Дата Продажи], Количество, [Цена продажи], ФИО
FROM Продажи
JOIN Покупатель on Покупатель.[№ Покупателя] = Продажи.[№ Покупателя]
where [Цена продажи] = (SELECT min([Цена продажи]) from Продажи)

EXEC Procedure_3
DROP PROC Procedure_3

----------

GO
CREATE PROC Procedure_4 AS
SELECT [Название категории], [Название товара], Max([Вес товара]) as 'Максимальный вес'
FROM Товар
JOIN Категория on Товар.[ID Категории] = Категория.[ID Категории]

GROUP BY [Название товара], [Название категории]
HAVING Max([Вес товара]) < 500

EXEC Procedure_4
DROP PROC Procedure_4

----------

GO
CREATE PROC Procedure_5 AS
SELECT [Название товара], Min(Цена) as 'Минимальная цена'
FROM Товар
JOIN Поставка on Поставка.[№ товара] = Товар.[№ товара]

GROUP BY [Название товара]
HAVING Min([Цена]) = 7

EXEC Procedure_5
DROP PROC Procedure_5