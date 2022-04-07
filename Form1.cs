using OOP7.FormShower;

namespace OOP7
{
    public partial class Form1 : Form
    {
        private Button[] _programButtons;
        private Launcher _launcher;

        public Form1()
        {
            InitializeComponent();
            _programButtons = new Button[]
            {
                button1,
                button2,
                button3,
                button4,
            };

            _launcher = new Launcher();
        }

        private void ShowForm(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var index = Array.IndexOf(_programButtons, button);
            _launcher.ShowForm(index);
        }
    }
}