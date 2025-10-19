using StationeryStoreAppLayer.Forms.HomeForms;

namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form, IHomeForm
    {

        bool IsAdmin;
        bool IHomeForm.IsAdmin { get => IsAdmin; set => IsAdmin = value; }

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show($"{IsAdmin}");

        }

        private void WelcomeGB_Enter(object sender, EventArgs e)
        {

        }

        private void WelcomeGB_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
