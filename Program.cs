using System;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student()
                {
                    FirstName = "John",
                    LastName = "Smith"
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");
            Console.ReadLine();
        }
    }
}
