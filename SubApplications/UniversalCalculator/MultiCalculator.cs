namespace OOP7.SubApplications.UniversalCalculator
{
    public partial class MultiCalculator : Form
    {
        private CheckBox[] _checkBoxes;
        private MultiCalculatorModel _multiCalculator;
        public MultiCalculator()
        {
            InitializeComponent();
            _checkBoxes = new CheckBox[]
            {
                checkBox1,
                checkBox2,
                checkBox3
            };
            _multiCalculator = new MultiCalculatorModel();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStrategies(sender);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStrategies(sender);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStrategies(sender);
        }

        private void aBox_TextChanged(object sender, EventArgs e)
        {
            _multiCalculator.Set(aBox.Text, bBox.Text);
            resultBox.Text = _multiCalculator.GetResult();
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            _multiCalculator.Set(aBox.Text, bBox.Text);
            resultBox.Text = _multiCalculator.GetResult();
        }
        
        private void UpdateStrategies(object sender)
        {
            var check = (CheckBox)sender;

            var index = Array.IndexOf(_checkBoxes, check);

            _multiCalculator.SetStrategy(index);
            resultBox.Text = _multiCalculator.GetResult();
        }
    }
}
