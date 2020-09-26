use Lab4

GO
Create trigger Count_���� on �����
after insert
as
if UPDATE(����)
begin
	declare @���� int
	set @���� = (select ���� from inserted)
	if @���� > 15
		begin
		rollback tran
		print '���� ������ 15'
	end 
end

insert into ����� ([�������� ������], [��� ������], [����], [ID ���������], [ID ������]) values ('������� ������', 1000, 14, 5, 2) 
insert into ����� ([�������� ������], [��� ������], [����], [ID ���������], [ID ������]) values ('������� �����', 350, 16, 4, 2)

GO
Create trigger ����������_�������� on ��������
after insert
as
if UPDATE(����������)
begin
	declare @Counter int
	set @Counter = (select ���������� from inserted)
	if @Counter < 500
		begin
		rollback tran
		print '���������� �������� ������ 500'
	end 
end

insert into �������� ([����������], [���� ��������], [ID ����������], [� ������]) values (700, '2020-01-02', 1, 2)
insert into �������� ([����������], [���� ��������], [ID ����������], [� ������]) values (400, '2020-02-04', 1, 2)

GO
Create trigger ����_�������� on ��������
after delete
as
begin
	print '�� ������� ���� ��������'
end

delete from �������� where [���� ��������]='2020-01-02'

GO
Create trigger ������������_���������� on ���������
after delete
as
begin
	print '�� ������� ������ ����������'
end

delete from ��������� where [ID ����������]=2

GO
Create trigger ��� on ���������
after update
as
begin
	print '�� �������� ��� ��������'
end

update ��������� set [�������� ���������]='�����' where [�������� ���������]='�����'