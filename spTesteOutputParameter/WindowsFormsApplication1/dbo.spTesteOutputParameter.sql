if exists(select * from sys.all_objects where name = 'spTesteOutputParameter')
	drop procedure spTesteOutputParameter
go
CREATE PROCEDURE spTesteOutputParameter
	@Char varchar(1),
	@Retorno varchar(255) output
AS
BEGIN
	if(lower(@Char)between 'a' and 'z')
	begin
		set @Retorno = 'Retornado: '+UPPER(@Char)
	end
	select @Retorno Retorno
END
GO
