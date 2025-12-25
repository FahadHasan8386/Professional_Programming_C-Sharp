using System;
using System.Collections.Generic;
using System.Text;

namespace SmartStudentManagementSystem
{
    // ================= ENUM =================
    enum UserRole
    {
        Student,
        Teacher,
        Admin
    }

    // ================= STRUCT =================
    struct Address
    {
        public string City;
        public string Country;

        public void Show()
        {
            Console.WriteLine($"Address: {City}, {Country}");
        }
    }

    // ================= ABSTRACT CLASS =================
    abstract class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public abstract void ShowRole();

        public void Greet()
        {
            Console.WriteLine($"Hello, I am {Name}");
        }
    }

    // ================= INTERFACE =================
    interface IPrintable
    {
        void Print();
    }

    // ================= PARTIAL CLASS (Part 1) =================
    partial class Student : Person, IPrintable
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public Address Address { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int? Age { get; set; }   // Nullable type

        public override void ShowRole()
        {
            Console.WriteLine($"Role: {Role}");
        }
    }

    // ================= PARTIAL CLASS (Part 2) =================
    partial class Student
    {
        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Admission: {AdmissionDate.ToShortDateString()}");
        }
    }

    // ================= STATIC CLASS =================
    static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {message}");
        }
    }

    // ================= GENERIC CLASS =================
    class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        // ================= GENERIC METHOD =================
        public void PrintAll<TData>(List<TData> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        // ================= PARAMETER MODIFIER =================
        static void Increase(ref int value)
        {
            value += 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Smart Student Management System ===\n");

            // -------- Repository --------
            Repository<Student> studentRepo = new Repository<Student>();

            // -------- Student Object --------
            Student s1 = new Student
            {
                Id = 1,
                Name = "Fahad Hasan",
                Role = UserRole.Student,
                AdmissionDate = new DateTime(2024, 1, 10),
                Age = null, // Nullable example
                Address = new Address { City = "Dhaka", Country = "Bangladesh" }
            };

            studentRepo.Add(s1);

            // -------- Display --------
            foreach (var student in studentRepo.GetAll())
            {
                student.Greet();
                student.ShowRole();
                student.Print();
                student.Address.Show();

                if (student.Age.HasValue)
                    Console.WriteLine($"Age: {student.Age}");
                else
                    Console.WriteLine("Age: Not Provided");

                Console.WriteLine();
            }

            // -------- StringBuilder --------
            StringBuilder report = new StringBuilder();
            report.Append("Student Report\n");
            report.Append("-----------------\n");
            report.Append($"Total Students: {studentRepo.GetAll().Count}\n");

            Console.WriteLine(report.ToString());

            // -------- Tuple --------
            var info = (Id: 1, Status: "Active");
            Console.WriteLine($"Tuple -> Id: {info.Id}, Status: {info.Status}");

            // -------- Anonymous Object --------
            var anon = new { Code = 200, Message = "Success" };
            Console.WriteLine($"Anonymous -> {anon.Code}, {anon.Message}");

            // -------- dynamic --------
            dynamic data = "Dynamic Text";
            Console.WriteLine(data);
            data = 123;
            Console.WriteLine(data);

            // -------- Parameter Modifier --------
            int number = 5;
            Increase(ref number);
            Console.WriteLine($"After ref: {number}");

            // -------- Static Logger --------
            Logger.Log("Program executed successfully");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
