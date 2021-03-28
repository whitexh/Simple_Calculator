using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    class JianFa
    {
        /// <summary>
        /// 减法计算
        /// </summary>
        /// <param name="a">减数</param>
        /// <param name="b">被减数</param>
        public void Jnf()
        {
            int a, b, x;
            string m, n;
            string c = "";
            Console.WriteLine("请选择相减的类型：数字相减（0）/字符串相减（1）");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("请输入相加的两数：(回车键隔开)");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}{1}{2}={3}", a, '-', b, a - b);
                Program.Equals(a, b);
            }
            else if (x == 1)
            {
                Console.WriteLine("请输入相减的两个字符串：(回车键隔开)");
                m = Convert.ToString(Console.ReadLine());
                n = Convert.ToString(Console.ReadLine());
                void deleteString(String m, String n)
                {
                    if (m == null || n == null)
                    {
                        Console.WriteLine("调用m,n皆为空的m的值："+m);
                    }
                    else
                    {
                        for (int i = 0; i < m.Length; i++)
                        {
                            int index = 0;
                            //循环确定str1中与str2中字符相同的字符下标
                            /*IndexOf查找字串中指定字符或字串首次出现的位置,返首索引值*/
                            //while ((index = m.IndexOf(n.Substring(i))) != -1)
                            for (index = 0; index < n.Length; index++)
                            {
                                if (m[i] == n[index])
                                {
                                    for(int x = 0; x < i; x++)
                                    {
                                        c += m[x];
                                        //Console.WriteLine("for中c值："+c);
                                    }
                                    //Console.WriteLine("截取相等字符位置之后的字符串："+m.Substring(i+1));
                                    //Console.WriteLine("删除的字符前的字符串：" + c);
                                    c = c + m.Substring(i+1);
                                    m = c;
                                    //Console.WriteLine("删除后的m为：" + c);
                                }
                                #region
                                /*if(m.Substring(i)==n.Substring(index))
                                {
                                    //删除字符
                                    m = m.Substring(0, i) + m.Substring(i);
                                }*/
                                #endregion
                            }
                        }
                        Console.WriteLine("删除后的m为：" + c);
                        //Console.WriteLine("else调用");
                    }
                }
                deleteString(m, n);
                Program.Equals(m, n);
            }
        }
    }
}
