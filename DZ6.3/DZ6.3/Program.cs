using System.Formats.Asn1;

namespace Classes
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine($"Выберите действие над автомобилем:{Environment.NewLine}0 - Завести автомобиль{Environment.NewLine}1 - Заглушить автомобиль{Environment.NewLine}2 - Установить год выпуска автомобиля{Environment.NewLine}3 - Установить тип кузова автомобиля{Environment.NewLine}4 - Установить цвет автомобиля");
                bool isInputNumber = int.TryParse(Console.ReadLine(), out int actionNumber);
                if (!isInputNumber)
                {
                    Console.WriteLine("Некорректый выбор");
                }
                else
                {
                    switch (actionNumber)
                    {
                        case 0:
                            Car start = new Car();
                            start.EngineOn();
                            start.GetCarInfo();
                            break;
                        case 1:
                            Car off = new Car();
                            off.EngineOn();
                            off.GetCarInfo();
                            break;
                        case 2:
                            Console.WriteLine("Введите год выпуска");
                            bool isInputYear = int.TryParse(Console.ReadLine(), out int actualYear);
                            if (isInputYear)
                            {
                                Car setYear = new Car();
                                setYear.SetYear(actualYear);
                            }
                            else
                            {
                                Console.WriteLine("Введен некорректный год выпуска");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите тип кузова");
                            string inputType = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(inputType))
                            {
                                string type = inputType;
                                Car setType = new Car();
                                setType.SetType(type);
                            }
                            else
                            {
                                Console.WriteLine("Введен некорректный тип кузова");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Введите цвет кузова");
                            string inputColour = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(inputColour))
                            {
                                string colour = inputColour;
                                Car setColour = new Car();
                                setColour.SetColour(colour);
                            }
                            else
                            {
                                Console.WriteLine("Введен некорректный цвет кузова");
                            }
                            break;
                        default:
                            Car defaultCar = new Car(1991, "Universal", "Violet");
                            defaultCar.GetCarInfo();
                            isContinue = false;
                            break;
                    }
                }
            }
        }
    }
}