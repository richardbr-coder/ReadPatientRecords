using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadPatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read and show info from the file.
            string line = " ";

            try
            {
                //text reader
                using (StreamReader sr = new StreamReader("PatientRecords.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            //Exception handling
            catch
            {
                Console.WriteLine("ERROR - The file is invalid");
            }
            Console.ReadKey();
        }
    }
}