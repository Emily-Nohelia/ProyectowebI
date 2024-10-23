Create Database NegocioBD 
use NegocioBD

Create table Producto 
(
ID_Producto INT IDENTITY(1,1) PRIMARY KEY,
    Id_Categoria INT NOT NULL,  
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(80) NULL,
    Estado BIT NOT NULL DEFAULT 1,
	);

	CREATE TABLE Usuarios (
    ID_Usuario int IDENTITY(1,1),
    Nombre nvarchar(40),
    Clave nvarchar(40),
    Rol nvarchar(40),
    Estado bit,
	);
	GO

	CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),   
    NombreRol VARCHAR(50) NOT NULL,         
    DescripcionRol VARCHAR(255) NULL,       
    Estado BIT NOT NULL DEFAULT 1,     
);
GO


CREATE TABLE Permisos (
    IdPermiso INT PRIMARY KEY IDENTITY(1,1),    
    NombrePermiso VARCHAR(50) NOT NULL,         
    DescripcionPermiso VARCHAR(255) NULL,       
    Estado BIT NOT NULL DEFAULT 1,              
);
GO

CREATE TABLE Categoria (
    ID_Categoria int IDENTITY(1,1) ,
    Nombre varchar(50),
    Descripcion nvarchar(max),
    Estado bit,
);



