// See https://aka.ms/new-console-template for more information

public class CollectionExamples
{
    public static void Main()
    {

        // List

        // List<string> students = new List<string>();
        // students.Add("Nithish");
        // students.Add("asdfgf");
        // // students.Add(20);

        // foreach (string student in students)
        // {
        //     Console.WriteLine(student);
        // }

        // Dictionary

        // Dictionary<int, string> data = new Dictionary<int, string>();
        // data.Add(20, "Nithish");
        // data.Add(21, "Nitish");

        // // Console.WriteLine(data[20]);

        // foreach (KeyValuePair<int, string> kv in data)
        // {
        //     Console.WriteLine(kv.Key + " " + kv.Value);
        // }

        // HashSet don't allow the duplicates

        // HashSet<string> employees = new HashSet<string>();
        // employees.Add("abc");
        // employees.Add("xdc");
        // employees.Add("abc");

        // foreach (var e in employees)
        // {
        //     Console.WriteLine(e);
        // }


        // Stack<string> todotask = new Stack<string>();
        // todotask.Push("Learn C#");
        // todotask.Push("Revise the concepts");
        // todotask.Push("Clear your exam");

        // foreach (string task in todotask)
        // {
        //     Console.WriteLine(task);
        // }
        // while (todotask.Count > 0)
        // {
        //     todotask.Pop();
        //     Console.WriteLine("One task in completed");
        // }

        // foreach (string task in todotask)
        // {
        //     Console.WriteLine(task);
        // }
        // while (todotask.Count > 0)
        // {
        //     todotask.Pop();
        //     Console.WriteLine("One task in completed ");
        // }

        // Queue<string> tickets = new Queue<string>();
        // tickets.Enqueue("Learn C#");
        // tickets.Enqueue("Revise the concepts");
        // tickets.Enqueue("Clear your exam");

        // foreach (string task in tickets)
        // {
        //     Console.WriteLine(task);
        // }

        // Create a collection of students to store student id ,student name and  subjectmarks(key as a subject and value as a marks)
        // then display each student detail with average score

        Dictionary<int, string> stu1 = new Dictionary<int, string>();

        stu1.Add(21, "Nithish");
        stu1.Add(22, "Sanjay");
        stu1.Add(23, "Kathir");

        foreach (KeyValuePair<int, string> st in stu1)
        {
            Console.WriteLine(st.Key + " " + st.Value);
        }

        Dictionary<int, string> sub = new Dictionary<int, string>();
        sub.Add(97);
        sub.Add(65);
        sub.Add(79);
        while (sub.Count > 0)
        {
            // sub.Pop();
            Console.WriteLine("Subjects" + sub);
        }
    }
}
