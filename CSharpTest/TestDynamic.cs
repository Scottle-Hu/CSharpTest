using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试dynamic类
namespace CSharpTest
{
    class TestDynamic
    {
        //static void Main(string[] args)
        //{
        //    dynamic dyn = new Dog(12, "Lucy");
        //    ((Dog)dyn).Bark();
        //    Console.ReadKey();
        //    //错误转型，但是dynamic不会在编译的时候检查，而是在运行的时候动态检查
        //    //((Cat)dyn).Miao();  //会运行时抛出异常RuntimeException
        //    //Console.Read();

        //    //但如果是object，则会抛出异常InvalidCastException
        //    object obj = new Dog(12, "Lucy");
        //    ((Dog)obj).Bark();
        //    Console.Read();
        //    //((Cat)obj).Miao();
        //}
    }

    class Cat
    {
        int age;
        string name;

        internal Cat(int age, string name)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine("create a cat, name=" + name + ",age=" + age);
        }

        public void Miao()
        {
            Console.WriteLine("miao miao miao~");
        }
    }
}
