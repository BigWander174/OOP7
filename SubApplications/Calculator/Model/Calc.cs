using OOP7.SubApplications.Calculator.Interface;

namespace OOP7.SubApplications.Calculator.Model
{
    public abstract class Calc
    {
        protected Tuple<double, double> Pair;
        protected ICalculation[] Calculations;

        public Calc()
        {
            Pair = new Tuple<double, double>(0.0, 0.0);
            Calculations = new ICalculation[]
            {
                new Adder(),
                new Divider(),
                new Multiplier()
            };
        }

        public void Set(string number1, string number2)
        {
            try
            {
                Pair = Tuple.Create(Convert.ToDouble(number1), Convert.ToDouble(number2));
            }
            catch (FormatException)
            {
                Pair = Tuple.Create<double, double>(0, 0);
            }

        }

        public abstract string GetResult();

        public abstract void SetStrategy(int choice);
    }
}
