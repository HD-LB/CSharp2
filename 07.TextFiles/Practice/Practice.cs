
using System;
using System.IO;

namespace Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            //StramWriter
            string fileName = @"..\..\numbers.txt";

            using (StreamWriter streamWriter = new StreamWriter(fileName,true))
            {
                for (int number = 1; number <= 20; number++)
                {
                    streamWriter.WriteLine(number);
                }
            }
            Console.WriteLine("File is written.");


            //Streamreader
            string filePath = @"..\..\test.txt";

            StreamReader streamReader = new StreamReader(filePath);

            using (streamReader)
            {                
                string line = streamReader.ReadToEnd();
                Console.WriteLine(line);               
            }
            streamReader.Close();
        }
    }
}
