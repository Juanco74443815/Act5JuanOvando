CREATE DATABASE Actividad5

CREATE TABLE Venta (
    IdVenta INT IDENTITY(1,1) NOT NULL,
    FechaVenta DATE NOT NULL,
    TotalVenta DECIMAL(10, 2)NOT NULL,
	PRIMARY KEY (IdVenta)
);

CREATE TABLE Producto (
    IDProducto INT IDENTITY(1,1) NOT NULL,
    NombreProducto NVARCHAR(100) NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (IDProducto)
);

CREATE TABLE DetalleVenta (
    IDDetalleVenta INT IDENTITY(1,1) NOT NULL,
    IDVenta INT NOT NULL,
    IDProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    TotalDetalle DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (IDDetalleVenta),
    FOREIGN KEY (IDVenta) REFERENCES Venta(IdVenta),
    FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto)
);

INSERT INTO Venta (FechaVenta, TotalVenta)
VALUES 
    ('2023-04-01', 150.00),
    ('2023-04-02', 200.50),
    ('2023-04-03', 175.25),
    ('2023-04-04', 220.75),
    ('2023-04-05', 300.00),
    ('2023-04-06', 180.50),
    ('2023-04-07', 250.75),
    ('2023-04-08', 195.00),
    ('2023-04-09', 210.25),
    ('2023-04-10', 275.50);

INSERT INTO Producto (NombreProducto, PrecioUnitario)
VALUES 
    ('Polera', 25.00),
    ('Pantalón', 35.50),
    ('Zapatatillas', 50.25),
    ('Corbata', 15.75),
    ('Bufanda', 10.00),
    ('Sombrero', 20.50),
    ('jean', 12.75),
    ('Calcetines', 8.00),
    ('Guantes', 18.25),
    ('Bufanda', 10.50);


INSERT INTO DetalleVenta (IDVenta, IDProducto, Cantidad, PrecioUnitario, TotalDetalle)
VALUES 
    (1, 1, 2, 25.00, 50.00),
    (1, 2, 1, 35.50, 35.50),
    (2, 3, 1, 50.25, 50.25),
    (2, 4, 3, 15.75, 47.25),
    (3, 5, 2, 10.00, 20.00),
    (3, 6, 1, 20.50, 20.50),
    (4, 7, 2, 12.75, 25.50),
    (4, 8, 4, 8.00, 32.00),
    (5, 9, 1, 18.25, 18.25),
    (5, 10, 3, 10.50, 31.50);
