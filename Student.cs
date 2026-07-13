using System;
using System.Collections.Generic;
using System.Linq;

class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public int Credits { get; set; }
}

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public string Department { get; set; }
    public string StudentType { get; set; }

    public List<Course> EnrolledCourses = new List<Course>();

    public int TotalCredits()
    {
        return EnrolledCourses.Sum(c => c.Credits);
    }

    public double CalculateFee()
    {
        int credits = TotalCredits();

        switch (StudentType.ToLower())
        {
            case "regular":
                return credits * 1000;
            case "scholarship":
                return credits * 500;
            case "part-time":
                return credits * 800;
            default:
                return 0;
        }
    }
}

class StudentManagementSystem
{
    static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. Student Management");
            Console.WriteLine("2. Course Management");
            Console.WriteLine("3. Register Course");
            Console.WriteLine("4. View Student Details");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentManagement();
                    break;

                case 2:
                    CourseManagement();
                    break;

                case 3:
                    RegisterCourse();
                    break;

                case 4:
                    ViewStudentDetails();
                    break;

                case 5:
                    Console.WriteLine("Application Closed.");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }

    static void StudentManagement()
    {
        Console.WriteLine("\n1. Add Student");
        Console.WriteLine("2. View Students");
        Console.WriteLine("3. Search Student");
        Console.Write("Enter Choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Student s = new Student();

                Console.Write("Student ID: ");
                s.StudentID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Student Name: ");
                s.StudentName = Console.ReadLine();

                Console.Write("Department: ");
                s.Department = Console.ReadLine();

                Console.Write("Student Type (Regular/Scholarship/Part-Time): ");
                s.StudentType = Console.ReadLine();

                students.Add(s);
                Console.WriteLine("Student Registered Successfully!");
                break;

            case 2:
                Console.WriteLine("\nRegistered Students:");
                foreach (Student st in students)
                {
                    Console.WriteLine(st.StudentID + " - " + st.StudentName + " - " + st.Department);
                }
                break;

            case 3:
                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Student student = students.Find(x => x.StudentID == id);

                if (student != null)
                {
                    Console.WriteLine("ID: " + student.StudentID);
                    Console.WriteLine("Name: " + student.StudentName);
                    Console.WriteLine("Department: " + student.Department);
                }
                else
                {
                    Console.WriteLine("Student Not Found!");
                }
                break;
        }
    }

    static void CourseManagement()
    {
        Console.WriteLine("\n1. Add Course");
        Console.WriteLine("2. View Courses");
        Console.Write("Enter Choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Course c = new Course();

                Console.Write("Course ID: ");
                c.CourseID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Course Name: ");
                c.CourseName = Console.ReadLine();

                Console.Write("Credits: ");
                c.Credits = Convert.ToInt32(Console.ReadLine());

                courses.Add(c);
                Console.WriteLine("Course Added Successfully!");
                break;

            case 2:
                Console.WriteLine("\nAvailable Courses:");
                foreach (Course course in courses)
                {
                    Console.WriteLine(course.CourseID + " - " + course.CourseName + " - " + course.Credits + " Credits");
                }
                break;
        }
    }

    static void RegisterCourse()
    {
        Console.Write("Enter Student ID: ");
        int sid = Convert.ToInt32(Console.ReadLine());

        Student student = students.Find(x => x.StudentID == sid);

        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        if (student.EnrolledCourses.Count >= 5)
        {
            Console.WriteLine("Maximum 5 Courses Allowed!");
            return;
        }

        Console.Write("Enter Course ID: ");
        int cid = Convert.ToInt32(Console.ReadLine());

        Course course = courses.Find(x => x.CourseID == cid);

        if (course == null)
        {
            Console.WriteLine("Course Not Found!");
            return;
        }

        if (student.EnrolledCourses.Any(x => x.CourseID == cid))
        {
            Console.WriteLine("Duplicate Course Registration Not Allowed!");
            return;
        }

        student.EnrolledCourses.Add(course);
        Console.WriteLine("Course Registered Successfully!");
    }

    static void ViewStudentDetails()
    {
        Console.Write("Enter Student ID: ");
        int sid = Convert.ToInt32(Console.ReadLine());

        Student student = students.Find(x => x.StudentID == sid);

        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        Console.WriteLine("\n===== STUDENT DETAILS =====");
        Console.WriteLine("Student ID: " + student.StudentID);
        Console.WriteLine("Student Name: " + student.StudentName);
        Console.WriteLine("Department: " + student.Department);
        Console.WriteLine("Student Type: " + student.StudentType);

        Console.WriteLine("\nEnrolled Courses:");
        foreach (Course course in student.EnrolledCourses)
        {
            Console.WriteLine(course.CourseName + " (" + course.Credits + " Credits)");
        }

        Console.WriteLine("Total Credits: " + student.TotalCredits());
        Console.WriteLine("Total Fee: " + student.CalculateFee());
    }
}