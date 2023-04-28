namespace ExamClasses
{
    using AuthorAttribute;

    [Author("wyleesss", "2023-03-11")]
    public delegate void DExam(string teacherName, string examTask);

    [Author("wyleesss", "2023-03-13")]
    public class Teacher
    {
        private event DExam? ExamStudentsList;

        private string _name;
        private string _surname;

        public string FullName => $"{_surname} {_name}";

        public Teacher(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void AddExamStudent(Student student)
        {
            ExamStudentsList += student.Exam;
        }

        public void Exam(string examTask)
        {
            if (ExamStudentsList != null)
            {
                ExamStudentsList(this.FullName, examTask);
            }
        }
    }

    [Author("someone", "2023-03-11")]
    public class Student
    {
        private string _name;
        private string _surname;

        public string FullName => $"{_surname} {_name}";

        public Student(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void Exam(string teacherName, string examTask)
        {
            Console.WriteLine($"{FullName} was examinated.");
        }
    }
}