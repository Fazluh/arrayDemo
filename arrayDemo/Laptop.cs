using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayDemo
{
    internal class Laptop
    {
        int _ram;
            public int Ram { get { return _ram;} set{_ram =value ;} }

        private decimal _price;

        public decimal Price
        {
            get 
            { 
            return _price; 
            }
            set 
            { 
            _price = value;
            }
        }



        static void Main(string[] args)
        {
            Laptop hp = new Laptop();
            hp.Ram = 100;
            Console.WriteLine(hp.Ram);

            Console.ReadLine();
        }
    }
}
