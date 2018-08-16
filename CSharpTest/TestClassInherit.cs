﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试类的继承
namespace CSharpTest
{
    class TestClassInherit
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.Speak();
            pig.Run();
            Console.Read();
        }
    }

    //父类
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("I am an animal.");
        }

        public void Speak()
        {
            Console.WriteLine("animal speaks.");
        }

        public void Run()
        {
            Console.WriteLine("animal runs.");
        }
    }

    //子类
    class Pig : Animal
    {
        public Pig()
        {
            Console.WriteLine("I am a pig.");
        }

        //要用new关键词表示这个是覆盖父类的方法
        public new void Speak()
        {
            Console.WriteLine("pig speaks.");
        }
    }
}
