using System.Collections.Generic;
using System.Linq;

namespace StudentLibrary
{
    public class StudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetTopStudentsByGPA(int count)
        {
            return _repo.GetAllStudents()
                        .OrderByDescending(s => s.GPA)
                        .Take(count)
                        .ToList();
        }

        public bool IsStudentExist(int id)
        {
            return _repo.GetStudentById(id) != null;
        }
    }
}
