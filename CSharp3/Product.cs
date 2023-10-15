using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Product
    {
        private int pid;
        private string pName;
        private decimal price;


        //read and write get and set
        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ProductInfo()
        {
            return pid + " " + pName+" "+price;
        }

        public override string ToString()
        {
            // change in function behavior 
            //hide in this class
            return pid + " " + pName + " " + price; 
        }

    }
}
