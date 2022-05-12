using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your gasoline amount: ");

            int gasoline = int.Parse(Console.ReadLine());

            Car car = new Car(gasoline);
            car.Drive();

            Console.ReadLine();

        }
    }
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int gasolineToRefuel);
    }
    public class Car : IVehiculo
    {
        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }

        public int Gasoline { get; set; }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Car is Driving.");
            }
            else
            {
                Console.WriteLine("No Gasoline.");
            }
        }

        public bool Refuel(int gasolineToRefuel)
        {
            Gasoline += gasolineToRefuel;
            return true;
        }


    }




}
