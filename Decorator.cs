using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Decorator
    {
    }


    //Idea: Think of a plain ice cream.You can add toppings like chocolate syrup, sprinkles,
    //or nuts. Each topping decorates the ice cream in a different way.
    //The Decorator pattern allows us to add new behavior to objects without changing their structure.

   public  interface IIcecream
    {
        string CreateIceCream();
    }

    public class PlainIceCream:IIcecream
    {

        public PlainIceCream()
        {
                
        }

        public string CreateIceCream()
        {
           return "Plain IceCream Created";
        }
    }


    public class IceCreamChocolate : IIcecream
    {
        private IIcecream _Icecream { get; }

        public IceCreamChocolate( IIcecream icecream)
        {
            _Icecream = icecream;
        }


        public string CreateIceCream()
        {
            return _Icecream.CreateIceCream() + "with Chocolate";
        }
    }


    public class IceCreamVanilla : IIcecream
    {
        private IIcecream _Icecream { get; }

        public IceCreamVanilla(IIcecream icecream)
        {
            _Icecream = icecream;
        }


        public string CreateIceCream()
        {
            return _Icecream.CreateIceCream() + "with VanillA";
        }
    }

}
