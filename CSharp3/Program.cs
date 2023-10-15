using System;
using System.Collections;//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array and ArrayList

            // 
            MyMessage();

            // fixed size
            /*
            int[] x = new int[3] { 20, 30, 40 };
            int s = 0;
            for (int i = 0; i < x.Length; i++)
            {
                //s = s + x[i];
                s += x[i];

            }

            Console.WriteLine(s);
            */
            // dynamic Arraylist
            /*
            ArrayList list = new ArrayList();
            list.Add("Ahmed");
            list.Add(20);
            list.Add(new Program());// create ne instance from class by using constructor
            //
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            */


            /*
            ArrayList myArray = new ArrayList();

            string s = "+";
            int n = 0;
           
            while (s=="+")
            {
                Console.WriteLine("Enter The Number");
                n =  int .Parse(Console.ReadLine());
                myArray.Add(n);
                Console.WriteLine("Enter + or =");
                s = Console.ReadLine();

            }

            Console.WriteLine($"The Result Is: {sum(myArray)}"); 
            */

            #endregion


            #region Customer
            /*
            Customer cust = new Customer();
            //Customer is class name
            // cust is instance or object name
            // Customer() constructor name
            // i will use it to create an instance or object from class
            // How????????
            Console.WriteLine(cust.ToString());
            Console.WriteLine(cust.x);

            Customer mycust = new Customer(1, "ali", "Jedda");
            // ho to call non static member
            // by using (instance name)
            Console.WriteLine(mycust.CustomerInfo());
            //

            // call static member by using (class name)
            //Console.WriteLine(Customer.Info());


            Customer c = new Customer();
            Console.WriteLine(c.CustomerInfo2());//
            */


            //Customer cust = new Customer(1, "ss", "ff");
            //Console.WriteLine(cust.CustomerInfo2());
            #endregion

            #region Employee
            /*
            Employee emp = new Employee(1,"Dema","Jedda");
            Console.WriteLine(emp.EmpInfo());
            */
            #endregion

            #region Property

            /*
            Product prod = new Product();
            
            prod.Pid = 1;
            prod.Price = 10.5M;
            prod.PName = "Hard";
            Console.WriteLine(prod.ProductInfo());//
            */
            #endregion

            // collection
            // list
            List<int> mylist = new List<int>();
            mylist.Add(20);
            mylist.Add(30);

            /*
            List<string> students = new List<string>();
            students.Add("AboBaker");
            students.Add("Ali");
            students.Add("Omar");
            students.Add("Othman");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            */


            /*
            List<Product> Products = new List<Product>();

            Products.Add(new Product() {Pid=1,PName="Hard",Price=150 } );
            Products.Add(new Product() { Pid = 2, PName = "Screen", Price = 2000 });
            Products.Add(new Product() { Pid = 3, PName = "Mouse", Price = 20 });
            foreach (var item in Products)
            {
                //Console.WriteLine(item.Pid+" "+item.PName+" "+item.Price);
                Console.WriteLine(item);// override
            }

            */



            Child ch = new Child();
            Parent p = new Parent();
            
        }

        private static int sum(ArrayList list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                s = s + (int)list[i];

            }
            return s;
        }



        private static void  MyMessage()
        {
            Console.WriteLine("wellcome");
            // insert into database
        }


    }
}
