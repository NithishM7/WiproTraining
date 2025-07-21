// using System;
// using StudentProgram;

// class StudentArray
// {
//     static void Main()
//     {
//         int studentCount = 1;
//         Student[] students = new Student[studentCount];

//         for (int i = 0; i < studentCount; i++)
//         {
//             students[i] = new Student();
//             Console.WriteLine("Enter name of student");
//             students[i].Name = Console.ReadLine();

//             Console.WriteLine("Enter AGe of Student");
//             students[i].Age = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("How many stubjects you want to store");
//             int subjectCount = Convert.ToInt32(Console.ReadLine());

//             students[i].StudentMarks = new int[subjectCount];

//             for (int j = 0; j < subjectCount; j++)
//             {
//                 Console.WriteLine("Enter marks for subjects:");
//                 students[i].StudentMarks[j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }

//         Console.WriteLine("Student obj details are given below:");

//         foreach (Student s in students)
//         {
//             Console.WriteLine(s.Name);
//             Console.WriteLine(s.Age);
//             // Console.WriteLine(s.StudentMarks);

//             foreach (int marks in s.StudentMarks)
//             {
//                 Console.WriteLine("stuents Marks are:" + marks);
//             }
//         }
//     }
// }