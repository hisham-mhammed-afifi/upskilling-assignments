namespace Database
{

    public enum Grade
    {
        A,
        B,
        C,
        D,
        F,
        NotAssigned
    }

    public struct StudentRecord
    {
        public string ID;
        public string Name;
        public int[] Scores;
        public Grade Grade;

        public StudentRecord(string id, string name, int[] scores, Grade grade = Grade.NotAssigned)
        {
            ID = id;
            Name = name;
            Scores = scores;
            Grade = grade;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<StudentRecord> students = new List<StudentRecord>();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Calculate Grades");
                Console.WriteLine("4. Display Results");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddStudent(students); break;
                    case 2: UpdateStudent(students); break;
                    case 3: CalculateGrades(students); break;
                    case 4: DisplayResults(students); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice! Please select from the menu."); break;
                }
            }
        }


        static void AddStudent(List<StudentRecord> students)
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            if (students.Any(s => s.ID == id))
            {
                Console.WriteLine("A student with this ID already exists.");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            int[] scores = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter Score {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out scores[i]) || scores[i] < 0 || scores[i] > 100)
                {
                    Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
                    i--;
                }
            }

            students.Add(new StudentRecord(id, name, scores));
            Console.WriteLine("Student added successfully!");
        }

        static void UpdateStudent(List<StudentRecord> students)
        {
            Console.Write("Enter Student ID to update: ");
            string id = Console.ReadLine();

            var studentIndex = students.FindIndex(s => s.ID == id);
            if (studentIndex == -1)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.WriteLine($"Updating scores for {students[studentIndex].Name}");

            int[] newScores = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter new Score {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out newScores[i]) || newScores[i] < 0 || newScores[i] > 100)
                {
                    Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
                    i--;
                }
            }

            var updatedStudent = new StudentRecord(
                students[studentIndex].ID,
                students[studentIndex].Name,
                newScores,
                students[studentIndex].Grade
            );
            students[studentIndex] = updatedStudent;

            Console.WriteLine("Student scores updated successfully!");
        }

        static void CalculateGrades(List<StudentRecord> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                double avg = student.Scores.Average();
                Grade grade = avg >= 90 ? Grade.A :
                              avg >= 80 ? Grade.B :
                              avg >= 70 ? Grade.C :
                              avg >= 60 ? Grade.D : Grade.F;

                students[i] = new StudentRecord(student.ID, student.Name, student.Scores, grade);
            }
            Console.WriteLine("Grades calculated and updated successfully!");
        }

        static void DisplayResults(List<StudentRecord> students)
        {
            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Average: {student.Scores.Average():F2}, Grade: {student.Grade}");
            }

            if (students.Count > 0)
            {
                var topStudent = students.OrderByDescending(s => s.Scores.Average()).First();
                Console.WriteLine($"\nTop Performer: {topStudent.Name}, Average: {topStudent.Scores.Average():F2}");
            }

            Console.WriteLine("\nPassed Students:");
            foreach (var student in students.Where(s => s.Grade != Grade.F))
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nFailed Students:");
            foreach (var student in students.Where(s => s.Grade == Grade.F))
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}

