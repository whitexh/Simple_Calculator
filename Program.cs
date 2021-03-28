using System;

namespace Work4
{
    class Program
    {
        static void Equals(int a, int b)
        {
            if (a == b)
                Console.WriteLine("两数相等");
            else
                Console.WriteLine("两数不相等");
        }
        static void Main(string[] args)
        {
            int x;
            char c;
            Console.WriteLine();
            JiaFa jf = new();
            JianFa jnf = new();
            ChengFa cf = new();
            ChuFa cuf = new();
            do
            {   /*输入运算符号*/
                do
                {
                    Console.WriteLine("请先输入运算符号：");
                    c = Convert.ToChar(Console.ReadLine());
                }
                while (c == '+' && c == '-' && c == '*' && c == '/');
                Console.WriteLine();
                /*运算符号判断*/
                switch (c)
                {
                    case '+':
                        jf.Jf();
                        break;
                    case '-':
                        jnf.Jnf();
                        break;
                    case '*':
                        cf.Cf();
                        break;
                    case '/':
                        cuf.Cuf();
                        break;
                    default:
                        Console.WriteLine("运算符号错误");
                        break;
                }
                /*是否继续计算判断*/
                Console.WriteLine("Make a choice :  continue（1） / exit（0）");
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                while (x == 1 && x == 0);
            } while (x == 1);
        }
    }
}
