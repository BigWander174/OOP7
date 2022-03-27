using OOP7.SubApplications.Moving.Model;

namespace OOP7
{
    public partial class Moving : Form
    {
        private RoadModel _roadModel = new RoadModel();
        public Moving()
        {
            InitializeComponent();
        }

        private void speedBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void accelerationBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            _roadModel.Set(speedBox.Text, accelerationBox.Text, timeBox.Text);
            resultSpeedBox.Text = _roadModel.Speed.ToString();
            distanceBox.Text = _roadModel.Distance.ToString();
        }
    }
}
