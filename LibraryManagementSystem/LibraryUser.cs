using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    public abstract class LibraryUser
    {
        public string Name { get; set; }
        public abstract double calculateFine(int lateDays);
    }
}
