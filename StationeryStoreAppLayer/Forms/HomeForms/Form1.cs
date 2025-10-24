using StationeryStore.DataLayer.Models;
using StationeryStoreAppLayer.FormManagers;
using StationeryStoreAppLayer.Forms.HomeForms;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;

namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form, IHomeForm
    {

        private bool isAdmin;
        private string userName;
        private Form senderForm;
        private IProductManagementAccessController _productManagementAccessController;
        private ITimeLabelSeter _timeLabelSeter;
        private IDateLabelSeter _dateLabelSeter;
        private IIntroducingLabelSeter _introducingLabelSeter;
        private IAdminLabelSeter _adminLabelSeter;
        private IFormCloser _formCloser;
        private IFormManager _formManager;
        private IDgFiller _dgFiller;
        private IDgOrdersFiller _dgOrdersFiller;
        private IProductsDataGeter _productsGeter;
        private IOrdersDataGeter _ordersDataGeter;
        bool IHomeForm.IsAdmin { get => isAdmin; set => isAdmin = value; }
        string IHomeForm.UserName { get => userName; set => userName = value; }
        Form IHomeForm.SenderForm { get => senderForm; set => senderForm = value; }

        public Form1(IProductManagementAccessController productManagementAccessController,
            ITimeLabelSeter timeLabelSeter,
            IDateLabelSeter dateLabelSeter,
            IIntroducingLabelSeter introducingLabelSeter,
            IAdminLabelSeter adminLabelSeter,
            IFormCloser formCloser,
            IFormManager formManager,
            IDgFiller dgFiller,
            IDgOrdersFiller dgOrdersFiller,
            IProductsDataGeter productsGeter,
            IOrdersDataGeter ordersDataGeter
            )
        {
            InitializeComponent();
            _productManagementAccessController = productManagementAccessController;
            _timeLabelSeter = timeLabelSeter;
            _dateLabelSeter = dateLabelSeter;
            _introducingLabelSeter = introducingLabelSeter;
            _adminLabelSeter = adminLabelSeter;
            _formCloser = formCloser;
            _formManager = formManager;
            _dgFiller = dgFiller;
            _dgOrdersFiller = dgOrdersFiller;
            _productsGeter = productsGeter;
            _ordersDataGeter = ordersDataGeter;
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
            //DGPruducts.DataSource = GetProducts();
            FillDg<ProductsTable>(DGPruducts,GetProductsData);
            FillDgOrders(DgOrders,GetOrdersData);
            ManageForm(this);
            CloseForm(senderForm);         
            MessageBox.Show($"Hi {userName}  Your AdminiState is {isAdmin}");
        }

        private void WelcomeGB_Enter(object sender, EventArgs e)
        {
            CloseForm(senderForm);
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

        public void CloseForm(Form form)
        {
            _formCloser.CloseForm(form);
        }

        private void ProductsManageBtn_Click(object sender, EventArgs e)
        {
            
        }

        public void ManageForm(Form form)
        {
            _formManager.ManageForm(form);
        }

        public void FillDg<T> (DataGridView dg, Func<List<T>> dataGeterMethod)
        {
            _dgFiller.FillDg(dg , dataGeterMethod);
        }

        public List<ProductsTable> GetProductsData()
        {
            return _productsGeter.GetProductsData();
        }

        public void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod)
        {
            _dgOrdersFiller.FillDgOrders(dg , dataGeterMethod);
        }

        public List<OrdersTable> GetOrdersData()
        {
           return _ordersDataGeter.GetOrdersData();
        }
    }
}
