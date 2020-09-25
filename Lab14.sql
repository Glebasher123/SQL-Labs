USE Lab4


GO
CREATE PROC Procedure_1 AS
SELECT [�������� ������], [��� ������], ����, [�������� ������]
FROM �����
JOIN ����� on �����.[ID ������] = �����.[ID ������]
WHERE ���� BETWEEN 5 AND 20

EXEC Procedure_1
DROP PROC Procedure_1

----------

GO
CREATE PROC Procedure_2 AS
SELECT [�������� ������], [��� ������], ����, [�������� ������]
FROM �����
JOIN ����� on �����.[ID ������] = �����.[� ������]
where [��� ������]>(select AVG([��� ������]) from �����)

EXEC Procedure_2
DROP PROC Procedure_2

----------

GO
CREATE PROC Procedure_3 AS
SELECT [���� �������], ����������, [���� �������], ���
FROM �������
JOIN ���������� on ����������.[� ����������] = �������.[� ����������]
where [���� �������] > (SELECT avg([���� �������]) from �������)

GO
ALTER PROC Procedure_3 AS
SELECT [���� �������], ����������, [���� �������], ���
FROM �������
JOIN ���������� on ����������.[� ����������] = �������.[� ����������]
where [���� �������] = (SELECT min([���� �������]) from �������)

EXEC Procedure_3
DROP PROC Procedure_3

----------

GO
CREATE PROC Procedure_4 AS
SELECT [�������� ���������], [�������� ������], Max([��� ������]) as '������������ ���'
FROM �����
JOIN ��������� on �����.[ID ���������] = ���������.[ID ���������]

GROUP BY [�������� ������], [�������� ���������]
HAVING Max([��� ������]) < 500

EXEC Procedure_4
DROP PROC Procedure_4

----------

GO
CREATE PROC Procedure_5 AS
SELECT [�������� ������], Min(����) as '����������� ����'
FROM �����
JOIN �������� on ��������.[� ������] = �����.[� ������]

GROUP BY [�������� ������]
HAVING Min([����]) = 7

EXEC Procedure_5
DROP PROC Procedure_5