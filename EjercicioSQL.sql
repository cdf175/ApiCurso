-- 1).
CREATE TABLE CURSO(
	[CodCurso] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CURSO] PRIMARY KEY CLUSTERED 
(
	[CodCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- 2).
ALTER Table CURSO ADD Cupo int NULL

-- 3).
insert into CURSO VALUES(1, 'Biologia','Curso de biologia',20)
insert into CURSO VALUES(2, 'Literatura', 'Curso de literatura', 18)
insert into CURSO VALUES(3, 'Geometria', 'Curso de geometria', 25)
insert into CURSO VALUES(4, 'Algebra', 'Curso de algebra', 32)
insert into CURSO VALUES(5, 'Ingles', 'Curso de ingles', 10)

-- 4).
delete from CURSO where cupo = (select Min(Cupo) from CURSO)

-- 5).
update CURSO set cupo = 30

-- 6).
insert into CURSO VALUES(1, 'Informatica','Curso',20)