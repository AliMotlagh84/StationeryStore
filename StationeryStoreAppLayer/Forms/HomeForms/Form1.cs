using StationeryStoreAppLayer.Forms.HomeForms;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;

namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form, IHomeForm
    {

        private bool isAdmin;
        private string userName;
        private IProductManagementAccessController _productManagementAccessController;
        private ITimeLabelSeter _timeLabelSeter;
        private IDateLabelSeter _dateLabelSeter;
        private IIntroducingLabelSeter _introducingLabelSeter;
        private IAdminLabelSeter _adminLabelSeter;
        bool IHomeForm.IsAdmin { get => isAdmin; set => isAdmin = value; }
        string IHomeForm.UserName { get => userName; set => userName = value; }

        public Form1(IProductManagementAccessController productManagementAccessController,
            ITimeLabelSeter timeLabelSeter,
            IDateLabelSeter dateLabelSeter,
            IIntroducingLabelSeter introducingLabelSeter,
            IAdminLabelSeter adminLabelSeter
            )
        {
            InitializeComponent();
            _productManagementAccessController = productManagementAccessController;
            _timeLabelSeter = timeLabelSeter;
            _dateLabelSeter = dateLabelSeter;
            _introducingLabelSeter = introducingLabelSeter;
            _adminLabelSeter = adminLabelSeter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowProductsManagement(ProductsManageBtn, isAdmin);
            SetAdminLabel(AdminLbl, userName, isAdmin);
            SetIntrducingLabel(WelcomLbl, "به فروشگاه نوشت افزار خوش آمدید");
            SetIntrducingLabel(IntroducingLbl, " این یک  پروژه ی شخصی است که توسط علی مطلق نوشته شده است");
            SetIntrducingLabel(UseLbl, "برای افزودن هر محصول به سبد خرید روی ردیف آن در جدول کلیک کرده و در فرمی که باز میشود تعداد را انتخاب کنید");
            SetTime(TimeValueLbl, DateTime.Now);
            SetDate(DateValueLbl, DateTime.Now);

            MessageBox.Show($"Hi {userName}  Your AdminiState is {isAdmin}");

        }

        private void WelcomeGB_Enter(object sender, EventArgs e)
        {

        }

        public void AllowProductsManagement(ToolStripButton productsButtonManagement, bool isAdmin)
        {
            _productManagementAccessController.AllowProductsManagement(productsButtonManagement, isAdmin);
        }

        public void SetDate(ToolStripLabel dateLabel, DateTime dateTime)
        {
            _dateLabelSeter.SetDate(dateLabel, dateTime);
        }

        public void SetTime(ToolStripLabel timeLabel, DateTime dateTime)
        {
            _timeLabelSeter.SetTime(timeLabel, dateTime);
        }

        public void SetAdminLabel(ToolStripLabel AdminLabel, string userName, bool isAdmin)
        {
            _adminLabelSeter.SetAdminLabel(AdminLabel, userName, isAdmin);
        }

        public void SetIntrducingLabel(Label introducingLabel, string text)
        {
            _introducingLabelSeter.SetIntrducingLabel(introducingLabel, text);
        }
    }
}
