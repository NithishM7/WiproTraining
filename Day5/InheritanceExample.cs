// /* Inheritance --- When a child class is inheriting some of the properties of base class

// In Inheritance we use some coonventions like base class, super class, parent class

// Similarly we call the class who has inherited the features of base class as child class, sub class, derived class */

// /* Types of Inheritance */

// // Single Inheritance --- There is one base class and one child class

// public class Person
// {
//     // Properties

//     protected string Name { get; set; }

//     public virtual void Display()
//     {
//         Console.WriteLine("Displaying Name you entered :");
//     }
// }
 
// // Single Inheritance

// public class Student : Person
// {

//     public int RollNumber { get; set; }

//     public void Study()
//     {
//         Console.WriteLine(Name + " Is studying :");
//     }

//     static void Main()
//     {
//         Student stud = new Student();
//         stud.Name = "Nithish";
//         stud.RollNumber = 2005;
//         stud.Display();
//         stud.Study();
//     }

// }

// // Multi-level Inhertiance

// public class MainProgram : Student                 // Person - We can also give person
// {
//     static void Main()
//     {
//         Student stud = new Student();
//         stud.Name = "Nithish";
//         stud.RollNumber = 2005;
//         stud.Display();
//         stud.Study();
//     }

// }