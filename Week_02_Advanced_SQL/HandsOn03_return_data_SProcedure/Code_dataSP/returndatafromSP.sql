
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


-- 1. Return data of students who have gpa more than 8.0 using Stored Procedure

CREATE PROCEDURE GetHighGPAStudents()
BEGIN
    SELECT * FROM Students WHERE GPA > 8.0;
END;

-- calling the procedure
call `GetHighGPAStudents`;

-- 2. Return the total number of students present in the table using Stored Procedure

CREATE PROCEDURE GetStudentCount(OUT total INT)
BEGIN
    SELECT COUNT(*) INTO total FROM Students;
END;

-- calling the procedure
CALL GetStudentCount(@count);
SELECT @count;


-- 3. Checking whether the Student Exists with use of StudentID using Stored Procedure


CREATE PROCEDURE CheckStudentExists(
    IN p_StudentID INT
)
BEGIN
    DECLARE student_exists INT DEFAULT 0;
    SELECT COUNT(*) INTO student_exists
    FROM Students
    WHERE StudentID = p_StudentID;

    IF student_exists > 0 THEN
        SELECT 1 AS ExistsFlag;
    ELSE
        SELECT 0 AS ExistsFlag;
    END IF;
END;

-- calling the procedure
call CheckStudentExists(7);