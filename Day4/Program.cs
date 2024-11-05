namespace Day4
{

    public enum Genre
    {
        Fiction,
        NonFiction,
        Mystery,
        ScienceFiction,
        Biography
    }

    public struct Book
    {
        public string Title;
        public string Author;
        public int PublicationYear;
        public Genre BookGenre;

    }

    // --------------------------------------------


    public enum YearLevel
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }

    public struct Student
    {
        public string Name;
        public YearLevel Level;
        public int[] Grades;
    }


    // --------------------------------------


    public enum Department
    {
        HR,
        IT,
        Sales,
        Finance
    }

    public struct Employee
    {
        public int EmployeeID;
        public string Name;
        public double Salary;
        public Department Dept;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1}:");
                Console.Write("Title: ");
                books[i].Title = Console.ReadLine();
                Console.Write("Author: ");
                books[i].Author = Console.ReadLine();
                Console.Write("Publication Year: ");
                books[i].PublicationYear = int.Parse(Console.ReadLine());
                Console.Write("Genre (Fiction, NonFiction, Mystery, ScienceFiction, Biography): ");
                books[i].BookGenre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine());

            }

            Console.WriteLine("\nBook Information:");

            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Genre: {book.BookGenre}");
            }


            //==================================================

            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}:");
                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Year Level (Freshman, Sophomore, Junior, Senior): ");
                students[i].Level = (YearLevel)Enum.Parse(typeof(YearLevel), Console.ReadLine());
                int[] grades = new int[5];

                for (int j = 0; j < grades.Length; j++)
                {
                    Console.Write($"Grade for Course {j + 1}: ");
                    grades[j] = int.Parse(Console.ReadLine());
                }

                students[i].Grades = grades;
            }

            Console.WriteLine("\nStudent Information:");
            Student topStudent = students[0];

            foreach (var student in students)
            {
                double average = student.Grades.Average();
                Console.WriteLine($"Name: {student.Name}, Year Level: {student.Level}, Average Grade: {average}");
                if (average > topStudent.Grades.Average())
                {
                    topStudent = student;
                }
            }

            Console.WriteLine($"\nStudent with the highest average grade: {topStudent.Name}, Average Grade: {topStudent.Grades.Average()}");


            // =============================================

            Employee[] employees = new Employee[3];
            double totalSalaries = 0;
            Employee highestPaid = employees[0];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");
                Console.Write("Employee ID: ");
                employees[i].EmployeeID = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("Salary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());
                Console.Write("Department (HR, IT, Sales, Finance): ");
                employees[i].Dept = (Department)Enum.Parse(typeof(Department), Console.ReadLine());

                totalSalaries += employees[i].Salary;

                if (employees[i].Salary > highestPaid.Salary)
                {
                    highestPaid = employees[i];
                }
            }

            Console.WriteLine($"\nTotal Salaries: {totalSalaries}");
            Console.WriteLine($"Department with the highest paid employee: {highestPaid.Dept} (Employee: {highestPaid.Name}, Salary: {highestPaid.Salary})");
        }
    }
}
