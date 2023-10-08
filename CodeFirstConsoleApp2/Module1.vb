Using System;

Public Class Student
{
    Public int StudentId { Get; Set; }
    Public String Name { Get; Set; }
    Public DateTime EnrollmentDate { Get; Set; }
}

Using System.Data.Entity;

Public Class SchoolContext :  DbContext
{
    Public DbSet<Student> Students { Get; Set; }
}

        Class Program
{
    Static void Main(String[] args)
    {
        Using (var context = New SchoolContext())
        {
            // Create the database
            context.Database.CreateIfNotExists();

            // Add a student
            var student = New Student
            {
                Name = "John Doe",
                EnrollmentDate = DateTime.Now
            };
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}



Module Module1

        Sub Main()

        End Sub

    End Module
