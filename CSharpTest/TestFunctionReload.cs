using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试c#的方法重载
namespace CSharpTest
{
    class TestFunctionReload
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("add two nums:" + Add(1, 2));
        //    Console.WriteLine("add three nums:" + Add(1, 2, 3));
        //    Console.Read();
        //}

        //两个参数的Add方法
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //三个参数的Add方法
        static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
