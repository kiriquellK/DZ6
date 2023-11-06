namespace Classes
{
    internal class Math
    {
        internal double _firstOperand;
        internal double _secondOperand;

        public Math() { }
        public Math(double firstOperand, double secondOperand)
        {
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
        }
        internal void Add()
        {
            double resultAdd = _firstOperand + _secondOperand;
            Console.WriteLine($"Результат сложения:{resultAdd}");
        }
        internal void Subtract()
        {
            double resultSubtract = _firstOperand - _secondOperand;
            Console.WriteLine($"Результат вычитания:{resultSubtract}");
        }
        internal void Multiply()
        {
            double resultMultiply = _firstOperand * _secondOperand;
            Console.WriteLine($"Результат умножения:{resultMultiply}");
        }
        internal void Divide()
        {
            double resultDivide = _firstOperand / _secondOperand;
            Console.WriteLine($"Результат деления:{resultDivide}");
        }
    }
}
