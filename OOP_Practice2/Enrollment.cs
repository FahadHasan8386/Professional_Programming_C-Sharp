using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class Enrollment
    {
        public Student Student { get; set; }
        public Course Course { get; set; }

        public void Enroll()
        {
            if(!Course.IsApproved)
            {
                Console.WriteLine("Course Is not Approved yet !");
                return;
            }
            if(Student.MyWallet.Withdraw(Course.Fee))
            {
                Student.PaymentMethod.Pay(Course.Fee);
                Console.WriteLine($"{Student.Name} successfully enrolled in {Course.Fee}");
            }
        }
    }
}
 