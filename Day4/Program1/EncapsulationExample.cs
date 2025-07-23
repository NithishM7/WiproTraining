// // Encapsulation : 
// // Hiding the logic behind it and complexity only shows the necessary data.

// // 1. Providing a security to the data, where all the attributes of a class are private.

// // 2. Permission whether you are giving reading permission or writing.

// // 3. Security can be applied internally on set method

// using System;

// class Voter
// {

//     private int age = 0;
//     public void SetAge(int age)
//     {
//         // this keyword is used to distinguish between local variable and instance variable.
//         // this also refer to the current class object
//         this.age = age;
//         if (this.age < 18)
//         {
//             Console.WriteLine("Age should be greater than 18");
//         }
//     }

//     // private int GetAge() - It not allows us to get the age.
//     public int GetAge()
//     {
//         return age;
//     }

// }

// class MainProgram
// {
//     static void Main()
//     {
//         Voter v = new Voter();

//         v.SetAge(12);
//         Console.WriteLine(v.GetAge());
//     }
// }

