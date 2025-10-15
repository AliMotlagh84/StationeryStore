namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form, IHomeForm
    {

        bool IHomeForm.IsAdmin { get; set; } = false;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (((IHomeForm)this).IsAdmin)
            {
                MessageBox.Show("HiAdmin");
            }
        }
    }
}
