using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication10
{
    //Code by Nicholas Iebba
    //With some help from MSDN
    //And from Tutorialspoint.com
    class BetterBinary
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am doing a make of this program for instructional class on game.";
            //creates the binary file that stores an int, a doulbe, and a string
            try
            {
                bw = new BinaryWriter(new FileStream("mydata",
                FileMode.Create));
            }
            catch (IOException e) //troubleshoot any possible problems with file creation
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e) //troubleshoot any possible problems with writing to file
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            bw.Close(); //Close the file (duh)
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("mydata",
                FileMode.Open));
            }
            catch (IOException e) //Try to reopen and catch a possbile error while doing so
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
