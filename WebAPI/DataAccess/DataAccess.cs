using MediatrEx.Models;

namespace MediatrEx.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<Student> student = new List<Student>();

        public DataAccess()
        {
            student.Add(new Student { Id = 1, FirstName = "Jhon", LastName = "Doe", Age = 18 });
            student.Add(new Student { Id = 2, FirstName = "Amelia", LastName = "Amy", Age = 16 });
        }

        public Student GetStudentById(int id)
        {
            var stu = student.Where(t => t.Id == id).FirstOrDefault();
            return stu;
        }

        public List<Student> GetStudents()
        {
            return student;
        }

        public Student AddStudent(StudentAdd studentAdd)
        {
            Student s = new Student();
            s.FirstName = studentAdd.FirstName;
            s.LastName = studentAdd.LastName;
            s.Age = studentAdd.Age;
            s.Id = student.Count() + 1;
            student.Add(s);
            return s;
        }
    }
}
