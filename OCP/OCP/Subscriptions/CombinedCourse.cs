using OCP.OCP.Models;


namespace OCP.OCP.Subscriptions
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"Student {std.Name} Se a suscrito al curso online de: {Title}, con clases online y offline.");
        }
    }
}
