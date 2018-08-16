using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试接口
namespace CSharpTest
{
    class TestInterface
    {
        static void Main(string[] args)
        {
            CanSpeak speak = new People();
            speak.Speak();
            CanRun run = new People();
            run.Run();
            Console.Read();
        }
        
    }

    //接口
    interface CanSpeak
    {
        //方法定义
        void Speak();  
    }

    //另一个接口
    interface CanRun
    {
        void Run();
    }

    //实现两个接口
    class People : CanSpeak, CanRun
    {
        //实现run方法
        public void Run()
        {
            Console.WriteLine("I can run.");
        }

        //实现方法speak
        public void Speak()
        {
            Console.WriteLine("I can speak.");
        }
    }

}
