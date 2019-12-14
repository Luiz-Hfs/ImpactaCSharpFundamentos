create proc CorLer 
	@id int 
as
Select Id, Nome from Cor where Id = @Id