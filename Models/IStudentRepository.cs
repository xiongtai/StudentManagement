using System.Collections.Generic;

namespace StudentManagementSystem.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
    }
}