// public class Father
// {
//     public void Car()
//     {
//         Console.WriteLine("Father's are doing a great work for his family");

//     }
// }

// public class Child : Father
// {
//     // Generally its's overriden but you are hiding that method in the inherited class
//     public void Car()
//     {
//         Console.WriteLine("Aadhar no. of child is 8752398");

//     }
// }

// public class MainProgram
// {
//     static void Main()
//     {
//         Father p = new Child();
//         p.Car();
//     }
// }

// In c# both are having the Car() method but wihout virtual and override keyword it's not overriding


// Method overirding in polymorphism can be done using virtual + override keyword

// public class Person
// {

//     public virtual void GetRole()
//     {

//         Console.WriteLine("Person class");

//     }

// }

// public class Teacher : Person
// {

//     //Generally it's overriden but you are hiding that method in the inherited class
//     public override void GetRole()
//     {

//         Console.WriteLine("She is a teacher");

//     }

// }

// public class Mother : Person
// {

//     //Generally it's overriden but you are hiding that method in the inherited class
//     public override void GetRole()
//     {

//         Console.WriteLine("She is a Mother");

//     }

// }

// public class MainProgram
// {

//     static  void Main()
//     {
//         //Late Binding - RunTime Polymorphism
//         Person p = new Teacher();
//         Person p1 = new Mother();

//         p.GetRole();
//         p1.GetRole();
//     }
// }

// both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide 

