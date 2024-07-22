using OCP.OCP.Models;
using OCP.OCP.Subscriptions;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Kelobel Tapia", 1);

        Course onlineCourse = new OnlineCourse { CourseId = 3, Title = "HTML Y CSS" };
        Course offlineCourse = new OfflineCourse { CourseId = 4, Title = "PHP" };
        Course HybridCourse = new HybridCourse { CourseId = 5, Title = "Javascript" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        HybridCourse.Subscribe(student);
    }
}
