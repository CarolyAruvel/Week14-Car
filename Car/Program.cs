using System;

namespace Car
{
    class Program
    {
        class Car
        {


            string mark;
            string model;
            string regNumber;
            string color;
            int odometer;
            int fueltank;

            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odometer = 0;
                fueltank = 60;

                Console.WriteLine($"{mark} {model} {regNumber} has been created");
            }
            public int FuelTank
            {
               get { return fueltank; }
            }


            public void Drive()
            {
                fueltank -= 5;
                odometer += 100;
                Console.WriteLine("Vroom-Vroom");
            }

            public void ShowCarData()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"model: { model}");
                Console.WriteLine($"regNumber: {regNumber}");
                Console.WriteLine($"color: {color}");
                Console.WriteLine($"odometer: {odometer}");
                Console.WriteLine($"fueltank: {fueltank}");
            }

        }

        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "3 Series", "777BTJ", "White");

            while (myCar.FuelTank > 0)
            {
                myCar.Drive();
            }

            myCar.ShowCarData();
        }
    }
}
