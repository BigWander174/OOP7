using OOP7.SubApplications.UniversalCalculator;

namespace OOP7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pifagor = new Pifagor();
            pifagor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var road = new Moving();
            road.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var calculator = new OneOperationCalculator();
            calculator.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var multiCalculator = new MultiCalculator();
            multiCalculator.ShowDialog();
        }
    }
}