using OOP7.SubApplications.Moving;
using OOP7.SubApplications.UniversalCalculator;

namespace OOP7.FormShower
{
    internal class Launcher
    {
        private Form[] _forms;
 
        public Launcher()
        {
            _forms = new Form[]
            {
                new Pifagor(),
                new SpeedAndAcceleration(),
                new OneOperationCalculator(),
                new MultiCalculator()
            };
        }

        public void ShowForm(int index)
        {
            try
            {
                _forms[index].Show();
            }
            catch (ObjectDisposedException)
            {
                _forms[index] = FormFactory.GetForm(index);
                _forms[index].Show();
            }
        }
    }
}
