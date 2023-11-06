namespace Classes
{
    static class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
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
                            Math add = new Math();


                    }
                    string flavour = inputString;
                    Soda soda = new Soda(flavour);
                    soda.OutputFlavour();
                }
            }
        }
    }