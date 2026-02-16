using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Model
{
    public class Teacher : LibraryUser
    {
        public override double calculateFine(int lateDays)
        {
            return lateDays * 2; 
        } 
    }
}
