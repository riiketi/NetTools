using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NirSoftNetTools
{
    class VendorIMEI
    {
        const int IMEILength = 8; 
        public static string[] Lookup(string IMEI)
        {
            MessageBox.Show("foreach");
            try {
                MessageBox.Show("foreach");
                DirectoryInfo dir = new DirectoryInfo(@"data\imei\");
                foreach (var item in dir.GetFiles()) {
                    MessageBox.Show("foreach");
                    CSVParser parser = new CSVParser(@"data\imei\" + item.Name);
                    string[] buff;
                    while ((buff = parser.ReadLine()) != null) {
                        if (buff[0].Equals(IMEI)) {
                            return buff;
                        }
                    }
                }
            }
            catch (Exception e) { }
            return null;
        }
    }
}
