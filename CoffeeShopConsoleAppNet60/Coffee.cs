using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee //base class
    {

        //public int Price();
        //public string Strength();
        //public int Discount();

        public virtual int Price()
        {
            return 20;
        }

        public abstract string Strength();
        

    }
}
