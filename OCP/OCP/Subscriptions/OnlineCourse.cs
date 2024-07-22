using OCP.OCP.Models;


namespace OCP.OCP.Subscriptions
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"Student {std.Name} Se suscribio al curso online de: {Title}");
        }
    }
}
