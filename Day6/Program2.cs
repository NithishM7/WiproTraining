// using System.IO;

// class Program2
// {
//     static void Main()
//     {
//         string path = "file1.txt";
//         string messafe = "File data related to C#";

//         // To write using filestream
//         // Garbage Collector
//         // Manually we have to close and open ( we need not to write manually open / close / flush)

//         FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

//                 byte[] data = System.Text.Encoding.UTF8.GetBytes(messafe);

//                 fs.Write(data, 0, data.Length);

//         fs.Close();

//         FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);

//                 // To read the data it is important to use buffer
//                 byte[] buffer = new byte[fs1.Length];
//                 fs1.Read(buffer, 0, buffer.Length);

//                 string result = System.Text.Encoding.UTF8.GetString(buffer);
//                 Console.WriteLine(result);
//         fs1.Close();
            
        
//     }

// }



