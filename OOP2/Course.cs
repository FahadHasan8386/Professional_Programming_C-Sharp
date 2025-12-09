using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Course
    {
        public string Title;
        public int Duration;

        public Course(string title ,int duration)
        {
            this.Title = title;
            this.Duration = duration;
        }

        public void ShowCource()
        {
            Console.WriteLine("Course  : " + Title);
            Console.WriteLine("Duration: " + Duration);
        }
    }
}
