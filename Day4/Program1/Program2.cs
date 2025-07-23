// class Program2
// {
//     static void Main()
//     {
        // string a = "Nithish"; //Using Literal
        // string b = new string("Nithis"); //Using Construcor
        // Console.WriteLine("the vlaeu of b is: " + b);
        // Console.WriteLine(a == b); // It's checking the value
        // Console.WriteLine(a.GetHashCode());
        // Console.WriteLine(b.GetHashCode());

        // Console.WriteLine(object.ReferenceEquals(a, b)); // false - It checks the string creation one is literal and another is constructor

        // // string c = b;
        // // Console.WriteLine(object.ReferenceEquals(a, c)); // false - It checks the reference but both stored in different side

        // // String literal are interned
        // string c = string.Intern(b);
        // Console.WriteLine(c.GetHashCode()); // To get hash code
        // // Console.WriteLine(c);
        // Console.WriteLine(object.ReferenceEquals(a, c)); //To check the reference values

        // Console.WriteLine(StringComparer.Ordinal.GetHashCode(a));
        // Console.WriteLine(StringComparer.Ordinal.GetHashCode(c));

        // What is boxing and unboxing in C#?
    
        // Boxing - 


        // string nam = "Nithish";
        // nam += "M";

        // It will creates a new string objects in memeory every time
        // you modify it because string in immutable

        // StringBuilder sb = new StringBuilder(); // hash code
        // for (int i = 0; i < 10; i++)
        // {
        //     sb.append(i);
        // }
        // string result = sb.ToString();
//     }
// }

