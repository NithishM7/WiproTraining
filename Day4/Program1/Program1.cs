// // Console.WriteLine("Nithish");

// //  It's created in the string pool(intern)

// // string name = "nithish"; // Whenever we are declaring a variable and initializing with one value.

// // String newname = name.ToUper(); // Whenever we are calling a static methods of string then we use this part.


// using System;

// class StringPrograms
// {
//     static void Main()
//     {
//         string text = "CSharp Language";

//         int lenght = text.Length;  // 15
//         Console.WriteLine("The Length of a string: " + lenght);
//         string subString = text.Substring(7, 8);
//         Console.WriteLine("The text from a string: " + subString);
//         Console.WriteLine(text.IndexOf("harp"));
//         string newString = text.Replace("CSharp", "Python");
//         Console.WriteLine(newString);

//         String replaced = text.Replace(" ", "");
//         Console.WriteLine("Without space: " + replaced.Length);

//         int pos = text.IndexOf("Language");
//         string newText = text.Substring(7, 8);
//         Console.WriteLine("New text value: " + newText);

//         // Counting all blank space
//         // Counting the special characters
//         // Counting all the words in sentence

//         string data = "CSharp,Language";
//         String[] lang = data.Split(',');
//         foreach (string valuess in lang)
//         {

//             Console.WriteLine(valuess);
//         }

//         string data1 = "This is me nithish who don't know anything and forget everything";
//         string[] lang1 = data1.Split(' ');
//         Console.WriteLine("The blank is: " + ((lang1.Length - 1)));

//         string data2 = "apple,orange,grapes,banana";
//         string[] lang2 = data2.Split(',');
//         Console.WriteLine("The comma above: " + ((lang2.Length - 1)));

//         string data3 = "This is the fourth class of training";
//         string[] lang3 = data3.Split(' ');
//         Console.WriteLine("The number of words" + ((lang3.Length-1)));

//         // int Count = 0;
//         // foreach (char cchar in text1)
//         // {
//         //     if (!char.IsLetterOrDigit(cchar))
//         //         specialCharCount++;
//         // }
//         // Console.WriteLine(Count);

//         // string vow = ('a', 'e', 'i', 'o', 'u');

//         // Finding the vowels

//         Console.WriteLine("Enter the sentence");
//         string data4 = Console.ReadLine();
//         string[] lang4 = data4.Includes('a','e','i','o','u','A','E','I','O','U');
//         Console.WriteLine("the vowels are: " + ((lang4.Length-1)));



//     }
// }