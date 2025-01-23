-- Crear la base de datos
CREATE DATABASE RegistroPersonas;
GO

-- Usar la base de datos
USE RegistroPersonas;
GO

-- Tabla principal para personas
CREATE TABLE Personas (
    DocumentoIdentidad NVARCHAR(20) PRIMARY KEY, -- Llave primaria
    Nombres NVARCHAR(100) NOT NULL,             -- Nombres obligatorios
    Apellidos NVARCHAR(100) NOT NULL,           -- Apellidos obligatorios
    FechaNacimiento DATE NOT NULL               -- Fecha de nacimiento obligatoria
);
GO

-- Tabla para n�meros telef�nicos
CREATE TABLE Telefonos (
    IdTelefono INT IDENTITY(1,1) PRIMARY KEY,   -- Llave primaria
    DocumentoIdentidad NVARCHAR(20) NOT NULL,  -- Relaci�n con la tabla Personas
    Telefono NVARCHAR(15) NOT NULL,            -- Tel�fono
    FOREIGN KEY (DocumentoIdentidad) REFERENCES Personas(DocumentoIdentidad) ON DELETE CASCADE
);
GO

-- Tabla para correos electr�nicos
CREATE TABLE Correos (
    IdCorreo INT IDENTITY(1,1) PRIMARY KEY,     -- Llave primaria
    DocumentoIdentidad NVARCHAR(20) NOT NULL,  -- Relaci�n con la tabla Personas
    Correo NVARCHAR(100) NOT NULL,             -- Correo electr�nico
    FOREIGN KEY (DocumentoIdentidad) REFERENCES Personas(DocumentoIdentidad) ON DELETE CASCADE
);
GO

-- Tabla para direcciones f�sicas
CREATE TABLE Direcciones (
    IdDireccion INT IDENTITY(1,1) PRIMARY KEY, -- Llave primaria
    DocumentoIdentidad NVARCHAR(20) NOT NULL, -- Relaci�n con la tabla Personas
    Direccion NVARCHAR(200) NOT NULL,         -- Direcci�n f�sica
    FOREIGN KEY (DocumentoIdentidad) REFERENCES Personas(DocumentoIdentidad) ON DELETE CASCADE
);
GO
