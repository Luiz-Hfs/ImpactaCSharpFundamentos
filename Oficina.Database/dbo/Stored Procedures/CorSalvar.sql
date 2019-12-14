
create proc CorSalvar 
	@nome nvarchar(200)
as
insert Cor 
(Nome)
output inserted.Id
Values 
(@nome)