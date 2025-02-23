namespace Advanced.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Ahmed", 85.5),
                new Student(2, "Shimaa", 92.0),
                new Student(3, "Islam", 78.5),
                new Student(4, "Kareem", 88.0),
                new Student(5, "Hesham", 95.0)
            };

            // 1. Print all students.
            Console.WriteLine("All students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            // 2. Find a student by ID and update their grade.
            int searchId = 3;
            Student studentToUpdate = students.Find(s => s.Id == searchId);
            if (studentToUpdate != null)
            {
                studentToUpdate.Grade = 82.0;
                Console.WriteLine($"\nUpdated student (ID {searchId}): {studentToUpdate}");
            }
            else
            {
                Console.WriteLine($"\nStudent with ID {searchId} not found.");
            }

            // 3. Remove a student from the list.
            int removeId = 2;
            Student studentToRemove = students.Find(s => s.Id == removeId);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine($"\nRemoved student with ID {removeId}.");
            }
            else
            {
                Console.WriteLine($"\nStudent with ID {removeId} not found.");
            }

            // 4. Sort students by Grade.
            List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();
            Console.WriteLine("\nStudents sorted by Grade (descending):");
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            // 5. Print the top 3 students.
            Console.WriteLine("\nTop 3 students:");
            foreach (Student student in sortedStudents.Take(3))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n ========================================== \n");

            Dictionary<int, string> countries = new Dictionary<int, string>
            {
                { 1, "USA" },
                { 91, "India" },
                { 44, "UK" },
                { 81, "Japan" },
                { 20, "Egypt" }
            };

            Console.WriteLine("All country codes and names:");
            foreach (KeyValuePair<int, string> kvp in countries)
            {
                Console.WriteLine($"Country Code: {kvp.Key}, Country Name: {kvp.Value}");
            }

            Console.Write("\nEnter a country code to search: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int countryCode))
            {
                if (countries.ContainsKey(countryCode))
                {
                    Console.WriteLine($"Country with code {countryCode}: {countries[countryCode]}");
                }
                else
                {
                    Console.WriteLine("Country code not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            if (countries.Remove(44))
            {
                Console.WriteLine("\nCountry code 44 removed.");
            }
            else
            {
                Console.WriteLine("\nCountry code 44 not found.");
            }

            Console.WriteLine("\nUpdated dictionary:");
            foreach (KeyValuePair<int, string> country in countries)
            {
                Console.WriteLine($"Country Code: {country.Key}, Country Name: {country.Value}");
            }


            Console.WriteLine("\n ========================================== \n");


            HashSet<string> languages = new HashSet<string>();

            languages.Add("C#");
            languages.Add("Java");
            languages.Add("Python");
            languages.Add("C++");
            languages.Add("C#");
            languages.Add("Java");

            Console.WriteLine("Unique programming languages:");
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine();
            if (languages.Contains("JavaScript"))
            {
                Console.WriteLine("JavaScript exists in the set.");
            }
            else
            {
                Console.WriteLine("JavaScript does not exist in the set.");
            }

            if (languages.Remove("Python"))
            {
                Console.WriteLine("\nPython removed from the set.");
            }
            else
            {
                Console.WriteLine("\nPython was not found in the set.");
            }

            Console.WriteLine("\nUpdated programming languages:");
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("\n ========================================== \n");

            TextEditor editor = new TextEditor();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Type new text");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Exit");
                Console.Write("Option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter text to add: ");
                        string inputText = Console.ReadLine();
                        editor.TypeText(inputText);
                        break;
                    case "2":
                        editor.Undo();
                        break;
                    case "3":
                        editor.Redo();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

            Console.WriteLine("\n ========================================== \n");

            Queue<string> ticketQueue = new Queue<string>();

            ticketQueue.Enqueue("Ticket#1");
            ticketQueue.Enqueue("Ticket#2");
            ticketQueue.Enqueue("Ticket#3");
            ticketQueue.Enqueue("Ticket#4");

            Console.WriteLine("Tickets added to the queue:");
            foreach (var ticket in ticketQueue)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine("\nProcessing tickets...");
            if (ticketQueue.Count > 0)
            {
                string processedTicket = ticketQueue.Dequeue();
                Console.WriteLine($"Processed: {processedTicket}");
            }
            if (ticketQueue.Count > 0)
            {
                string processedTicket = ticketQueue.Dequeue();
                Console.WriteLine($"Processed: {processedTicket}");
            }

            // Display remaining tickets in the queue.
            Console.WriteLine("\nRemaining tickets in the queue:");
            foreach (var ticket in ticketQueue)
            {
                Console.WriteLine(ticket);
            }

            Console.WriteLine("\n ========================================== \n");

            Dictionary<int, HashSet<string>> studentSubjects = new Dictionary<int, HashSet<string>>();

            studentSubjects[1] = new HashSet<string>();
            studentSubjects[1].Add("Mathematics");
            studentSubjects[1].Add("Physics");
            studentSubjects[1].Add("Chemistry");
            studentSubjects[1].Add("Mathematics"); // Duplicate 

            studentSubjects[2] = new HashSet<string>();
            studentSubjects[2].Add("Biology");
            studentSubjects[2].Add("Chemistry");
            studentSubjects[2].Add("English");

            studentSubjects[3] = new HashSet<string>();
            studentSubjects[3].Add("History");
            studentSubjects[3].Add("Geography");
            studentSubjects[3].Add("Mathematics");


            Console.WriteLine("Subjects for Student 1:");
            if (studentSubjects.ContainsKey(1))
            {
                foreach (string subject in studentSubjects[1])
                {
                    Console.WriteLine(subject);
                }
            }
            else
            {
                Console.WriteLine("Student 1 not found.");
            }

            if (studentSubjects[1].Remove("Physics"))
            {
                Console.WriteLine("'Physics' removed successfully.");
            }
            else
            {
                Console.WriteLine("'Physics' not found for Student 1.");
            }

            Console.WriteLine("\nUpdated subjects for Student with ID 1:");
            foreach (string subject in studentSubjects[1])
            {
                Console.WriteLine(subject);
            }
        }
    }
}
