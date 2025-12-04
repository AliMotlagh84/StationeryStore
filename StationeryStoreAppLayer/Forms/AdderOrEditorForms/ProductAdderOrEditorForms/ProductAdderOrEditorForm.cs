using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.AdderOrEditorForms.ProductAdderOrEditorForms;
using StationeryStoreUILayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreUILayer.PublicHelpers.ComboBoxValueSelectors;
using StationeryStoreUILayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreUILayer.PublicHelpers.FormTextSeters;
using StationeryStoreUILayer.PublicHelpers.NumericUdFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreUILayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.TextBoxFillers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.ProductAdderOrEditorForms
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
        IComboRestartor,
        IBrandDataGeter,
        ITextValidator,
        INumericUdDefaultValueSeter


    {
        private ProductsTable productInfo;
        private bool editMode = false;
        ProductsTable IProductAdderOrEditorForm.ProductsInfo { get => productInfo; set => productInfo = value; }
        bool IProductAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        private IProductDataBuilder _productDataBuilder;
        private IProductDataAdder _productDataAdder;
        private IProductEditor _productEditor;
        private IBrandsComboDataGeter _brandsComboDataGeter;
        private IBrandDataGeter _brandDataGeter;
        private IComboBoxFiller _comboBoxFiller;
        private IComboBoxValueSelector _comboBoxValueSelector;
        private IFormTextSeter _formTextSeter;
        private IButtonTextSeter _buttonTextSeter;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private INumericUdFiller _numericlUdFiller;
        private ITextBoxFiller _textBoxFiller;
        private INumericUdRestartor _numericlUdRestartor;
        private IComboRestartor _comboRestartor;
        private ITextBoxRestartor _textBoxRestartor;
        private ITextValidator _textValidator;


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
            ITextBoxRestartor textBoxRestartor,
            IBrandDataGeter brandDataGeter,
            ITextValidator textValidator,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter
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
            _brandDataGeter = brandDataGeter;
            _textValidator = textValidator;
            _comboBoxFiller = comboBoxFiller;
            _comboBoxValueSelector = comboBoxValueSelector;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter; 
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
            FillCombo(BarndCombo, GetBrandsData(), "BrandName", "BrandId");
            SetNumericUdDefaultValue(0,CountTxt);
            SetNumericUdDefaultValue((long)AmountTxt.Minimum,AmountTxt);
            if (editMode)
            {
                SetFormText(this, "ویرایش محصول");
                SetButtonText(SendBtn, "ویرایش");
                FillTextBox(txtProductName, productInfo.ProductName);
                FillNumericUd(CountTxt, productInfo.Count);
                FillNumericUd(AmountTxt, productInfo.Amount);
                SelectComboBoxValue(BarndCombo, productInfo.BrandId);

            }
            else
            {
                SetFormText(this, "افزودن محصول جدید");
                SetButtonText(SendBtn, "افزودن");
                RestartTextBox(txtProductName);
                RestartNumericUd(CountTxt, AmountTxt);
                RestartCombo(BarndCombo);

            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (_textValidator.ValidateText(txtProductName.Text))
            {


                if (editMode)
                {
                    EditProduct(BuildProductData(txtProductName.Text, (int)(BarndCombo.SelectedValue), BarndCombo.GetItemText(BarndCombo.SelectedItem), (long)(AmountTxt.Value), (int)(CountTxt.Value), productInfo.AddTime, productInfo.ProductId));
                    MessageBox.Show("محصول با موفقیت به روزرسانی شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddProductData(BuildProductData(txtProductName.Text, (int)BarndCombo.SelectedValue, BarndCombo.GetItemText(BarndCombo.SelectedItem), (long)AmountTxt.Value, (int)CountTxt.Value, DateTime.Now, null));
                    MessageBox.Show("محصول با موفقیت به انبار اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("لطفا نام محصول را مشخص کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditProduct(ProductsTable product)
        {
            _productEditor.EditProduct(product);
        }


        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox, data, displayMember, ValueMember);
        }

        public void SelectComboBoxValue(ComboBox comboBox, object? value)
        {
            _comboBoxValueSelector.SelectComboBoxValue(comboBox, value);
        }

        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        public void FillNumericUd(NumericUpDown numericUpDown, decimal value)
        {
            _numericlUdFiller.FillNumericUd(numericUpDown, value);
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

        public List<BrandsTable> GetBrandsData()
        {
            return _brandDataGeter.GetBrandsData();
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue,numericUdCollection);
        }

        public List<BrandsTable> GetBrandsComboData(List<BrandsTable> brandsData)
        {
            return _brandsComboDataGeter.GetBrandsComboData(brandsData);
        }
    }
}
