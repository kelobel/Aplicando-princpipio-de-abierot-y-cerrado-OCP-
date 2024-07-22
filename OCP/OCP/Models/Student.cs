


namespace OCP.OCP.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }
    }
}
