using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD
{
    /// <summary>
    /// Это Класс для работы с Автомобилями
    /// </summary>

    public class Car
    {
        public int id;
        public string name ="";
        public string description = "";

        /// <summary>
        /// Это метод, который проверяет ID машины.
        /// </summary>
 
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

        /// <summary>
        /// Это метод, который позволяет дать машине имя.
        /// </summary>


        public void SetCarName (string name)
        { 
            this.name = name;
            Console.WriteLine($"New name: {this.name}");

        }

        /// <summary>
        /// Это метод, который позволяет дать машине описание.
        /// </summary>

        public void SetCarDescription(string description)
        {
            this.description = description;
            Console.WriteLine($"New description: {this.description}");
        }

    }
}
