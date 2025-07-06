CREATE TABLE Pallets (
    Id INT PRIMARY KEY,
    Width DECIMAL(10, 2) NOT NULL,
    Height DECIMAL(10, 2) NOT NULL,
    Depth DECIMAL(10, 2) NOT NULL,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Boxes (
    Id INT PRIMARY KEY,
    Width DECIMAL(10, 2) NOT NULL,
    Height DECIMAL(10, 2) NOT NULL,
    Depth DECIMAL(10, 2) NOT NULL,
    Weight DECIMAL(10, 2) NOT NULL,
    ProductionDate DATE NULL,
    ExpirationDate DATE NULL,
    PalletId INT NULL,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT FK_Boxes_Pallets FOREIGN KEY (PalletId) REFERENCES Pallets(Id),
    CONSTRAINT CHK_BoxDates CHECK (
        (ProductionDate IS NOT NULL AND ExpirationDate IS NULL) OR
        (ProductionDate IS NULL AND ExpirationDate IS NOT NULL)
    )
);

INSERT INTO Pallets (Id, Width, Height, Depth) VALUES
(1, 100.00, 100.00, 100.00),
(2, 120.00, 120.00, 120.00),
(3, 150.00, 150.00, 150.00);

INSERT INTO Boxes (Id, Width, Height, Depth, Weight, ProductionDate, PalletId) VALUES
(101, 50.00, 50.00, 50.00, 10.00, '2023-06-01', 1),
(102, 60.00, 60.00, 60.00, 15.00, '2023-06-10', 1),
(103, 70.00, 70.00, 70.00, 20.00, '2023-05-01', 2),
(104, 80.00, 80.00, 80.00, 25.00, '2023-05-15', 2),
(105, 90.00, 90.00, 90.00, 30.00, '2023-06-20', 3);

INSERT INTO Boxes (Id, Width, Height, Depth, Weight, ExpirationDate, PalletId) VALUES
(106, 40.00, 40.00, 40.00, 5.00, '2023-12-31', NULL),
(107, 45.00, 45.00, 45.00, 7.00, '2024-01-15', NULL);