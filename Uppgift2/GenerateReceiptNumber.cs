using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class GenerateReceiptNumber
    {
        public static int GetMaxReceiptNumber()
        {

            DateTime d = DatesofReceipts()[DatesofReceipts().Count - 1];
            string xs = d.ToString(("yyyyMMdd"));

            string path = $@"C:..\..\Kvitto_{xs}.txt";

            List<int> numbers = new List<int>();

            int max = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                List<string> content = new List<string>();
                while (true)
                {
                    line = sr.ReadLine();
                    content.Add(line);

                    if (line == null)
                    {
                        line = sr.ReadLine();

                    }
                    line = sr.ReadLine();
                    content.Add(line);
                    if (line == null) break;

                }

                foreach (var item in content)
                {
                    if (item == null || item.Contains("kivttonumber:"))
                    {
                        if (item == null) { break; }
                        string x = "";

                        x = item.Remove(0, 13);
                        int y = int.Parse(x);
                        numbers.Add(Convert.ToInt32(y));
                    }
                }


            }
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;

        }

        public static bool CreateFirstNumber()
        {
            string[] filePaths = Directory.GetFiles(@"C:..\..\", "*.txt");
            if (filePaths.Length == 0) return true;
            else return false;
        }
        public static List<DateTime> DatesofReceipts()
        {
            string[] filePaths = Directory.GetFiles(@"C:..\..\", "*.txt");

            List<DateTime> dates = new List<DateTime>();
            foreach (var item in filePaths)
            {
                string x = "";
                x = item.Remove(0, 15);
                x.Remove(9, 3);
                string b = string.Empty;

                for (int i = 0; i < x.Length; i++)
                {
                    if (Char.IsDigit(x[i]))
                        b += x[i];
                    if (i == 3)
                    {
                        b += "/";
                    }
                    if (i == 5)
                    {
                        b += "/";
                    }

                }

                DateTime dateTime = DateTime.Parse(b);
                dates.Add(dateTime);

            }

            dates.Sort((a, b) => a.CompareTo(b));
            return dates;
        }

    }


}
