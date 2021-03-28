using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class ChengFa
    {
        /// <summary>
        /// 乘法计算
        /// </summary>
        /// <param name="a">第一个乘数</param>
        /// <param name="b">第二个乘数</param>
        public void Cf()
        {
            int a, b;
            Console.WriteLine("请输入两个数（用回车键隔开）：");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}={3}", a, '*', b, a * b);
            Program.Equals(a, b);
        }
    }
}
