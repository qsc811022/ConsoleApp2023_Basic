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

			//DateTime date = new DateTime(2021, 5, 18, 14, 30, 0); // 2021/5/18 下午2點30分

			//string result = date.ToString(); // 不好的寫法,因為它包含了 '下午'這類中文字
			//Console.WriteLine(result);

			//// ref: https://docs.microsoft.com/zh-tw/dotnet/standard/base-types/standard-date-and-time-format-strings
			//string result2 = date.ToString("d"); // 實務上比較少這麼寫
			//Console.WriteLine(result2);

			//string result3 = date.ToString("yyyy/M/d"); // 實務上比較常這麼寫
			//Console.WriteLine(result3);

			//string result4 = date.ToString("yyyy/MM/dd"); // 實務上比較常這麼寫
			//Console.WriteLine(result4);

			int a = 100;
			Console.WriteLine("C");
			Console.WriteLine(a.ToString("c"));
			Console.WriteLine(a.ToString("c0"));

			Console.WriteLine("D");
			Console.WriteLine(a.ToString("d"));
			Console.WriteLine(a.ToString("d5"));

			double b = 12.345;
			Console.WriteLine("F");
			Console.WriteLine(b.ToString("f"));
			Console.WriteLine(b.ToString("f1"));
			Console.WriteLine(b.ToString("f3"));
			Console.WriteLine(b.ToString("f4"));

			b = 1234567890.78;
			Console.WriteLine("N");
			Console.WriteLine(b.ToString("n"));
			Console.WriteLine(b.ToString("n1"));
			Console.WriteLine(b.ToString("n0"));

			b = 0.1234567;
			Console.WriteLine("P");
			Console.WriteLine(b.ToString("p"));
			Console.WriteLine(b.ToString("p1"));
			Console.WriteLine(b.ToString("p2"));
			b = 0.5;
			Console.WriteLine(b.ToString("p2"));

		}
    }
}
