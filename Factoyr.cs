using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Singleton
{

    //2. Factory Pattern
    //    Idea: Imagine a toy factory where you give it a type of toy you want,
    //    like a car or a doll, and it gives you that toy.
    //    The factory pattern helps us create objects without specifying the exact class of object that will be created
    internal class Factory
    {
       
        
      


    }


    public abstract class Toy
    {
        public abstract void Play();
    }


    public class Car : Toy
    {
        public override void Play()
        {
            Console.WriteLine("Car Created...  Vroom Vroom ");
        }
    }


    public class Doll : Toy
    {
        public override void Play()
        {
            Console.WriteLine("Doll Created...  Dance Dabce");

        }
    }

    public class ToyFactory
    {
        public static Toy CreateToy(string toyname)
        {

            if (toyname.ToUpper() == "Car".ToUpper())
            {
                return new Car();
            }
            else if (toyname.ToUpper() == "Doll".ToUpper())
            {
                return new Doll();
            }
            else
            {
                throw new ArgumentException($"'{nameof(toyname)}' cannot be null or empty.", nameof(toyname));
            }
        }
    }


    public interface IVehicle
    {
        void Describe();
    }

    public class Bike : IVehicle
    {
        public void Describe()
        {
            Console.WriteLine("BIke Created");
        }
    }
    public class Cycle : IVehicle
    {
        public void Describe()
        {
            Console.WriteLine("Cycle Created");
        }
    }


    public  class VehicleFactory
    {

        public static  IVehicle getVechicle(string name)
        {
            switch (name.ToLower())
            {

                case "bike":
                    return new Bike();
                case "cycle":
                    return new Cycle();
                default:
                    throw new ArgumentException("Invalid vehicle type.");

            }
        }
    }



}
