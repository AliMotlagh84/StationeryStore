using StationeryStoreDataLayer.Models;
using StationeryStoreAppLayer.FormManagers;
using StationeryStoreAppLayer.Forms.HomeForms;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners;

namespace StationeryStoreAppLayer
{
    public partial class Form1 : Form, IHomeForm,
        IDgFiller,
        IDgOrdersFiller,
        IProductsDataGeter,
        IOrdersDataGeter,
        IBrandDataGeter,
        INewProductsDataGeter,
        ISingleProductDataGeter,
        INumericUdDefaultValueSeter,
        IProductSearcher,
        IComboBoxFiller,
        IBoolComboFiller,
        IBrandsComboDataGeter,
        IDraftOrderFormOpener

    {

        private UserTable userInfo;
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
        private INewProductsDataGeter _newProductsDataGeter;
        private ISingleProductDataGeter _singleProductDataGeter;
        private IBrandDataGeter _brandDataGeter;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private IProductSearcher _productSearcher;
        private IComboBoxFiller _comboBoxFiller;
        private IBrandsComboDataGeter _brandsComboDataGeter;
        private IBoolComboFiller _boolComboFiller;
        private IDraftOrderFormOpener _draftOrderFormOpener;

        Form IHomeForm.SenderForm { get => senderForm; set => senderForm = value; }
        UserTable IHomeForm.UserInfo { get => userInfo; set => userInfo = value; }

        public Form1(IProductManagementAccessController productManagementAccessController,
            ITimeLabelSeter timeLabelSeter,
            IDateLabelSeter dateLabelSeter,
            IIntroducingLabelSeter introducingLabelSeter,
            IAdminLabelSeter adminLabelSeter,
            IFormCloser formCloser,
            IFormManager formManager,
            IDgFiller dgFiller,
            IDgOrdersFiller dgOrdersFiller,
            IComboBoxFiller comboBoxFiller,
            IBoolComboFiller boolComboFiller,
            IProductsDataGeter productsGeter,
            IOrdersDataGeter ordersDataGeter,
            IBrandDataGeter brandDataGeter,
            IBrandsComboDataGeter brandsComboDataGeter,
            INewProductsDataGeter newProductsDataGeter,
            ISingleProductDataGeter singleProductDataGeter,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            IProductSearcher productSearcher,
            IDraftOrderFormOpener draftOrderFormOpener

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
            _newProductsDataGeter = newProductsDataGeter;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _productSearcher = productSearcher;
            _comboBoxFiller = comboBoxFiller;
            _brandDataGeter = brandDataGeter;
            _brandsComboDataGeter = brandsComboDataGeter;
            _boolComboFiller = boolComboFiller;
            _draftOrderFormOpener = draftOrderFormOpener;
            _singleProductDataGeter = singleProductDataGeter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AllowProductsManagement(ProductsManageBtn, userInfo.IsAdmin);
            SetAdminLabel(AdminLbl, userInfo.UserName, userInfo.IsAdmin);
            SetIntrducingLabel(WelcomLbl, "به فروشگاه نوشت افزار خوش آمدید");
            SetIntrducingLabel(IntroducingLbl, " این یک  پروژه ی شخصی است که توسط علی مطلق نوشته شده است");
            SetIntrducingLabel(UseLbl, "برای افزودن هر محصول به سبد خرید روی ردیف آن در جدول کلیک کرده و در فرمی که باز میشود تعداد را انتخاب کنید");
            SetTime(TimeValueLbl, DateTime.Now);
            SetDate(DateValueLbl, DateTime.Now);
            SetNumericUdDefaultValue(0, MinAmounttxt, MaxAmountTxt, NewMaxAmounttxt, NewMinAmounttxt);
            //DGPruducts.DataSource = GetProducts();
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
            FillDg<ProductsTable>(DGNewProducts, GetNewProductsData(7));
            FillDgOrders(DgOrders, GetOrdersData);
            FillCombo(BarndIdCombo, GetBrandsComboData(), "BrandName", "BrandId");
            FillCombo(NewBrandIdCombo, GetBrandsComboData(), "BrandName", "BrandId");
            FillBoolCombo(AvailablityCombo, "همه", "موجود", "ناموجود");
            FillBoolCombo(NewAvailblityCombo, "همه", "موجود", "ناموجود");
            ManageForm(this);
            CloseForm(senderForm);
            MessageBox.Show($"Hi {userInfo.UserName}  Your AdminiState is {userInfo.IsAdmin}");
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

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<ProductsTable> GetProductsData()
        {
            return _productsGeter.GetProductsData();
        }

        public void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod)
        {
            _dgOrdersFiller.FillDgOrders(dg, dataGeterMethod);
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public List<ProductsTable> GetNewProductsData(int ExpDays)
        {
            return _newProductsDataGeter.GetNewProductsData(ExpDays);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public List<ProductsTable> SearchInProducts(IEnumerable<ProductsTable> products, string? productName = null, int? brandId = null, bool? availablity = null, long? minAmount = null, long? maxAmount = null, string? minDate = null, string? maxDate = null)
        {
            return _productSearcher.SearchInProducts(products, productName, brandId, availablity, minAmount, maxAmount, minDate, maxDate);
        }

        private void ProductsSearchBtn_Click(object sender, EventArgs e)
        {
            FillDg<ProductsTable>(DGPruducts, SearchInProducts(GetProductsData(), txtProductName.Text, (int?)(BarndIdCombo.SelectedValue), (bool?)AvailablityCombo.SelectedValue, (long?)MinAmounttxt.Value, (long?)MaxAmountTxt.Value, MinDatetxt.Text, MaxDatetxt.Text));
        }

        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox, data, displayMember, ValueMember);
        }

        public List<BrandsTable> GetBrandsData()
        {
            return _brandDataGeter.GetBrandsData();
        }

        public List<BrandsTable> GetBrandsComboData()
        {
            return _brandsComboDataGeter.GetBrandsComboData();
        }

        public void FillBoolCombo(ComboBox comboBox, string allDisplay, string trueDispaly, string falseDispaly)
        {
            _boolComboFiller.FillBoolCombo(comboBox, allDisplay, trueDispaly, falseDispaly);
        }

        private void NewProductsSearchBtn_Click(object sender, EventArgs e)
        {
            FillDg(DGNewProducts, SearchInProducts(GetNewProductsData(7), NewProductNametxt.Text, (int?)(NewBrandIdCombo.SelectedValue), (bool?)(NewAvailblityCombo.SelectedValue), (int?)(NewMinAmounttxt.Value), (int?)(NewMaxAmounttxt.Value), null, null));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            //SetTime(TimeValueLbl, DateTime.Now);
            //SetDate(DateValueLbl, DateTime.Now);
        }

        public void OpenDraftOrderForm(ProductsTable productInfo, UserTable ordererInfo)
        {
            _draftOrderFormOpener.OpenDraftOrderForm(productInfo, ordererInfo);
        }

        public ProductsTable GetSigleProduct(object Id)
        {
            return _singleProductDataGeter.GetSigleProduct(Id);
        }

        private void DGPruducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDraftOrderForm(GetSigleProduct(DGPruducts.CurrentRow.Cells[0].Value),userInfo);
        }
    }
}
