using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.HomeForms;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreUILayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.GropBoxTextSeters;
using StationeryStoreUILayer.AppManagers.FormManagers;
using StationeryStoreUILayer.AppManagers.AppRestartors;
using StationeryStoreUILayer.AppManagers.AppClosers;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreUILayer.Forms.StoreManagerForms;
using StationerStoreApplicationLayer.Deleters.UserDeleters;
using StationeryStoreUILayer.Forms.OrderInfoForms;
using StationeryStoreUILayer.PublicHelpers.FormOpeners;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.DgOrdersFillingHandlers;

namespace StationeryStoreUILayer
{
    public partial class Form1 : Form, IHomeForm,
        IDgFiller,
        IDgOrdersFillingHandler,
        IProductsDataGeter,
        IOrdersDataGeter,
        IBrandDataGeter,
        INewProductsDataGeter,
        ISingleProductDataGeter,
        INumericUdDefaultValueSeter,
        IGroupBoxTextSeter,
        IProductSearcher,
        IComboBoxFiller,
        IBoolComboFiller,
        IBrandsComboDataGeter,
        IDraftOrderFormOpener,
        IUserEditorFormOpener,
        IAppRestartor,
        IUserDeleter,
        IStoreManagerFormOpener,
        IShoppingCartFormOpener,
        IOrderInfoFormOpener,
        IOrderSearcher
    {

        private UserTable userInfo;
        private Form senderForm;
        private IProductManagementAccessController _productManagementAccessController;
        private ITimeLabelSeter _timeLabelSeter;
        private IDateLabelSeter _dateLabelSeter;
        private IIntroducingLabelSeter _introducingLabelSeter;
        private IAdminLabelSeter _adminLabelSeter;
        private IGroupBoxTextSeter _groupBoxTextSeter;
        private IFormCloser _formCloser;
        private IFormManager _formManager;
        private IDgFiller _dgFiller;
        private IDgOrdersFillingHandler _dgOrdersFillingHandler;
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
        private IUserEditorFormOpener _userEditorFormOpener;
        private IAppRestartor _appRestartor;
        private IUserDeleter _userDeleter;
        private IShoppingCartFormOpener _shoppingCartFormOpeners;
        private IStoreManagerFormOpener _storeMangerFormOpener;
        private IOrderInfoFormOpener _orderInfoFormOpener;
        private IOrderSearcher _orderSearcher;

        Form IHomeForm.SenderForm { get => senderForm; set => senderForm = value; }
        UserTable IHomeForm.UserInfo { get => userInfo; set => userInfo = value; }

        public Form1(IProductManagementAccessController productManagementAccessController,
            ITimeLabelSeter timeLabelSeter,
            IDateLabelSeter dateLabelSeter,
            IGroupBoxTextSeter groupBoxTextSeter,
            IIntroducingLabelSeter introducingLabelSeter,
            IAdminLabelSeter adminLabelSeter,
            IFormCloser formCloser,
            IFormManager formManager,
            IDgFiller dgFiller,
            IDgOrdersFillingHandler dgOrdersFillingHandler,
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
            IDraftOrderFormOpener draftOrderFormOpener,
            IUserEditorFormOpener userEditorFormOpener,
            IAppRestartor appRestartor,
            IUserDeleter userDeleter,
            IStoreManagerFormOpener storeMangerFormOpener,
            IShoppingCartFormOpener shoppingCartFormOpener,
            IOrderInfoFormOpener orderInfoFormOpener,
            IOrderSearcher orderSearcher
            )
        {
            InitializeComponent();
            _productManagementAccessController = productManagementAccessController;
            _timeLabelSeter = timeLabelSeter;
            _dateLabelSeter = dateLabelSeter;
            _introducingLabelSeter = introducingLabelSeter;
            _adminLabelSeter = adminLabelSeter;
            _groupBoxTextSeter = groupBoxTextSeter;
            _formCloser = formCloser;
            _formManager = formManager;
            _dgFiller = dgFiller;
            _dgOrdersFillingHandler = dgOrdersFillingHandler;
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
            _userEditorFormOpener = userEditorFormOpener;
            _appRestartor = appRestartor;
            _userDeleter = userDeleter;
            _storeMangerFormOpener = storeMangerFormOpener;
            _shoppingCartFormOpeners = shoppingCartFormOpener;
            _orderInfoFormOpener = orderInfoFormOpener;
            _orderSearcher = orderSearcher;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AllowProductsManagement(StoreManageBtn, userInfo.IsAdmin);
            SetAdminLabel(AdminLbl, userInfo.UserName, userInfo.IsAdmin);
            SetIntrducingLabel(WelcomLbl, "به فروشگاه نوشت افزار خوش آمدید");
            SetIntrducingLabel(IntroducingLbl, " این یک  پروژه ی شخصی است که توسط علی مطلق نوشته شده است");
            SetIntrducingLabel(UseLbl, "برای افزودن هر محصول به سبد خرید روی ردیف آن در جدول کلیک کرده و در فرمی که باز میشود تعداد را انتخاب کنید");
            SetGroupBoxText(OrdersGB, "سفارشات", userInfo.IsAdmin == true);
            SetTime(TimeValueLbl, DateTime.Now);
            SetDate(DateValueLbl, DateTime.Now);
            SetNumericUdDefaultValue(0, MinAmounttxt, MaxAmountTxt, NewMaxAmounttxt, NewMinAmounttxt);
            //DGPruducts.DataSource = GetProducts();
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
            FillDg<ProductsTable>(DGNewProducts, GetNewProductsData(7));
            HandleDgOrdersFilling(DgOrders, userInfo);
            FillCombo(BarndIdCombo, GetBrandsComboData(GetBrandsData()), "BrandName", "BrandId");
            FillCombo(NewBrandIdCombo, GetBrandsComboData(GetBrandsData()), "BrandName", "BrandId");
            FillBoolCombo(AvailablityCombo, "همه", "موجود", "ناموجود");
            FillBoolCombo(NewAvailblityCombo, "همه", "موجود", "ناموجود");
            ManageForm(this);
            CloseForm(senderForm);
            MessageBox.Show($"Hi {userInfo.UserName}  Your AdminiState is {userInfo.IsAdmin}");
        }

        private void RefreshForm()
        {
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
            FillDg<ProductsTable>(DGNewProducts, GetNewProductsData(7));
            HandleDgOrdersFilling(DgOrders, userInfo);
            FillCombo(BarndIdCombo, GetBrandsComboData(GetBrandsData()), "BrandName", "BrandId");
            FillCombo(NewBrandIdCombo, GetBrandsComboData(GetBrandsData()), "BrandName", "BrandId");
            FillBoolCombo(AvailablityCombo, "همه", "موجود", "ناموجود");
            FillBoolCombo(NewAvailblityCombo, "همه", "موجود", "ناموجود");
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
            OpenStoreManagerForm(this);
            RefreshForm();
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
            OpenDraftOrderForm(GetSigleProduct(DGPruducts.CurrentRow.Cells[0].Value), userInfo);
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
            FillDg<ProductsTable>(DGNewProducts, GetNewProductsData(7));
            HandleDgOrdersFilling(DgOrders, userInfo);
        }

        public void SetGroupBoxText(GroupBox gb, string text, bool? where = null)
        {
            _groupBoxTextSeter.SetGroupBoxText(gb, text, where);
        }

        public void OpenUserEditorForm(UserTable userInfo)
        {
            _userEditorFormOpener.OpenUserEditorForm(userInfo);
        }

        private void EditUserFormBtn_Click(object sender, EventArgs e)
        {
            OpenUserEditorForm(userInfo);
        }

        public void ResetApp()
        {
            _appRestartor.ResetApp();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("از حذف اکانت خود مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteUser(userInfo);
                ResetApp();
            }
        }

        public void DeleteUser(object userId)
        {
            _userDeleter.DeleteUser(userId);
        }

        public void DeleteUser(UserTable user)
        {
            _userDeleter.DeleteUser(user);
        }

        public void OpenStoreManagerForm(Form senderForm)
        {
            _storeMangerFormOpener.OpenStoreManagerForm(senderForm);
        }

        public List<BrandsTable> GetBrandsComboData(List<BrandsTable> brandsData)
        {
            return _brandsComboDataGeter.GetBrandsComboData(brandsData);
        }

        private void ShoppingCartBtn_Click(object sender, EventArgs e)
        {
            OpenShoppingCartForm(this, userInfo);
            RefreshForm();
        }

        public void OpenShoppingCartForm(Form senderForm, UserTable userInfo)
        {
            _shoppingCartFormOpeners.OpenShoppingCartForm(senderForm, userInfo);
        }

        private void DgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgOrders.CurrentRow != null)
            {
                if (DgOrders.CurrentCell.ColumnIndex == 6)
                {
                    var order = SearchInOrders(GetOrdersData(), (int)DgOrders.CurrentRow.Cells[0].Value).FirstOrDefault();
                    OpenOrderInfoForm(this, order);
                }
            }
        }

        public void OpenOrderInfoForm(Form senderForm, OrdersTable order)
        {
            _orderInfoFormOpener.OpenOrderInfoForm(senderForm, order);
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders, orderId, userId, userName, minDate, maxDate, minAmount, maxAmount, deliveryState);
        }

        public void HandleDgOrdersFilling(DataGridView dataGridView, UserTable userInfo)
        {
            _dgOrdersFillingHandler.HandleDgOrdersFilling(dataGridView, userInfo);
        }

        private void RestartAppBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("آیا میخواهید با حساب دیگری وارد شوید؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ResetApp();
            }
        }
    }
}
