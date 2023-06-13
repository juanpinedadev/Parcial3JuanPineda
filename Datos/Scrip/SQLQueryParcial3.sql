CREATE DATABASE Parcial3JP
GO

USE Parcial3JP
GO

-- Creamos las tablas
CREATE TABLE Sede
(
    IdSede VARCHAR(3) PRIMARY KEY,
    Nombre VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Producto
(
    CodigoProducto VARCHAR(4) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
	Valor DECIMAL(10,2)
);

CREATE TABLE Venta
(
    IdSede VARCHAR(3),
    CodigoProducto VARCHAR(4),
    Valor DECIMAL(10,2),
    FOREIGN KEY (IdSede) REFERENCES Sede(IdSede),
    FOREIGN KEY (CodigoProducto) REFERENCES Producto(CodigoProducto)
);


INSERT INTO Sede (IdSede, Nombre) VALUES  ('001', 'Sede Norte');
INSERT INTO Sede (IdSede, Nombre) VALUES  ('002', 'Sede Sur');
INSERT INTO Sede (IdSede, Nombre) VALUES  ('003', 'Sede Centro');


INSERT INTO Producto (CodigoProducto, Nombre, Valor) VALUES ('P001', 'Juego de sala', 1000000);
INSERT INTO Producto (CodigoProducto, Nombre, Valor) VALUES ('P002', 'Juego de Comedor', 1200000);
INSERT INTO Producto (CodigoProducto, Nombre, Valor) VALUES ('P003', 'Nevera ', 800000);
INSERT INTO Producto (CodigoProducto, Nombre, Valor) VALUES ('P004', 'Estufa', 500000);
