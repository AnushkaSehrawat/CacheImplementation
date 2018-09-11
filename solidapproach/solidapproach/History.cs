using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    public class History
    {
        string path = @"C:\logfile.txt";
        private History() { }
        private static History _instance;
        public static History Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new History();
                }
                return _instance;
            }
        }

        public void AddToLogFile(string message)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(message);

            }
        }
    }
}
