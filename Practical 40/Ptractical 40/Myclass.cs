using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptractical_40
{
    public partial class Myclass
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }
    }
    public partial class Myclass
    {
        public int Sub(int x, int y)
        {
            return (x - y);
        }
    }
    public class Testclass
    {
        public void Test()
        {
            Console.WriteLine("Adnan Mangaonkar 333");
            Myclass Omyclass = new Myclass();
            Omyclass.Add(10, 20);
            Omyclass.Sub(25, 5);
        }
    }
}
