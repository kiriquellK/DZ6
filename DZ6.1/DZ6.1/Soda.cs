namespace Classes
{
    internal class Soda
    {
        private string _flavour;
        public Soda()
        {

        }
        public Soda(string flavour)
        {
            _flavour = flavour;
        }
        internal void OutputFlavour()
        {
            Console.WriteLine($"У вас газировка с {_flavour} вкусом");
        }
    }
}
