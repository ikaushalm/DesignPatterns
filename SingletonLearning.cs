using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingletonLearning
    {







    }



    //Everytime we try to get instance we get  same instance is known as singleton in this we have to create its 
    // constructor as private
    // lets see


    public class ChocolateMachine
    {
        private static ChocolateMachine _instance;

        // Private constructor so no one can create another machine directly.
        private ChocolateMachine() { }

        // Method to get the single instance of the ChocolateMachine.
        public static ChocolateMachine GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ChocolateMachine();
            }
            return _instance;
        }

        public void MakeChocolate()
        {
            Console.WriteLine("Chocolate is being made!");
        }
    }


    public class Learn_GetSingleton
    {
        private static Learn_GetSingleton _instance;
        private static int instance_counter = 0;



        private Learn_GetSingleton()
        {
            instance_counter++;

        }
        public static Learn_GetSingleton GetInstance()
        {
            if (_instance == null)
            {
              
                return new Learn_GetSingleton();
            }

            return _instance;
        }

        public void testFunction()
        {
            Console.WriteLine("getting same instance");
        }

        public static int GetCounter()
        {
            return instance_counter;
        }

    }

}

