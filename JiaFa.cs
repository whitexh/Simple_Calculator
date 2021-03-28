using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class JiaFa
    {
        /// <summary>
        /// 加法计算
        /// </summary>
        /// <param name="a">第一个加数</param>
        /// <param name="b">第二个加数</param>
        public void Jf()
        {
            int a, b,x;
            string m, n;
            Console.WriteLine("请选择相加的类型：数字相加（0）/字符串相加（1）");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 0) 
            {
                Console.WriteLine("请输入相加的两数：(回车键隔开)");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}{1}{2}{3}", a, '+', b, a + b);
                Program.Equals(a,b);
            }
            else if (x == 1)
            {
                Console.WriteLine("请输入相连的两个字符串：(回车键隔开)");
                m = Convert.ToString(Console.ReadLine());
                n = Convert.ToString(Console.ReadLine());
                Console.WriteLine("{0}{1}{2}{3}{4}", m,"->", n, "= ",m + n);
                Program.Equals(m, n);
            }
        }
    }
}
