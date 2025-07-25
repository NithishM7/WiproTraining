// // See https://aka.ms/new-console-template for more information
// using System.Collections;
// class NonGenericExample
// {
//     static void Main()
//     {
//         // Boxing - When we are converting primitive to object
//         // int num = 45;
//         // object boxedvalue = num;

//         // Console.WriteLine(boxedvalue.GetType());

//         ArrayList arraylist = new ArrayList(); // It will store the values in object
//         int value = 20;
//         arraylist.Add(value);
//         Console.WriteLine(arraylist.GetType());

//         double unboxingvalue = (double)arraylist[0];
//         Console.WriteLine("Unboxing value: " + unboxingvalue);

//         // Generic one
//         // List<int> intlist = new List<int>();
//         // intlist.Add(value);
//         // double value2 = intlist[0];  //No boxing or auto boxing is required
//         // Console.WriteLine("The value after unboxing " + value2.GetType());

//         ArrayList list = new ArrayList();
//         list.Add("45");
//         string name = (string)list[0];  // Unboxing
//         Console.WriteLine(name.GetType());

//         int x = 5;
//         object obj = x;
//         int y = (int)obj;   // Boxing
//         Console.WriteLine(x.GetType());
//         Console.WriteLine(y.GetType());
//     }
// }
