using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.BrandDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.BrandDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.BrandDataEditor;
using StationeryStoreAppLayer.PublicHelpers.Editors.BrandEditors;
using StationeryStoreAppLayer.PublicHelpers.FormTextSeters;
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

namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm
{
    public partial class BrandAdderOrEditorForm : Form, IBrandAdderOrEditorForm,
    IBrandDataBuilder,
    IBrandEditor,
    IBrandDataAdder,
    ITextValidator,
    ITextBoxFiller,
    IButtonTextSeter,
    IFormTextSeter,
    ITextBoxRestartor

    {
        private BrandsTable brandInfo { get; set; }
        private bool editMode { get; set; }
        BrandsTable IBrandAdderOrEditorForm.BrandInfo { get => brandInfo; set => brandInfo = value; }
        bool IBrandAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }

        private IBrandDataBuilder _brandDataBuilder;
        private IBrandEditor _brandEditor;
        private IBrandDataAdder _brandDataAdder;
        private ITextValidator _textValidator;
        private ITextBoxFiller _textBoxFiller;
        private IButtonTextSeter _buttonSeter;
        private IFormTextSeter _formTextSeter;
        private ITextBoxRestartor _textBoxRestartor;

        public BrandAdderOrEditorForm(IBrandDataBuilder brandDataBuilder,
            IBrandEditor brandEditor,
            IBrandDataAdder brandDataAdder,
            ITextValidator textValidator,
            ITextBoxFiller textBoxFiller,
            IButtonTextSeter buttonSeter,
            IFormTextSeter formTextSeter,
            ITextBoxRestartor textBoxRestartor
            )
        {
            InitializeComponent();
            _brandDataBuilder = brandDataBuilder;
            _brandEditor = brandEditor;
            _brandDataAdder = brandDataAdder;
            _textValidator = textValidator;
            _textBoxFiller = textBoxFiller;
            _buttonSeter = buttonSeter;
            _formTextSeter = formTextSeter;
            _textBoxRestartor = textBoxRestartor;
        }

        private void BrandAdderOrEditorForm_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                SetFormText(this, "ویرایش برند");
                SetButtonText(SendBtn, "ویرایش");
                FillTextBox(txtBrandName, brandInfo.BrandName);
            }
            else
            {
                SetFormText(this, "افزودن برند");
                SetButtonText(SendBtn, "افزودن");
                RestartTextBox(txtBrandName);
            }

        }

        public BrandsTable BuildBrandData(string brandName, int? BrandIdForEdit = null)
        {
            return _brandDataBuilder.BuildBrandData(brandName, BrandIdForEdit);
        }

        public void EditBrand(BrandsTable brand)
        {
            _brandEditor.EditBrand(brand);
        }

        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        public void SetButtonText(Button button, string text)
        {
            _buttonSeter.SetButtonText(button, text);
        }

        public void SetFormText(Form form, string text)
        {
            _formTextSeter.SetFormText(form, text);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (ValidateText(txtBrandName.Text))
            {
                if (editMode)
                {
                    EditBrand(BuildBrandData(txtBrandName.Text, brandInfo.BrandId));
                    MessageBox.Show("برند با موفقیت بروزرسانی شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    AddBrandData(BuildBrandData(txtBrandName.Text));
                    MessageBox.Show("برند با موفقیت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("لطفا نام برند را مشخص کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddBrandData(BrandsTable brand)
        {
            _brandDataAdder.AddBrandData(brand);    
        }
    }
}
