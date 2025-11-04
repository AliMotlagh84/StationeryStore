using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_
{
    public partial class ProductsManagerForm : Form,
        IProductsManagerForm,
        IProductSearcher,
        IBrandsComboDataGeter,
        IDgFiller,
        INumericUdDefaultValueSeter,
        IComboBoxFiller,
        IBoolComboFiller


    {

        private IDgFiller _dgFiller;
        private IProductDataEditor _productDataEditor;
        private IProductDataBuilder _productDataBuilder;
        private IProductsDataGeter _productDataGeter;
        private IBrandsComboDataGeter _brandComboDataGeter;
        private IProductSearcher _productSearcher;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private IComboBoxFiller _comboBoxFiller;
        private IBoolComboFiller _boolComboFiller;
        public ProductsManagerForm(
            IProductDataBuilder productDataBuilder,
            IProductsDataGeter productsDataGeter,
            IProductDataEditor productDataEditor,
            IBrandsComboDataGeter brandsComboDataGeter,
            IProductSearcher productSearcher,
            IDgFiller dgFiller,
            IComboBoxFiller comboBoxFiller,
            IBoolComboFiller boolComboFiller,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter
            )
        {
            InitializeComponent();
            _dgFiller = dgFiller;
            _productDataBuilder = productDataBuilder;
            _productDataGeter = productsDataGeter;
            _productDataEditor = productDataEditor;
            _productSearcher = productSearcher;
            _comboBoxFiller = comboBoxFiller;
            _boolComboFiller = boolComboFiller;
            _brandComboDataGeter = brandsComboDataGeter;
            _productSearcher = productSearcher;
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime, ProductIdForEdit);
        }

        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
        }

        public void FillBoolCombo(ComboBox comboBox, string allDisplay, string trueDispaly, string falseDispaly)
        {
            _boolComboFiller.FillBoolCombo(comboBox, allDisplay, trueDispaly, falseDispaly);
        }

        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox, data, displayMember, ValueMember);
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);

        }

        public List<BrandsTable> GetBrandsComboData()
        {
            return _brandComboDataGeter.GetBrandsComboData();
        }

        public List<ProductsTable> GetProductsData()
        {
            return _productDataGeter.GetProductsData();
        }

        public List<ProductsTable> SearchInProducts(IEnumerable<ProductsTable> products, string? productName = null, int? brandId = null, bool? availablity = null, long? minAmount = null, long? maxAmount = null, string? minDate = null, string? maxDate = null)
        {
            return _productSearcher.SearchInProducts(products, productName, brandId, availablity, minAmount, maxAmount, minDate, maxDate);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        private void ProductsManagerForm_Load(object sender, EventArgs e)
        {
            SetNumericUdDefaultValue(0, MinAmounttxt, MaxAmountTxt);
            FillCombo(BrandIdCombo, GetBrandsComboData(), "BrandName", "BrandId");
            FillBoolCombo(AvailablityCombo, "همه", "موجود", "نا موجود");
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
        }

        private void ProductsSearchBtn_Click(object sender, EventArgs e)
        {
            FillDg<ProductsTable>(DGPruducts, SearchInProducts(GetProductsData(), txtProductName.Text, (int?)(BrandIdCombo.SelectedValue), (bool?)AvailablityCombo.SelectedValue, (long?)MinAmounttxt.Value, (long?)MaxAmountTxt.Value, MinDatetxt.Text, MaxDatetxt.Text));
        }
    }
}
