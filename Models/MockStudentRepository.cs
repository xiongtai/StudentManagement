using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private readonly List<Student> _studentsList;

        public MockStudentRepository()
        {
            _studentsList = new List<Student>()
            {
                new Student{Id = 1,Name = "zhangsan",ClassName = "class 1",Email = "zhangsan@live.com"},
                new Student{Id = 2,Name = "lisi",ClassName = "class 2",Email = "lisi@live.com"},
                new Student{Id = 3,Name = "wangwu",ClassName = "class 2 ",Email = "wangwu@live.com"}
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentsList;
        }

        public Student GetStudent(int id)
        {
            return _studentsList.FirstOrDefault(s => s.Id == id);
        }
    }
}