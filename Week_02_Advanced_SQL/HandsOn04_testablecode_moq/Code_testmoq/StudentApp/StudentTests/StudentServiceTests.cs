using System.Collections.Generic;
using Moq;
using StudentLibrary;
using Xunit;

public class StudentServiceTests
{
    [Fact]
    public void GetTopStudentsByGPA_ReturnsTopNStudents()
    {
        // Arrange
        var mockRepo = new Mock<IStudentRepository>();
        mockRepo.Setup(repo => repo.GetAllStudents()).Returns(new List<Student>
        {
            new Student { StudentID = 1, StudentName = "Alice", GPA = 9.1M },
            new Student { StudentID = 2, StudentName = "Bob", GPA = 8.4M },
            new Student { StudentID = 3, StudentName = "Carol", GPA = 9.5M }
        });

        var service = new StudentService(mockRepo.Object);

        // Act
        var result = service.GetTopStudentsByGPA(2);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Carol", result[0].StudentName);
    }

    [Fact]
    public void IsStudentExist_ReturnsTrueIfExists()
    {
        var mockRepo = new Mock<IStudentRepository>();
        mockRepo.Setup(repo => repo.GetStudentById(1))
                .Returns(new Student { StudentID = 1, StudentName = "Alice" });

        var service = new StudentService(mockRepo.Object);
        var exists = service.IsStudentExist(1);

        Assert.True(exists);
    }
}
