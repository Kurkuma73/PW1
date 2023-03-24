using System.Reflection;

namespace PW1
{
    class Car
    {
        public double maxSpeed;
        public string carName;
        public Car()
        {
            this.maxSpeed = 180;
            this.carName = "Car Name";
        }
        public Car(double maxSpeed, string carName)
        {
            this.maxSpeed = maxSpeed;
            this.carName = carName;
        }

        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Название автомобиля - {carName}");
            Console.WriteLine($"Максимальная скорость - {maxSpeed}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Car[] cars = new Car[4];

                double distance = 500;

                Car koenigsegg = new Car(400, "Koenigsegg Gemera");
                cars[0] = koenigsegg;
                double koenigseggTime = koenigsegg.CalculateTime(distance);
                koenigsegg.PrintCarInfo();
                Console.WriteLine($"Koenigsegg Divo проходит 100 км за {koenigseggTime}");

                Car lamborghini = new Car(350, "Lamborghini Sian Roadster");
                cars[1] = lamborghini;
                double lamborghiniTime = lamborghini.CalculateTime(distance);
                lamborghini.PrintCarInfo();
                Console.WriteLine($"lamborghini Sian Roadster проходит 100 км за {lamborghiniTime}");

                Car ford = new Car(347, "Ford GT");
                cars[2] = ford;
                double fordTime = ford.CalculateTime(distance);
                ford.PrintCarInfo();
                Console.WriteLine($"Ford GT проходит 100 км за {fordTime}");

                Car ferrari = new Car(340, "Ferrari 812 Superfast");
                cars[3] = ferrari;
                double ferrariTime = ferrari.CalculateTime(distance);
                ferrari.PrintCarInfo();
                Console.WriteLine($"Ferrari 812 Superfast проходит 100 км за {ferrariTime}\n");

                double maxSpeed = 0;

                foreach (Car car in cars)
                {
                    if (car.maxSpeed > maxSpeed)
                    {
                        maxSpeed = car.maxSpeed;
                    }
                }
                Car winner;
                foreach (Car car in cars)
                {
                    if (car.maxSpeed == maxSpeed)
                    {
                        winner = car;
                        Console.WriteLine($"{winner.carName} победил в этой гонке.");
                    }
                }
            }
        }
    }
}