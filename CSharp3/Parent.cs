using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Parent
    {
        private int x = 10;
        public int y = 20;
        protected int z = 30;

        public int sum()
        {
            return x + y + z;
        }
    }

}
