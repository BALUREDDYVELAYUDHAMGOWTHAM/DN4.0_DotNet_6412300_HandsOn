using System.Collections.Generic;

namespace StudentLibrary
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void InsertStudent(Student student);
        void DeleteStudent(int id);
    }
}
