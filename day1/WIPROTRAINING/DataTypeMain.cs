
// //                      short System.Int16
// //                      int - 4bytes , IL will not understand the int System.Int32 - CLR
// //                      long - 8 bytes, System.Int64
// //                      float - 4 bytes,
// //                      double - 8 bytes,
// //                      bool - 1 byte,
// //                      char - 2 bytes,
// //                      string - 2bytes per character

// // We can define the integer in both ways but shorter format helps the system to understand

// using System.Security.Cryptography.X509Certificates;

// class DataType
// {
//     static void Main()
//     {
//         short number1 = 5;
//         System.Int16 number2 = 10;

//         int x = 40;
//         System.Int32 x1 = 45;

//         Console.WriteLine(x1.GetType());

//         // You will get int or uint

//         // uint is not a CLS-compliant  becuase it may lead to compatibility issues 22 +34, -22 + 34;

//         // unit will take a positive integers only starts with 0

//         public int AddOperation(int a, int b)
//     {
//         int result = a + b;
//         return result;
//     }

//     // Parse is used to convert the data type like Convert.Toint

//     // string val = "123";
//     // int number = int.Parse(val);

//     // string str = "abc";
//     // int value1 = int.Parse(str);

//     // Basically parse will be used whe strick string parsing.
//     // Otherwise we can do Convert.ToInt32

        






//     }
// }