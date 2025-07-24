public class Person
{
    protected string Name { get; set; }
    public virtual void Display()
    {
        Console.WriteLine("Displaying Name you entered:" + Name);
    }

    public class Student : Person
    {
        public int RollNumber { get; set; }
        public void Study()
        {
            Console.WriteLine(Name + "is studying");
        }

        public class Teacher : Person
        {
            public string Subject { get; set; }

            public void Teaches()
            {
                Console.WriteLine(Name + "Teaches Computer Science");
            }

            static void Main()
            {
                Teacher t = new Teacher();
                t.Name = "Niti";

                t.Teaches();           // From child class i.e. Teacher
                t.Display();          // From Base class i.e. Person
            }
        }
    }
}