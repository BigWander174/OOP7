using OOP7.SubApplications.Moving.Model;

namespace OOP7.SubApplications.Moving
{
    public partial class SpeedAndAcceleration : Form
    {
        private PhysicsQuantities _roadModel = new RoadModel();
        public SpeedAndAcceleration()
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
