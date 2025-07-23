// using System;

// namespace StructExample

// {
//     public struct Book
//     {
//         public string Title;

//         public string Author;

//         public decimal Price;

//         public short Year;
//     }

//     // It is non-Primitive

//     enum DaysOfWeek
//     {
//         Monday, Tuesday, Wednesday

//     }

//     enum Status
//     {

//         Pending,
//         Approved,
//         Rejected
//     }

//     class BookStructure
//     {
//         static void Main(string[] args)
//         {

//             DaysOfWeek t1 = DaysOfWeek.Tuesday;
//             Console.WriteLine("Structure Explained");

//             Console.WriteLine("Structure Example");

//             Book myBook = new Book();

//             myBook.Title = "CSharp";
//             myBook.Author = "ABC";
//             myBook.Price = 4545.00M;
//             myBook.Year = 2017;

//             Console.WriteLine(myBook.Title + myBook.Author + myBook.Price + myBook.Year);

//             if (t1 == DaysOfWeek.Monday || t1 == DaysOfWeek.Tuesday)
//             {
//                 Console.WriteLine("Either it is monday or tuesday");
//             }
//             else
//             {
//                 Console.WriteLine("either it is monday or tuesday");
//             }

//             switch (t1)
//             {
//                 case DaysOfWeek.Monday:
//                     Console.WriteLine("It's a monday");
//                     break;

//                 case DaysOfWeek.Tuesday:
//                     Console.WriteLine("It's Tuesday");
//                     break;

//                 case DaysOfWeek.Wednesday:
//                     Console.WriteLine("It's weekend");
//                     break;

//             }

//             Status s = Status.Pending;
//             string statusstring = s.ToString();

//             foreach (Status st in Enum.GetValues(typeof(Status)))  // Enum.GetValues - It is a static methods 
//             {
//                 Console.WriteLine(st);
//             }

//         }
//     }
// }