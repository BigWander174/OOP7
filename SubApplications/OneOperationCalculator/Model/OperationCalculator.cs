using OOP7.SubApplications.Calculator.Model;

namespace OOP7.SubApplications.OneOperationCalculator.Model
{
    public class OperationCalculator : Calc
    {
        private int _choice = -1;

        public override string GetResult()
        {
            try
            {
                return Calculations[_choice].Work(Pair).ToString();
            }
            catch (IndexOutOfRangeException)
            {
                return "Вы не выбрали операцию!";
            }
        }

        public override void SetStrategy(int choice)
        {
            _choice = choice;
        }
    }
}
