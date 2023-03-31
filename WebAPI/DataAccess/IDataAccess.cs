using MediatrEx.Models;

namespace MediatrEx.DataAccess
{
    public interface IDataAccess
    {
        List<Student> GetStudents();
        Student AddStudent(StudentAdd studentAdd);
        Student GetStudentById(int id);
    }
}
