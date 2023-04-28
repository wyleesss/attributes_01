using System.Reflection;

using ExamClasses;
using AuthorAttribute;

class Program
{
    static void Main()
    {
        Console.WriteLine("class \"Teacher\" authorship:");
        foreach (var author in typeof(Teacher).GetCustomAttributes())
        {
            if (author.GetType() == typeof(Author))
            {
                Console.WriteLine(author);
            }
        }

        Console.WriteLine("\nclass \"Student\" authorship:");
        foreach (var author in typeof(Student).GetCustomAttributes())
        {
            if (author.GetType() == typeof(Author))
            {
                Console.WriteLine(author);
            }
        }

        Console.WriteLine("\ndelegate \"DExam\" authorship:");
        foreach (var author in typeof(DExam).GetCustomAttributes())
        {
            if (author.GetType() == typeof(Author))
            {
                Console.WriteLine(author);
            }
        }
    }
}