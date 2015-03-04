using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication11
{
    class TextFile
    {
        //Code by Nicholas Iebba
        //With help from MSDN
        //And Tutorialspoint.com
        static void Main(string[] args)
        {
            StreamWriter sw;
            StreamReader sr;
            int i = 57;
            double p = 48;
            //bool b = false;
            //string s = "How is babby formed?";
            //Create the text file and troublshoot the process
            try
            {
                sw = new StreamWriter(new FileStream("mydata",
                FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            //Writing to the file (as well as troubleshooting the process)
            try
            {
                sw.Write(i);
                sw.Write(p);
                //sw.Write(b);
                //sw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            sw.Close();
            //reading from the file
            try
            {
                sr = new StreamReader(new FileStream("mydata",
                FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try //Printing the file's info
            {
                i = sr.Read();
                Console.WriteLine("Integer data: {0}", i);
                p = sr.Read();
                Console.WriteLine("Double data: {0}", p);
                //b = sr.ReadBool();
                //Console.WriteLine("Boolean data: {0}", b);
                //s = sr.Read();
                //Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            sr.Close();
            Console.ReadKey();
        }
    }
}
