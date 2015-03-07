use master
create database cadastros
use cadastros
create table Cadastros
(
	id int not null,
	nome varchar(50),
	data varchar(20),
	email varchar(100),
	endereco varchar(100),
	cidade varchar(100),
	num_telefone1 varchar(50),
	desc_telefone1 varchar(50),
	num_telefone2 varchar(50),
	desc_telefone2 varchar(50),
	num_telefone3 varchar(50),
	desc_telefone3 varchar(50)
)
alter table cadastros
add constraint PK_Cadastros primary key (id)

insert into Cadastros values()

select * from Cadastros where nome='aaa' and id = 1

delete from cadastros where id=1
select * from cadastros where id = 1
select Max(id) as 'Limite' from cadastros