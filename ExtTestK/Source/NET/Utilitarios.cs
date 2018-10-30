using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssExtTestK
{
    public class Utilitarios
    {
        public int __RandonNumber(int a, int b)
        {
            Random random = new Random();
            return (int) ((random.NextDouble() * (a - b)) + a);
        }
    }
}
