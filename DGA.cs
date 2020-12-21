using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DGA(1999,9,9));
            Console.ReadKey();
        }
        public static string DGA(long year, long month,long day)
        {
         string domain = "";
         for(int i = 0; i < 15;i++){
		     year = ((year ^ 8 * year) >> 11) ^ ((year & 0xFFFFFFF0) << 17);
		     month = ((month ^ 4 * month) >> 25) ^ 16 * (month & 0xFFFFFFF8);
		     day = (((day ^ day << 13) >> 19) ^ ((day & 0xFFFFFFFE) << 12));
		     domain += Convert.ToChar(((year ^ month ^ day) % 25) + 97);
	       }
         return domain + ".TLD";
        }
    } 
}
