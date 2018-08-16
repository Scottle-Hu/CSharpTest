using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//测试运算符的重载
namespace CSharpTest
{
    class TestOperatorReload
    {
        //static void Main()
        //{
        //    MyVector v1 = new MyVector(1, 2, 3);
        //    MyVector v2 = new MyVector(1, 1, 2);
        //    v1.DisplayVector();
        //    v2.DisplayVector();
        //    MyVector sumVector = v1 + v2;
        //    sumVector.DisplayVector();
        //    MyVector minusVector = v1 - v2;
        //    minusVector.DisplayVector();
        //    MyVector nagtiveVector = -v1;
        //    nagtiveVector.DisplayVector();
        //    MyVector multiVector = v1 * v2;
        //    multiVector.DisplayVector();
        //    Console.Read();
        //}
    }

    class MyVector
    {
        public double x;
        public double y;
        public double z;

        //无参构造函数，创建零向量
        public MyVector()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public MyVector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //重载向量加法运算
        public static MyVector operator+ (MyVector v1, MyVector v2)
        {
            MyVector result = new MyVector();
            result.x = v1.x + v2.x;
            result.y = v1.y + v2.y;
            result.z = v1.z + v2.z;
            return result;
        }

        //重载向量减法运算
        public static MyVector operator- (MyVector v1, MyVector v2)
        {
            return new MyVector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        //重载向量取负运算，和上面函数不同在于是一元 - 运算符
        public static MyVector operator -(MyVector v)
        {
            return new MyVector(-v.x, -v.y, -v.z);
        }

        //重载向量乘法运算
        public static MyVector operator* (MyVector v1, MyVector v2)
        {
            return new MyVector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        //打印向量值
        public void DisplayVector()
        {
            Console.WriteLine("(" + x + "," + y + "," + z + ")");
        }
    }
}
