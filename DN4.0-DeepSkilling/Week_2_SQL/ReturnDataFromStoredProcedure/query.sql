USE EmployeeDB;
GO

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 2;
GO
