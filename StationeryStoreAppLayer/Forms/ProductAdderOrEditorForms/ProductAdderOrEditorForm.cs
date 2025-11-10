using StationeryStoreAppLayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxValueSelectors;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreAppLayer.PublicHelpers.FormTextSeters;
using StationeryStoreAppLayer.PublicHelpers.NumericUdFillers;
using StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.TextBoxFillers;
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

namespace StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms
{
    public partial class ProductAdderOrEditorForm : Form,
        IProductAdderOrEditorForm,
        IBrandsComboDataGeter,
        IComboBoxFiller,
        IComboBoxValueSelector,
        ITextBoxFiller,
        INumericUdFiller,
        IFormTextSeter,
        IButtonTextSeter,
        INumericUdRestartor,
        ITextBoxRestartor,
        IComboRestartor
        

    {
        private ProductsTable productInfo;
        private bool editMode = false;
        ProductsTable IProductAdderOrEditorForm.ProductsInfo { get => productInfo; set => productInfo = value; }
        bool IProductAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        private IProductDataBuilder _productDataBuilder;
        private IProductDataAdder _productDataAdder;
        private IProductEditor _productEditor;
        private IBrandsComboDataGeter _brandsComboDataGeter;
        private IComboBoxFiller _comboBoxFiller;
        private IComboBoxValueSelector _comboBoxValueSelector;
        private IFormTextSeter _formTextSeter;
        private IButtonTextSeter _buttonTextSeter;
        private INumericUdFiller _numericlUdFiller;
        private ITextBoxFiller _textBoxFiller;
        private INumericUdRestartor _numericlUdRestartor;
        private IComboRestartor _comboRestartor;
        private ITextBoxRestartor _textBoxRestartor;

        public ProductAdderOrEditorForm(
            IProductDataBuilder productDataBuilder,
            IProductDataAdder productDataAdder,
            IProductEditor productEditor,
            IBrandsComboDataGeter brandsComboDataGeter,
            IComboBoxFiller comboBoxFiller,
            IComboBoxValueSelector comboBoxValueSelector,
            IFormTextSeter formTextSeter,
            IButtonTextSeter buttonTextSeter,
            INumericUdFiller numericUdFiller,
            ITextBoxFiller textBoxFiller,
            INumericUdRestartor numericUdRestartor,
            IComboRestartor comboRestartor,
            ITextBoxRestartor textBoxRestartor
            )
        {
            InitializeComponent();
            _productDataBuilder = productDataBuilder;
            _productDataAdder = productDataAdder;
            _productEditor = productEditor;
            _brandsComboDataGeter = brandsComboDataGeter;
            _comboBoxFiller = comboBoxFiller;
            _comboBoxValueSelector = comboBoxValueSelector;
            _textBoxFiller = textBoxFiller;
            _numericlUdFiller = numericUdFiller;
            _buttonTextSeter = buttonTextSeter;
            _formTextSeter = formTextSeter;
            _numericlUdRestartor = numericUdRestartor;
            _comboRestartor = comboRestartor;
            _textBoxRestartor = textBoxRestartor;
            
        }


        public void AddProductData(ProductsTable newPruduct)
        {
            _productDataAdder.AddProductData(newPruduct);
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime, ProductIdForEdit);
        }

        private void ProductAdderOrEditorForm_Load(object sender, EventArgs e)
        {
            FillCombo(BarndCombo, GetBrandsComboData(), "BrandName", "BrandId");

            if (editMode)
            {
                SetFormText(this,"ویرایش محصول");
                SetButtonText(SendBtn,"ویرایش");
                FillTextBox(txtProductName,productInfo.ProductName);
                FillNumericUd(CountTxt,productInfo.Count);
                FillNumericUd(AmountTxt,productInfo.Amount);
                SelectComboBoxValue(BarndCombo,productInfo.BrandId);
            }
            else
            {
                SetFormText(this, "افزودن محصول جدید");
                SetButtonText(SendBtn, "افزودن");
                RestartTextBox(txtProductName);
                RestartNumericUd(CountTxt,AmountTxt);
                RestartCombo(BarndCombo);

            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                EditProduct(BuildProductData(txtProductName.Text,(int)(BarndCombo.SelectedValue),(string)(BarndCombo.SelectedText),(long)(AmountTxt.Value),(int)(CountTxt.Value),productInfo.AddTime,productInfo.ProductId));
                MessageBox.Show("محصول با موفقیت به روزرسانی شد","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
            
            }
            DialogResult = DialogResult.OK;
        }

        public void EditProduct(ProductsTable product)
        {
            _productEditor.EditProduct(product);            
        }

        public List<BrandsTable> GetBrandsComboData()
        {
            return _brandsComboDataGeter.GetBrandsComboData();
        }

        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox,data,displayMember,ValueMember);
        }

        public void SelectComboBoxValue(ComboBox comboBox, object? value)
        {
            _comboBoxValueSelector.SelectComboBoxValue(comboBox,value);
        }

        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox,text);
        }

        public void FillNumericUd(NumericUpDown numericUpDown, decimal value)
        {
            _numericlUdFiller.FillNumericUd(numericUpDown,value);
        }

        public void SetFormText(Form form, string text)
        {
            _formTextSeter.SetFormText(form, text);
        }

        public void SetButtonText(Button button, string text)
        {
            _buttonTextSeter.SetButtonText(button, text);
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericlUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public void RestartCombo(params ComboBox[] comboBoxes)
        {
            _comboRestartor.RestartCombo(comboBoxes);
        }
    }
}
