// using System;

// // The ability to take many forms
// /* method overloading -- where all methods in a class are with the same name but the arguments will differ (either datatype will be dfferent or the sequence of arguments are different order of arguments )

// static bidning -- when compiler will identify which method needs to be called at compile time */

// /* method overriding --  where some methods in base class and in inherited or child class are with the same name

// static bidning -- when compiler will identify which method needs to be called at run time when the object will be created*/

// namespace oops.poly
// {
//     class InfoPrinter
//     {
//         // Static int Pages
//         public int Pages;
//         InfoPrinter()
//         {
//             this.Pages = 0;
//         //     Console.WriteLine("Constructor Called");
//         }

//         InfoPrinter(int Pagess)
//         {
//             this.Pages = Pagess;
//             this.Pages = this.Pages + 1;
//             Console.WriteLine("Total Pages Printed: " + this.Pages);
//         }
//         public void Print(int empId, string name)
//         {
//             Console.WriteLine( "EmpId: "+ empId +" Name :" + name);
//         }

//         public void Print(string name, int empId)
//         {
//             Console.WriteLine("Name :" + name + " EmpId :" + empId);
//         }

//         static void Main()
//         {
//             InfoPrinter InfPrinter = new InfoPrinter();
//             InfPrinter.Print(2023,"Nithish"); // At compile time 
//             InfPrinter.Print("Nithish", 2025);
//             InfoPrinter InfPrinter1 = new InfoPrinter(23);
//             InfoPrinter InfPrinter2 = new InfoPrinter(12);
//         }
//     }
// }