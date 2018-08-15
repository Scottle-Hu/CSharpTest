using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 测试c#的类，包括成员变量，成员方法和实例初始化等
 */
namespace CSharpTest
{
    class TestClass
    {
        //static void Main(String[] args)
        //{
        //    Dog dog = new Dog(12, "Lucky");
        //    dog.Bark();
        //    Console.Read();
        //}
    }

    /*
     * 创建一个类
     */
    class Dog
    {
        int age;
        string name;

        //构造方法
        public Dog(int age, string name)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine("create a dog with age=" + age + ",name=" + name);
        }

        //成员方法
        public void Bark()
        {
            System.Console.WriteLine("wang wang wang~");
        }

    }
}
