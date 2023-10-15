using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Employee
    {
        private int id;
        private string name;
        private string address;

        public Employee()
        {
            // default
        }

        public Employee(int id,string name,string address)
        {

            // to use any fields in the class level with the same name in parameters
            // we must use (this) keyword
            this.id = id;
            this.name = name;
            this.address = address;

        }
        public string EmpInfo()
        {
            return $"Employee Data Is  {id} {name} {address}";
        }
    }
}
