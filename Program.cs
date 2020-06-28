using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._6._20
{
    class Program
    {
        public static void PrintVehicle(Vehice vehice)
        {
            Console.WriteLine($"model {vehice._model}");
            Console.WriteLine(vehice.ToString());
        }

        public static void PrintVehicle(Vehice[] vehices)
        {
            for (int i = 0; i < vehices.Length; i++)
            {
                PrintVehicle(vehices[i]);
            }
        }

        static void Main(string[] args)
        {
            Car carA = new Car();
            carA._model = "Honda_s345";
            carA._numberOfDoors = 4;
            carA._numberOfWheels = 4;

            Console.WriteLine(carA.ToString());

            Car carB = new Car();
            carB._model = "Honda_s378";
            carB._numberOfDoors = 4;
            carB._numberOfWheels = 4;

            Console.WriteLine(carB.ToString());

            Motorcycle MotorcycleA = new Motorcycle();
            MotorcycleA._model = "788345";
            MotorcycleA._numberOfWheels = 2;
            MotorcycleA._numberOfHandBreakes = 2;

            Console.WriteLine(MotorcycleA.ToString());

            Motorcycle MotorcycleB = new Motorcycle();
            MotorcycleB._model = "78643 5";
            MotorcycleB._numberOfWheels = 2;
            MotorcycleB._numberOfHandBreakes = 2;

            Console.WriteLine(MotorcycleB.ToString());
            Vehice[] vehices = new Vehice[3];
            vehices[0] = carA;
            vehices[1] = carB;
            vehices[2] = MotorcycleA;

            PrintVehicle(vehices);

            Vehice[] carrier_arr = new Vehice[2];
            carrier_arr[0] = carA;
            carrier_arr[1] = MotorcycleA;
            Carrier carrier = new Carrier();
            carrier.arr = carrier_arr;
            Console.WriteLine(carrier.ToString());
            
            Console.ReadLine();

        }
    }
}
