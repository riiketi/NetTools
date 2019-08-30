using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NirSoftNetTools
{
    class VendorIMEI
    {
        public static string Lookup(string imei)
        {
            string Result = "";
            string tac = imei.Substring(0, 8);

            string str = Properties.Resources.imeidb1;
            int ind1 = str.IndexOf(tac) + 9; // 8 - длина tac номера + запятая
            int ind2 = str.IndexOf(",", ind1);
            Result = str.Substring(ind1, (ind2 - ind1));

            if (String.IsNullOrEmpty(Result)) {
                str = Properties.Resources.imeidb2;
                ind1 = str.IndexOf(tac) + 9; // 8 - длина tac номера + запятая
                ind2 = str.IndexOf(",", ind1);
                Result = str.Substring(ind1, (ind2 - ind1));
                if (String.IsNullOrEmpty(Result)) {
                    Result = "Данный IMEI не найден";
                }
            }
            return Result;
        }
    }
}
