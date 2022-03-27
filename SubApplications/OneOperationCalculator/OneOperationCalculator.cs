using OOP7.SubApplications.OneOperationCalculator.Model;

namespace OOP7
{
    public partial class OneOperationCalculator : Form
    {
        private OperationCalculator _calculator = new OperationCalculator();

        private RadioButton[] _radioButtons;
        public OneOperationCalculator()
        {
            InitializeComponent();
            _radioButtons = new RadioButton[]
            {
                addRadio,
                divideRadio,
                multiplyRadio
            };
        }

        private void addRadio_CheckedChanged(object sender, EventArgs e)
        {
            SwitchStrategy(sender);
        }

        private void divideRadio_CheckedChanged(object sender, EventArgs e)
        {
            SwitchStrategy(sender);
        }

        private void multiplyRadio_CheckedChanged(object sender, EventArgs e)
        {
            SwitchStrategy(sender);
        }

        private void aBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
            
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void SwitchStrategy(object sender)
        {
            var currentButton = (RadioButton)sender;

            var index = Array.IndexOf(_radioButtons, currentButton);
            _calculator.SetStrategy(index);
            UpdateValues();
        }

        private void UpdateValues()
        {
            _calculator.Set(aBox.Text, bBox.Text);
            resultBox.Text = _calculator.GetResult();
        }
    }
}
