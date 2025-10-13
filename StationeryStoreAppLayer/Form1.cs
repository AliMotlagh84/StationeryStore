namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form
    {
        private bool IsAdmin;
        public Form1(bool isAdmin)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                MessageBox.Show("HiAdmin");
            }
        }
    }
}
