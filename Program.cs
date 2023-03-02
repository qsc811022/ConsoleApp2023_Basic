using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2023
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = new DateTime(2021, 5, 18, 14, 30, 0); // 2021/5/18 下午2點30分

            string result = date.ToString(); // 不好的寫法,因為它包含了 '下午'這類中文字
            Console.WriteLine(result);

            // ref: https://docs.microsoft.com/zh-tw/dotnet/standard/base-types/standard-date-and-time-format-strings
            string result2 = date.ToString("d"); // 實務上比較少這麼寫
            Console.WriteLine(result2);

            string result3 = date.ToString("yyyy/M/d"); // 實務上比較常這麼寫
            Console.WriteLine(result3);

            string result4 = date.ToString("yyyy/MM/dd"); // 實務上比較常這麼寫
            Console.WriteLine(result4);
        }
    }
}
