using StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms.AdressAddreOrEditorHelpers.ValidateManagers;
using StationeryStoreUILayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreUILayer.PublicHelpers.DataAdders.AdressDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.AdressDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.AdressDataEditors;
using StationeryStoreUILayer.PublicHelpers.FormTextSeters;
using StationeryStoreUILayer.PublicHelpers.NumericUdFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
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

namespace StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms
{
    public partial class AdressAdderOrEditorForm : Form, IAdressAdderOrEditorForm,
        IAdressDataBuilder,
        IAdressDataAdder,
        IAdressDataEditor,
        IFormTextSeter,
        IButtonTextSeter,
        ITextBoxFiller,
        INumericUdFiller,
        INumericUdDefaultValueSeter,
        ITextBoxRestartor,
        INumericUdRestartor,
        IAdressAdderOrEditorValidateManager
    {
        private IAdressDataBuilder _adressDataBuilder;
        private IAdressDataAdder _adressDataAdder;
        private IAdressDataEditor _adressDataEditor;
        private IFormTextSeter _formTextSeter;
        private IButtonTextSeter _buttonTextSeter;
        private ITextBoxFiller _textBoxFiller;
        private INumericUdFiller _numericUdFiller;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private ITextBoxRestartor _textBoxRestartor;
        private INumericUdRestartor _numericUdRestartor;
        private IAdressAdderOrEditorValidateManager _adressAdderOrEditorValidateManager;
        private AdressTable adressInfo { get; set; }
        private bool editMode { get; set; }
        private UserTable userInfo { get; set; }
        AdressTable IAdressAdderOrEditorForm.AdressInfo { get => adressInfo; set => adressInfo = value; }
        bool IAdressAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        UserTable IAdressAdderOrEditorForm.UserInfo { get => userInfo; set => userInfo = value; }
        public AdressAdderOrEditorForm(
            IAdressDataBuilder adressDataBuilder,
            IAdressDataAdder adressDataAdder,
            IAdressDataEditor adressDataEditor,
            IFormTextSeter formTextSeter,
            IButtonTextSeter buttonTextSeter,
            ITextBoxFiller textBoxFiller,
            INumericUdFiller numericUdFiller,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            ITextBoxRestartor textBoxRestartor,
            INumericUdRestartor numericUdRestartor,
            IAdressAdderOrEditorValidateManager adressAdderOrEditorValidateManager
            )
        {
            InitializeComponent();
            _adressDataBuilder = adressDataBuilder;
            _adressDataAdder = adressDataAdder;
            _adressDataEditor = adressDataEditor;
            _formTextSeter = formTextSeter;
            _buttonTextSeter = buttonTextSeter;
            _textBoxFiller = textBoxFiller;
            _numericUdFiller = numericUdFiller;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _textBoxRestartor = textBoxRestartor;
            _numericUdRestartor = numericUdRestartor;
            _adressAdderOrEditorValidateManager = adressAdderOrEditorValidateManager;

        }

        private void AdressAdderOrEditorForm_Load(object sender, EventArgs e)
        {
            SetNumericUdDefaultValue(1000000000, txtPostalCode);
            if (editMode)
            {
                SetFormText(this, "ویرایش آدرس");
                SetButtonText(SendBtn, "ویرایش");
                FillTextBox(txtCityName, adressInfo.City);
                FillTextBox(txtStreetName, adressInfo.Street);
                FillTextBox(txtAlleyName, adressInfo.Alley);
                FillTextBox(txtHouseNumber, adressInfo.HouseNumber);
                FillNumericUd(txtPostalCode, adressInfo.PostalCode);
            }
            else
            {
                SetFormText(this, "افزودن آدرس");
                SetButtonText(SendBtn, "افزودن");
                RestartTextBox(txtCityName, txtStreetName, txtAlleyName, txtHouseNumber);
                RestartNumericUd(txtPostalCode);
            }
        }

        public AdressTable BuildAdressData(int userId, string userName, string city, string street, string alley, string houseNumber, long postalCode, int? adressIdForEdit = null)
        {
            return _adressDataBuilder.BuildAdressData(userId, userName, city, street, alley, houseNumber, postalCode, adressIdForEdit);
        }

        public void AddAdressData(AdressTable adress)
        {
            _adressDataAdder.AddAdressData(adress);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (ManageValidate(txtCityName.Text, txtStreetName.Text, txtAlleyName.Text, txtHouseNumber.Text))
            {
                if (editMode)
                {
                    EditAdressData(BuildAdressData(userInfo.UserId, userInfo.UserName, txtCityName.Text, txtStreetName.Text, txtAlleyName.Text, txtHouseNumber.Text, (long)txtPostalCode.Value, adressInfo.AdressId));
                    MessageBox.Show("آدرس با موفقیت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddAdressData(BuildAdressData(userInfo.UserId, userInfo.UserName, txtCityName.Text, txtStreetName.Text, txtAlleyName.Text, txtHouseNumber.Text, (long)txtPostalCode.Value));
                    MessageBox.Show("آدرس با موفقیت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
            }

        }

        public void EditAdressData(AdressTable adress)
        {
            _adressDataEditor.EditAdressData(adress);
        }

        public void SetFormText(Form form, string text)
        {
            _formTextSeter.SetFormText(form, text);
        }

        public void SetButtonText(Button button, string text)
        {
            _buttonTextSeter.SetButtonText(button, text);
        }

        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        public void FillNumericUd(NumericUpDown numericUpDown, decimal value)
        {
            _numericUdFiller.FillNumericUd(numericUpDown, value);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public bool ManageValidate(string cityName, string streetName, string alleyName, string houseNumber)
        {
            return _adressAdderOrEditorValidateManager.ManageValidate(cityName, streetName, alleyName, houseNumber);
        }
    }
}
