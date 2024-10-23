using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD
{
    public class Car
    {
        public int id;
        public string name ="";
        public string description = "";

        public bool CheckID()
        {
            if (this.id <= 0)
            {
                Console.WriteLine("Wrong ID");
                return true;
            }
            else
            {
                Console.WriteLine("Good ID");
                return false;
            }
        }

        public void SetCarName ()
        {
            Console.WriteLine("Enter new Name:");
            this.name = Console.ReadLine();
            Console.WriteLine($"New name: {this.name}");
        }
    }
}
