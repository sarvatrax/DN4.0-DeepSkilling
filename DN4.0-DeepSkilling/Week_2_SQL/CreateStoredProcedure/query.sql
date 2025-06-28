USE EmployeeDB;
GO

SELECT 
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
FROM Employees
WHERE DepartmentID = 2;

GO

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;


EXEC sp_InsertEmployee 
    'Alex', 'Brown', 3, 6800.00, '2024-06-26';
