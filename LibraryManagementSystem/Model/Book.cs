using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        private bool isAvailable = true;

        public string Title { get; set; }

        public bool IsAvailable()
        {
            return isAvailable;
        }

        public void Borrow()
        {
            if (isAvailable)
                isAvailable = false;
        }


        public void Return()
        {
            isAvailable = true;;
        }
    }
}
