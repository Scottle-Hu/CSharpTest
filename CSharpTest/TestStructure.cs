using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试结构体
namespace CSharpTest
{
    class TestStructure
    {
        //static void Main(string[] args)
        //{
        //    //测试结构体
        //    MyStruct myStruct = new MyStruct(10, "string");
        //    myStruct.Display();
        //    //调用函数操作值
        //    OperateStruct(myStruct);
        //    myStruct.Display();
        //    MyStruct m2;  //只声明，可以不用调用构造方法，如此只要所有字段都有值即可自动创建
        //    m2.num = 12;
        //    m2.name = "name";
        //    m2.Display();
        //    Console.Read();

        //}

        //操作结构体参数的值，结构体是按值传递的,所以不会改变
        static void OperateStruct(MyStruct s)
        {
            s.num++;
            s.name += "_new";
        }
    }

    //定义结构体
    //结构体和类的区别：
    //①结构体作为参数是按值传递的；②结构体不能重写无参构造；③结构体可以不用new实例；
    //④结构体可以实现接口但是不能继承类；⑤结构体不能作为其他结构体或者类的成员变量
    struct MyStruct
    {
        internal int num;
        internal string name;

        //有参构造
        public MyStruct(int num, string name)
        {
            this.num = num;
            this.name = name;
        }

        //成员方法
        public void Display()
        {
            Console.WriteLine("name:" + name + ",num:" + num);
        }
    }

}
