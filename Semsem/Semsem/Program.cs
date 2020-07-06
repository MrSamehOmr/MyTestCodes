using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Semsem
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1;
            num1 = 5;
            string Stname;
            Stname = "Sameh";
            char c;
            c = 'A';
            char S1 = '\u0053';
            double mynum = 12.456;
            const int months = 12;
            Console.WriteLine("Welcome to Egypt");
            //Console.WriteLine("================");
            //هذا الكود لطباعة كلمة الترحيب
            //this line for print hello
            /*
             * Comment1
             * Comment2
             * Comment3
             * */
            String str1 = "Hello";
            String str2 = " ";
            String str3 = "Sameh";
            String strAll = str1 + str2 + str3;
            String strname = "Sameh"
               + " "
               + "Omar"
               + ","
               + "Love"
               + ","
               + " "
               + "Shahd";
            String strname2 = "Sama";
            int num10 = 123;
            int num11 = 15;
            int num12 = 22;
            int rr=num11+num12;

            Console.WriteLine("Hello");
            Console.WriteLine("================");
            Console.WriteLine(S1); // لطباعة اليونى كود
            Console.WriteLine("================");
            Console.WriteLine(123);
            Console.WriteLine("================");
            Console.WriteLine(num1);
            Console.WriteLine("================");
            Console.WriteLine(Stname);
            Console.WriteLine("================");
            Console.WriteLine(c);
            Console.WriteLine("================");
            Console.WriteLine(mynum);
            Console.WriteLine("================");
            Console.WriteLine(months);
            Console.WriteLine("================");
            Console.WriteLine("int");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sizeof(int));
            Console.WriteLine("================");
            Console.WriteLine("Decimal");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine("================");
            Console.WriteLine("byte");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sizeof(byte));
            Console.WriteLine("================");
            Console.WriteLine("float");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(sizeof(float));
            Console.WriteLine("================");
            Console.WriteLine("char");
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(sizeof(char));
            Console.WriteLine("================");           
            Console.WriteLine("bool size");
            Console.WriteLine(sizeof(bool));
            Console.WriteLine("================");
            Console.WriteLine(S1);
            Console.WriteLine("================");
            Console.WriteLine(str1 + str2 + str3);
            Console.WriteLine("================");
            Console.WriteLine(strAll);
            Console.WriteLine("================");
            Console.WriteLine("Welcome" + " " + "to" + " " + "Egypt");
            Console.WriteLine("================");
            Console.WriteLine(strname);
            Console.WriteLine("================");
            Console.WriteLine(strname2 + " " + num10);
            Console.WriteLine("================");
            Console.WriteLine(rr);
            Console.WriteLine("================");
            Console.WriteLine(10 % 3); /// Mod %
        }
    }
}
