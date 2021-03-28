using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class ChuFa
    {
        /// <summary>
        /// 除法计算
        /// </summary>
        /// <param name="a">被除数</param>
        /// <param name="b">除数</param>
        public void Cuf()
        {
            float a, b;
            Console.WriteLine("请输入两个数（用回车键隔开）：");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("除数不能为0");
                return;
            }
            Console.WriteLine("{0}{1}{2}={3}", a, '/', b, a / b);
            Program.Equals(a, b);
        }
    }
}
