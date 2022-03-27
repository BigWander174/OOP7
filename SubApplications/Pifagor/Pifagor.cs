using OOP7.SubApplications.Pifagor.Model;

namespace OOP7
{
    public partial class Pifagor : Form
    {
        private PifagorModel _pifagor = new PifagorModel();
        public Pifagor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            _pifagor.Set(textBox1.Text, textBox2.Text);
            textBox3.Text = _pifagor.GetInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
