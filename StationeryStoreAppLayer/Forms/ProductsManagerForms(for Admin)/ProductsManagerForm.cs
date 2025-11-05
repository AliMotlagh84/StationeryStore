using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreAppLayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
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
        IProductDataBuilder,
        IProductSearcher,
        IBrandsComboDataGeter,
        IDgFiller,
        INumericUdDefaultValueSeter,
        IComboBoxFiller,
        IBoolComboFiller,
        ITextBoxRestartor,
        INumericUdRestartor,
        IComboRestartor,
        IMaskedTextBoxRestartor,
        IProductAdderOrEditorFormOpener





    {

        private IDgFiller _dgFiller;
        private IProductsDataGeter _productDataGeter;
        private IProductDataBuilder _productDataBuilder;
        private IBrandsComboDataGeter _brandComboDataGeter;
        private IProductSearcher _productSearcher;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private IComboBoxFiller _comboBoxFiller;
        private IBoolComboFiller _boolComboFiller;
        private ITextBoxRestartor _textBoxRestartors;
        private INumericUdRestartor _numericUdRestartor;
        private IComboRestartor _comboRestartor;
        private IMaskedTextBoxRestartor _maskedTextBoxRestartors;
        private IProductAdderOrEditorFormOpener _productAdderOrEditorFormOpener;
        public ProductsManagerForm(
            IProductsDataGeter productsDataGeter,
            IProductDataBuilder productDataBuilder,
            IBrandsComboDataGeter brandsComboDataGeter,
            IProductSearcher productSearcher,
            IDgFiller dgFiller,
            IComboBoxFiller comboBoxFiller,
            IBoolComboFiller boolComboFiller,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            ITextBoxRestartor textBoxRestartor,
            INumericUdRestartor numericUdRestartor,
            IComboRestartor comboRestartor,
            IMaskedTextBoxRestartor maskedTextBoxRestartor,
            IProductAdderOrEditorFormOpener productAdderOrEditorFormOpener
            )
        {
            InitializeComponent();
            _dgFiller = dgFiller;
            _productDataGeter = productsDataGeter;
            _productDataBuilder = productDataBuilder;
            _productSearcher = productSearcher;
            _comboBoxFiller = comboBoxFiller;
            _boolComboFiller = boolComboFiller;
            _brandComboDataGeter = brandsComboDataGeter;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _productSearcher = productSearcher;
            _textBoxRestartors = textBoxRestartor;
            _numericUdRestartor = numericUdRestartor;
            _comboRestartor = comboRestartor;
            _maskedTextBoxRestartors = maskedTextBoxRestartor;
            _productAdderOrEditorFormOpener = productAdderOrEditorFormOpener;

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

        public void OpenProductAdderOrEditorForm(ProductsTable productInfo, bool editMode, Form senderForm)
        {
            _productAdderOrEditorFormOpener.OpenProductAdderOrEditorForm(productInfo, editMode, senderForm);
        }

        public void RestartCombo(params ComboBox[] comboBoxes)
        {
            _comboRestartor.RestartCombo(comboBoxes);
        }

        public void RestartMaskedTextBox(params MaskedTextBox[] maskedTextBoxes)
        {
            _maskedTextBoxRestartors.RestartMaskedTextBox(maskedTextBoxes);
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartors.RestartTextBox(textBoxes);
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

        private void RefreshFrom_Click(object sender, EventArgs e)
        {
            RestartTextBox(txtProductName);
            RestartNumericUd(MinAmounttxt, MaxAmountTxt);
            RestartCombo(AvailablityCombo, BrandIdCombo);
            RestartMaskedTextBox(MinDatetxt, MaxDatetxt);
            FillDg<ProductsTable>(DGPruducts, GetProductsData());
        }

        private void IncreaseCountBtn_Click(object sender, EventArgs e)
        {

        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime, ProductIdForEdit);
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            if (DGPruducts.CurrentRow != null)
            {
                ProductsTable newProduct = BuildProductData((string)DGPruducts.CurrentRow.Cells[1].Value, (int)DGPruducts.CurrentRow.Cells[2].Value, (string)DGPruducts.CurrentRow.Cells[3].Value, (long)DGPruducts.CurrentRow.Cells[5].Value, (int)DGPruducts.CurrentRow.Cells[4].Value, (DateTime)DGPruducts.CurrentRow.Cells[6].Value);
                OpenProductAdderOrEditorForm(newProduct, false, this);
            }
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            if (DGPruducts.CurrentRow != null)
            {
                ProductsTable newProduct = BuildProductData((string)DGPruducts.CurrentRow.Cells[1].Value, (int)DGPruducts.CurrentRow.Cells[2].Value, (string)DGPruducts.CurrentRow.Cells[3].Value, (long)DGPruducts.CurrentRow.Cells[5].Value, (int)DGPruducts.CurrentRow.Cells[4].Value, (DateTime)DGPruducts.CurrentRow.Cells[6].Value, (int)DGPruducts.CurrentRow.Cells[0].Value);
                OpenProductAdderOrEditorForm(newProduct, true, this);
            }
        }


}
}
