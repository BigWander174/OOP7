using OOP7.SubApplications.UniversalCalculator;
using OOP7.SubApplications.Moving;

namespace OOP7.FormShower
{
    internal static class FormFactory
    {
        public static Form GetForm(int index)
        {
            switch (index)
            {
                case 0:
                    return new Pifagor();
                case 1:
                    return new SpeedAndAcceleration();
                case 2:
                    return new OneOperationCalculator();
                case 3:
                    return new MultiCalculator();
                default:
                    return null;
            }
        }
    }
}
