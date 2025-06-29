
/* SQL queries for creating the database,tables and implementation in MySQL*/
create database AdvancedSQL;

use advancedsql;

create table Students(
	StudentID int primary key,
    studentName varchar(100),
    Department varchar(50),
    Year INT,
    GPA DECIMAL(3, 2),
    TotalMarks INT,
    Age INT
);

INSERT INTO Students (StudentID, studentName, Department, Year, GPA, TotalMarks, Age) VALUES
(1, 'Nick', 'CSE', 3, 8.9, 890, 20),
(2, 'Steve', 'ECE', 3, 8.7, 870, 21),
(3, 'Noah', 'CSE', 3, 9.5, 950, 20),
(4, 'Nancy', 'IT', 2, 7.8, 780, 19),
(5, 'Jonathan', 'CSE', 3, 9.1, 910, 20),
(6, 'Dustin', 'ECE', 2, 8.4, 840, 19),
(7, 'Will', 'EEE', 3, 7.9, 790, 22);



/*STORED PROCEDURE

A Stored Procedure is a precompiled set of SQL statements stored in the database, which can be executed repeatedly with optional input parameters.

*/

-- 1. Stored Procedure for displaying top 3 students who have more GPA

CREATE PROCEDURE GetTopStudentsByGPA(IN TopN INT)
BEGIN
    SET @sql = CONCAT('SELECT * FROM Students ORDER BY GPA DESC LIMIT ', TopN);
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END 

CALL GetTopStudentsByGPA(3);

-- 2. Stored Procedure for Inserting a new Student Record


CREATE PROCEDURE InsertStudent (
    IN g_StudentID INT,
    IN g_StudentName VARCHAR(100),
    IN g_Department VARCHAR(50),
    IN g_Year INT,
    IN g_GPA DECIMAL(3, 2),
    IN g_TotalMarks INT,
    IN g_Age INT
)
BEGIN
    INSERT INTO Students(StudentID, studentName, Department, Year, GPA, TotalMarks, Age)
    VALUES (g_StudentID, g_StudentName, g_Department, g_Year, g_GPA, g_TotalMarks, g_Age);
END;
CALL InsertStudent(8, 'Gowtham', 'CSE', 3, 8.7, 878, 20);
select * from students;

-- 3. Stored Procedure for Deleting a new Student Record

CREATE PROCEDURE DeleteStudentByID (
    IN p_StudentID INT
)
BEGIN
    DELETE FROM Students
    WHERE StudentID = p_StudentID;
END;

call DeleteStudentByID(6);

select * from students;
