using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            day = GetInt("Enter day of your birthday => ");
            month = GetInt("Enter month of your birthday => ");
            year = GetInt("Enter year of your birthday  => ");

            int days = (2018 - year) * 365;
            days += (2018 - year) / 4;

            switch (month)
            {
                case 12:
                    days += 30; //30 days in nowember;
                    goto case 11;
                case 11:
                    days += 31; //31 days in october;;
                    goto case 10;
                case 10:
                    days += 30; //30 days in september;
                    goto case 9;
                case 9:
                    days += 31; //31 days in august;
                    goto case 8;
                case 8:
                    days += 31; //30 days in july;
                    goto case 7;
                case 7:
                    days += 30; //30 days in june;
                    goto case 6;
                case 6:
                    days += 31; //31 days in may;
                    goto case 5;
                case 5:
                    days += 30; //30 days in april;
                    goto case 4;
                case 4:
                    days += 31; //31 days in march;
                    goto case 3;
                case 3:
                    days += (year % 4 == 0) ? 29 : 28; //february;
                    goto case 2;
                case 2:
                    days += 31; //31 days in january;
                    goto case 1;
                case 1:
                    days += day;
                    break;
            }

            Console.WriteLine("Days you living: {0}", days);

            double Bfiz = (Math.Sin(2* Math.PI *days / 23)) * 100;
            double Bemoc = (Math.Sin(2 *Math.PI *days / 28)) * 100;
            double intel = (Math.Sin(2 * Math.PI * days / 33)) * 100;
            Console.WriteLine("Physical biorhythm phase {0:0.0} %", Bfiz);
            Console.WriteLine("Emotional Biorhythm Phase {0:0.0} %", Bemoc);
            Console.WriteLine("Phase of intellectual biorhythm {0:0.0} %", intel);
            Console.ReadKey();
        }

        private static int GetInt(string quastion)
        {
            int res;
            do
            {
                Console.Write(quastion);
            }
            while (!int.TryParse(Console.ReadLine(), out res));
            return res;
        }

    }
}


