using System.Formats.Asn1;

namespace Classes
{
    internal class Car
    {
        internal int _year;
        internal string _type;
        internal string _colour;
        internal Car() { }

        internal Car(int establishYear, string type, string colour)
        {
            _year = establishYear;
            _type = type;
            _colour = colour;
        }
        internal void EngineOn()
        {
            Console.WriteLine("Автомобиль заведен");
        }
        internal void EngineOff()
        {
            Console.WriteLine("Автомобиль заглушен");
        }
        internal void SetYear(int newYear)
        {
            _year = newYear;
            Console.WriteLine($"Установлен год выпуска: {_year}");
        }
        internal void SetType(string newType)
        {
            _type = newType;
            Console.WriteLine($"Установлен тип кузова: {_type}");
        }
        internal void SetColour(string newColour)
        {
            _colour = newColour;
            Console.WriteLine($"Установлен цвет автомобиля: {_colour}");
        }
        internal void GetCarInfo(int year = 1991, string type = "Universal", string colour = "violet")
        {
            _year = year;
            _type = type;
            _colour = colour;
            Console.WriteLine($"Год выпуска - {_year}{Environment.NewLine}Тип кузова - {_type}{Environment.NewLine}Цвет кузова - {_colour}");
        }
    }
}
