using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class Course
    {
        public string Title { get; set; }
        public double Fee { get; set; }
        public Instructor Instructor { get; set; }
        public bool IsApproved { get; set; }

        public Course(string title , double fee , Instructor instructor)
        {
            Title = title;
            Fee = fee;
            Instructor = instructor;
        }


    }
}
