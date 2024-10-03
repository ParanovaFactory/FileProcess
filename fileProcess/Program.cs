using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\berka\\Desktop\\Test.txt";
            //Crate text file
            //FileStream fileStream = new FileStream(path, FileMode.Create);

            //Save data in file
            //FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fileStream);
            //writer.WriteLine("Row 1");
            //writer.WriteLine("Row 2");
            //writer.WriteLine("Row 3");
            //fileStream.Flush();
            //writer.Close();
            //fileStream.Close();

            //Read data from file
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string line = reader.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }
    }
}
