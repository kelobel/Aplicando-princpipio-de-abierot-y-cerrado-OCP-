using OCP.OCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP.Subscriptions
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"Student {std.Name} Se suscribio al curso offline de: {Title}");
        }
    }
}
