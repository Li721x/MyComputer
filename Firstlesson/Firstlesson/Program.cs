//引用系统的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstlesson
{
    class Program
    {
        //Main方法，是整个程序的入口，程序从这里开始执行
        static void Main(string[] args)
        {
            //一、注释
            //1、单行注释 --双斜杠，注释的内容只有一行
            //作用：对代码起到解释说明的作用
            //输一行hello，world

            /*2、多行注释
             * 注释分类：单行注释、多行注释、文档注释
             * 添加注释是一个优秀的程序员的必备技能
             * 多行注释允许你使用换行
             * 中间内容前面*可以删除
             * 多行注释里面可以嵌套单行注释，但是不能再次放入多行注释。
            */

            ///文档注释 以后学习

            /*快捷键
             * ctrl + A:全选
             * ctrl + C:复制 
             * ctrl + V:粘贴
             * ctrl + Z:撤销
             * ctrl + S:保存
             * ctrl + shift + Z:反撤销
             * ctrl + F:查找
             * ctrl + 方向键:快速移动光标
             * 单击:移动光标
             * 双击:选中某一个词
             * 三击:选中某一行
             * alt  + 方向键:可以移动整行代码的位置
             * ctrl + k,ctrl + f:自动整理选中的代码
             */

            Console.WriteLine("Hello,world!");

            //二、数据类型
            /*
             关键字        说明            字节大小
             bool        逻辑真/假            1
             sbyte      有符号8位整数         1
             byte       无符号8位整数         1
             short      有符位16位整数        2
             ushort     无符号16位整数        2
             int        有符号32位整数        4
             uint       无符号32位整数        4
             long       有符号64位整数        8
             ulong      无符号64位整数        8
             char         16位字符            2
             float      32位单精度浮点        4
             double     64位双精度浮点        8
             decimal    128位高精度浮点       16
             string         字符串
             */



            //三、常量变量
            /*
             1、常量：程序运行期间，不能被改变得量。
             2、变量：程序运行期间，可以被改变的量，本质是一个储存空间，
             之所以可以改变，是存储空间中的内容在变。
             变量在使用之前必须先要定义。
             定义的格式： 
             数据类型 变量名 = 初始值;
             数据类型：规定该变量空间的大小，以及可以存储的数据的类型。
             变 量 名：给变量起个名字，起到唯一标示的作用。
                =    ：赋值号，将赋值号右侧的值赋给左边的变量，赋值的过程就是拷贝的过程。
             初 始 值：这块变量空间里最初始放的值。
             命名规则：
             1、由数字、字母、下划线、@组成，数字不能放开头，@只能放开头
             2、同一作用域，不允许定义同名的变量
             3、不能使用系统关键字命名
             4、命名要见名知义
             5、使用驼峰命名法
             */
            int age = 18;
            age = 30;
            int num = 5;
            int numOfEnemyInScene = 100;//驼峰命名法
            Console.WriteLine(age);


            //定义字符型变量，名字为a，赋值初始值为a
            //定义单精度浮点型变量，名字为b，赋值初始值为3.14f
            //定义双精度浮点型变量，名字为c，赋值初始值为3.1415
            //定义字符串类型变量，名字为name，赋值初始值为PDD

            //要求输出以上定义的变量

            char a = 'a';
            float b = 3.14f;
            double c = 3.1415;
            string name = "PDD";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(name);

            //定义一个bool类型变量
            bool isDead = true;
            isDead = false;


            //四、基本输出函数的使用
            /*使用Console类调用WriteLine方法进行输出
             */
            //Console.WriteLine("这是一个可以自动换行的输出");
            //Console.Write("这个输出不会换行");
            //Console.WriteLine("这是第三个输出");
            Console.WriteLine("天苍苍野茫茫，\n我坐隔壁我姓王");
            Console.WriteLine("天苍苍\\野茫茫，\n我坐隔壁我姓王");
            Console.WriteLine("天苍苍\"野茫茫\"，\n我坐隔壁我姓王");

            /*转义字符
             * \n:换行
             * \\：打印\
             * \特殊符号：打印特殊符号
             */



            //练习
            //输出：    *
            //         * *
            //        * * *


            string e = "  *";
            string f = " * *";
            string g = "* * *";
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("  *\n * *\n* * *");
            Console.WriteLine("{0}\n{1}\n{2}",e,f,g);

            int score = 100;
            Console.Write("XXX的分数是：");
            Console.Write(score);
            Console.Write("分！！！！");

            score = 50;
            Console.WriteLine("XXX的分数是：{0}分！！！！",score);
            Console.WriteLine("我叫：{0},我考了{1}分！！！！",name,score);
            /*总结：大括号表示占位符，大括号中要有一个索引号，索引是从0开始，
             * 不能使用超出范围的索引
             */

            //练习：定义整形变量num1,赋值8，定义num2赋值4，要求通过变量输出：8是4的倍数
            int sum = 12;
            int num1 = 8;
            int num2 = 4;
            Console.WriteLine("{0}是{1}的倍数",num1,num2);


            //格式化输出
            double h = 23.56789, i = 0.5667;
            //1、控制整数位和小数位
            Console.WriteLine("h={0:000.000}",h);
            Console.WriteLine("i={0:000.000}",i);
            //2、保留小数位
            Console.WriteLine("h={0:f3},i={1:f2}",h,i);
            //3、转化为百分数
            Console.WriteLine("h={0:p0},i={1:p2}",h,i);


            //五、运算符
            /*
            1、= 赋值运算符
            2、算术运算符：+、-、*、/、%、++、--
             */
            sum = num1 + num2;
            num1 = 9;
            num2 = 10;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);


            //保证当前程序执行完成不退出
            Console.ReadKey();

        }
    }
}
