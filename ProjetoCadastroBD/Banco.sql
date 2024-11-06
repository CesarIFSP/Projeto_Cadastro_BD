CREATE DATABASE IF NOT EXISTS academico;

USE	academico;

CREATE TABLE IF NOT EXISTS aluno
(
	id int not null auto_increment,
	matricula varchar(15) not null,
	dt_nascimento datetime not null,
	nome varchar(80) not null,
	endereco varchar(80) not null,
	bairro varchar(80) not null,
	cidade varchar(80) not null,
	estado varchar(02) not null,
	senha varchar(20) not null,
	primary key (id)
)

CREATE TABLE IF NOT EXISTS curso
(
	id int not null auto_increment,
	codigo varchar(15) not null,
	nome varchar(80) not null,
	nivel varchar(80) not null,
	periodo varchar(80) not null,
	area varchar(80) not null,
	duracao varchar(80) not null,
	primary key (id)
);