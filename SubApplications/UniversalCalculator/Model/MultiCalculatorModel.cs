using OOP7.SubApplications.Calculator.Model;
using OOP7.SubApplications.OneOperationCalculator.Model;

namespace OOP7.SubApplications.UniversalCalculator
{
    public class MultiCalculatorModel : Calc
    {
        private int[] _choices;
        private char[] _symbols;

        public MultiCalculatorModel() : base()
        {
            _choices = new int[Calculations.Length];
            for (int i = 0; i < Calculations.Length; i++)
            {
                _choices[i] = -1;
            }

            _symbols = new char[] { 'X', 'Y', 'Z' };
        }

        public override string GetResult()
        {
            string result = "";
            for (int i = 0; i < _choices.Length; i++)
            {
                if (_choices[i] != -1)
                {
                    
                    result += $"{_symbols[i]}={Calculations[i].Work(Pair)}" + Environment.NewLine;
                }
            }

            return result;
        }

        public override void SetStrategy(int index)
        {
            if (_choices[index] == -1)
            {
                _choices[index] = 0;
            }
            else
            {
                _choices[index] = -1;
            }
        }
    }
}
