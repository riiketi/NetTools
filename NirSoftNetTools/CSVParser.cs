using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NirSoftNetTools
{
    class CSVParser
    {
        private StreamReader reader;

        public CSVParser(string filepath)
        {
            reader = new StreamReader(filepath);
        }

        public string[] ReadLine()
        {
            string buff = reader.ReadLine();
            string[] list = buff.Substring(0, buff.IndexOf(",,")).Split(',');

            return list;
        }
    }
}
