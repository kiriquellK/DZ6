namespace Classes
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вкус газировки");
            string inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("У вас обычная газировка");
            }
            else
            {
                string flavour = inputString;
                Soda soda = new Soda(flavour);
                soda.OutputFlavour();
            }
        }
    }
}