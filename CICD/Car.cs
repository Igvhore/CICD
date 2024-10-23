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

        public void SetCarName (string name)
        { 
            this.name = name;
            Console.WriteLine($"New name: {this.name}");
        }

        public void SetCarDescription(string description)
        {
            this.description = description;
            Console.WriteLine($"New description: {this.description}");
        }

    }
}
