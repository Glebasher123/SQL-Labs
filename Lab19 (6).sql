use Lab4
drop table �����
--����� � ������� ����������
TRUNCATE TABLE �����
BEGIN TRAN 
	insert into ����� ([�������� ������], [��� ������], [����]) values ('������ ���������', 1000, 54) 
	insert into ����� ([�������� ������], [��� ������], [����]) values ('������ ���������', 350, 32)
	insert into ����� ([�������� ������], [��� ������], [����]) values ('������� ���������', 300, 7)
go
select @@TRANCOUNT As ��������_����������
rollback tran

SELECT * FROM �����

--������������ ����������
print '���������� 1: ' + cast(@@TRANCOUNT as Char(1))

begin tran qwe
print '����� ���������� 1: ' + cast(@@TRANCOUNT as Char(1))
	insert into ����� ([�������� ������], [��� ������], [����]) values ('������ ���������', 1000, 54)

begin tran qwe1
print '���������� 2: ' + cast(@@TRANCOUNT as char(1))
	insert into ����� ([�������� ������], [��� ������], [����]) values ('������ ���������', 1000, 54)

commit tran
print '�������� ���������� 1: ' + cast(@@TRANCOUNT as char(1))

commit tran
print '���������� 1: ' + cast(@@TRANCOUNT as Char(1))

-- �������

CREATE FUNCTION Postavka(@���������� int)  
RETURNS int   
AS   
BEGIN   
    SELECT @���������� = @���������� + 5
    RETURN @����������;  
END; 

select dbo.Postavka(2001);
