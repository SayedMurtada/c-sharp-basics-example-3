using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Customer
    {

        // constructor 
        // oveload constructor

        // static and non static
        // how to create instance from class





        public Customer()
        {
            //default constructor
       
        }
        
        public int x;
        private int y = 0;


        // on class level
        private   int _id;
        private  string _name;
        private  string _address;

        public Customer(int id,string name,string address)
        {
            // overload constructor
            // on methgod level
            _id = id;
            _name = name;
            _address = address;
        }

        public  string CustomerInfo()
        {

            return "Customer Info is: "+_id + " " + _name + " " + _address;
        }


        public string CustomerInfo2()
        {

            return "Customer Info is: " + _id + " " + _name + " " + _address;
        }


        //public static string Info()
        //{

        //    return "Customer Info is: " + _id + " " + _name + " " + _address;
        //}

    }
}
