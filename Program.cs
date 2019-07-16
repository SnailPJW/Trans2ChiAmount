using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ref : JS (https://gist.github.com/tonyc726/00c829a54a40cf80409f)
namespace Trans2ChiAmount
{
    class Program
    {
        static string[] digit = {
            "零","壹","貳","參","肆"
           ,"伍","陸","柒","捌","玖"
        };
        //不規則陣列 宣告時直接初始化
        static string[][] unit = {
            new []{"元","萬","億" },
            new []{"","拾","佰","仟"}
        };
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Keyin an amount: ");
                double amount;
                double.TryParse(Console.ReadLine(), out amount);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        static void ShiftRight(double number,int digit) {
            //int.TryParse(digit, out digit);
        }
    }
}
