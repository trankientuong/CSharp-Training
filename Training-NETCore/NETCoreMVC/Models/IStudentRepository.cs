using System;

namespace NETCOREMVC.Models
{
    public interface IStudentRepository
    {   
        Student GetStudentById(int studentId);
        List<Student> GetStudents();
    }
}