namespace Classes
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Введите первое число:");
                bool isfirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
                if (!isfirstNumber)
                {
                    Console.WriteLine("Некорректное первое число");
                }
                else
                {
                    Console.WriteLine("Введите второе число:");
                    bool isSecondNumber = double.TryParse(Console.ReadLine(), out double secondNumber);
                    if (!isSecondNumber)
                    {
                        Console.WriteLine("Некорректное второе число");
                    }
                    else
                    {
                        Console.WriteLine($"Выберите действие:{Environment.NewLine}1 - Сложение{Environment.NewLine}2 - Вычитание{Environment.NewLine}3 - Умножение{Environment.NewLine}4 - Деление");
                        bool isInputNumber = int.TryParse(Console.ReadLine(), out int inputNumber);
                        if (!isInputNumber)
                        {
                            Console.WriteLine("Некорректный выбор");
                        }
                        else
                        {
                            switch (inputNumber)
                            {
                                case 1:
                                    Math add = new Math(firstNumber, secondNumber);
                                    add.Add();
                                    break;
                                case 2:
                                    Math subtract = new Math(firstNumber, secondNumber);
                                    subtract.Subtract();
                                    break;
                                case 3:
                                    Math multiply = new Math(firstNumber, secondNumber);
                                    multiply.Multiply();
                                    break;
                                case 4:
                                    Math divide = new Math(firstNumber, secondNumber);
                                    divide.Divide();
                                    break;
                                default:
                                    Console.WriteLine($"Введенные числа:{firstNumber},{secondNumber}");
                                    break;
                            }
                        }
                        isContinue = false;
                    }
                }
            }
        }
    }
}