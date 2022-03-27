using OOP7.SubApplications.Calculator.Interface;

namespace OOP7.SubApplications.Calculator.Model
{
    internal class Divider : ICalculation
    {
        public double Work(Tuple<double, double> pair)
        {
            return pair.Item1 / pair.Item2;
        }
    }
}
