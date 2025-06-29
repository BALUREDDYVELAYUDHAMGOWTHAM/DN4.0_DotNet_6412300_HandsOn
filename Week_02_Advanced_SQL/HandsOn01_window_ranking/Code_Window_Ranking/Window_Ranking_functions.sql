
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



/*RANKING FUNCTIONS*/

-- 1.ROW_NUMBER()
SELECT *,
  ROW_NUMBER() OVER(PARTITION BY Department ORDER BY GPA DESC) AS RowNum
FROM Students;

--  2. RANK()
SELECT *,
  RANK() OVER(PARTITION BY Department ORDER BY GPA DESC) AS RankVal
FROM Students;

-- 3. DENSE_RANK()

SELECT *,
  DENSE_RANK() OVER(PARTITION BY Department ORDER BY GPA DESC) AS DenseRankVal
FROM Students;



/* WINDOW FUNCTIONS */

-- 1. AVG(), SUM()

SELECT *,
  AVG(GPA) OVER(PARTITION BY Department) AS DeptAvgGPA,
  SUM(TotalMarks) OVER(PARTITION BY Department) AS DeptTotalMarks
FROM Students;


-- 2.MAX(), MIN()

SELECT *,
MAX(TotalMarks) OVER(PARTITION BY Department) as MAXIMUM_MARKS,
MIN(TotalMarks) OVER(PARTITION BY Department) as MINIMUM_MARKS
from Students;

