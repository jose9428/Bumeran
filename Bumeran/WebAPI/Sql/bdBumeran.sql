use master
go

create database bdBumeran
go

use bdBumeran
go

create table Publicacion(
	id_publicacion int identity primary key,
	Puesto varchar(120) ,
	Descrip varchar(300), --descripcion
	idDepartamento varchar(10),
    Departamento varchar(80),
    Distrito varchar(80),
    Lugar varchar(180), --direccion de trabajo
    Area varchar(80),
    Jerarquia varchar(80), -- senior o junior 
    sueldo decimal(8,2),
    NomEmpresa varchar(80),
    Tipempleo  varchar(80), --part time o fulltime
    Modalidad  varchar(20),  -- presencial o virtual
    vacantes    int,
	Habilidades Varchar(120) 
)
go


create table Postulante(
	    id_postulante int identity primary key,
	    nombre varchar(60), 
	    apellido varchar(70),
        nacionalidad varchar(40),
        fechaNacimiento date,
        genero varchar(20),
	    dni varchar(8), 
        direccion varchar(120),
	    celular varchar(12),
        foracademica varchar(50), --//formacion academica
        idioma varchar(30),
        salario decimal(8,2),
        expericencia varchar(120),
        Conocimientos varchar(120) 
)
go


