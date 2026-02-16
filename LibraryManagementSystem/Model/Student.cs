using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Model
{
    public class Student : LibraryUser
    {
        public override double calculateFine(int lateDays)
        {
            return lateDays * 5;
        }
    }
}
