use Lab9

Select [Название склада],[Название товара], [Вес товара]
from [Склад]
            join [Товар] on [Склад].[ID Склада]=[Товар].[ID Склада]

			where [Вес товара]>(select AVG([Вес товара]) from Товар)

Select [ФИО], [Дата Продажи], [Количество], [Цена продажи]
from [Покупатель]
				join [Продажи] on [Покупатель].[№ Покупателя]=[Продажи].[№ Покупателя]

				where [Цена продажи]=(select min([Цена продажи]) from Продажи)

Select [Название склада],[Название товара], [Вес товара], Цена
from [Склад]
            join [Товар] on [Склад].[ID Склада]=[Товар].[ID Склада]

			where Цена=(select max(Цена) from Товар)

Select p.Наименование, p.Телефон, Количество, [Дата Поставки],[Название товара], [Вес товара]
from (select * from [Поставщик]) p
				join [Поставка] on p.[ID Поставщика]=Поставка.[ID Поставщика]
				join [Товар] on [Поставка].[№ товара] = Товар.[№ товара]


Select s.[Название склада],[Название товара], [Вес товара], [Название категории]
from (select * from [Склад]) s
            join [Товар] on s.[ID Склада]=[Товар].[ID Склада]
			join [Категория] on Категория.[ID Категории] = Товар.[ID Категории]


Select k.[Название склада],[Название товара], [Вес товара]
from (select * from [Склад]) k
            join [Товар] on k.[ID Склада]=[Товар].[ID Склада]

			where [Вес товара]>(select AVG([Вес товара]) from Товар)


Select [ФИО], (select max([Цена продажи]) from Продажи) AS 'Минимальная цена', Количество
from [Покупатель]
				join [Продажи] on [Покупатель].[№ Покупателя]=[Продажи].[№ Покупателя]



Select Наименование, Телефон, (select min([Вес товара]) from Товар) as 'Минимальный вес', [Название товара], Количество
from [Поставщик]
				join [Поставка] on [Поставщик].[ID Поставщика]=Поставка.[ID Поставщика]
				join [Товар] on [Поставка].[№ товара] = Товар.[№ товара]

Select [Название склада],[Название товара], [Вес товара], [Название категории], Продажи.Количество [Дата Продажи], (select max([Цена продажи]) from Продажи) as 'Максимальная цена', ФИО, Поставка.Количество, [Дата Поставки], Наименование, Телефон
from [Склад]
			join [Товар] on [Склад].[ID Склада]=[Товар].[ID Склада]
			join [Категория] on Категория.[ID Категории] = Товар.[ID Категории]
			join [Продажи] on Товар.[№ товара] = Продажи.[№ товара]
			join [Покупатель] on Продажи.[№ Покупателя] = Покупатель.[№ Покупателя]
			join [Поставка] on Товар.[№ товара] = Поставка.[№ товара]
			join [Поставщик] on Поставка.[ID Поставщика] = Поставщик.[ID Поставщика]

