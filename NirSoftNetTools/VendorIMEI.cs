using System;
using System.IO;
using System.Windows.Forms;


namespace NirSoftNetTools
{
    class VendorIMEI
    {
        public static string[] Lookup(string IMEI)
        {
            string TAC = IMEI.Substring(0, 8);

            try {
                DirectoryInfo dir = new DirectoryInfo(@"data\imei\");
                foreach (var item in dir.GetFiles()) {
                    CSVParser parser = new CSVParser(@"data\imei\" + item.Name);

                    string[] buff;
                    while ((buff = parser.ReadLine()) != null) 
                        if (buff[0].Equals(TAC)) 
                            return buff; 
                    
                }
            }
            catch (Exception e) { }

            return null;
        }
    }
}
