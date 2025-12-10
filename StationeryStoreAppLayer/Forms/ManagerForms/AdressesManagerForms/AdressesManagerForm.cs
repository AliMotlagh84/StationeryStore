using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StationeryStoreUILayer.Forms.ManagerForms.AdressesManagerForms
{
    public partial class AdressesManagerForm : Form, IAdressesManagerForm,
        IAdressSearcher,
        IAdressDataDeleter,
        INumericUdDefaultValueSeter,
        INumericUdRestartor,
        ITextBoxRestartor,
        IDgFiller

    {
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressSearcher;
        private IAdressDataDeleter _adressDataDeleter;
        private INumericUdRestartor _numericUdRestartor;
        private ITextBoxRestartor _textBoxRestartor;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private IDgFiller _dgFiller;


        public AdressesManagerForm(IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            IAdressDataDeleter adressDataDeleter,
            INumericUdRestartor numericUdRestartor,
            ITextBoxRestartor textBoxRestartor,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            IDgFiller dgFiller)
        {
            InitializeComponent();
            _adressesDataGeter = adressesDataGeter;
            _adressSearcher = adressSearcher;
            _adressDataDeleter = adressDataDeleter;
            _numericUdRestartor = numericUdRestartor;
            _textBoxRestartor = textBoxRestartor;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _dgFiller = dgFiller;
        }

        public void DeleteAdressData(object id)
        {
            _adressDataDeleter.DeleteAdressData(id);
        }

        public void DeleteAdressData(AdressTable adress)
        {
            _adressDataDeleter.DeleteAdressData(adress);

        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressSearcher.SearchInAdresses(adresses, adressId, userId, userName, city, street, alley, houseNumber, postalCode);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        private void AdressesManagerForm_Load(object sender, EventArgs e)
        {
            RefreshForm();

        }
        void RefreshForm()
        {
            FillDg(AdressDG, GetAdressesData());
            RestartTextBox(txtUserName, txtCity, txtStreet, txtAlleyName, txtHouseNumber);
            RestartNumericUd(txtPostalCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDg(AdressDG, SearchInAdresses(GetAdressesData(), null, null, txtUserName.Text, txtCity.Text, txtStreet.Text, txtAlleyName.Text, txtHouseNumber.Text, (long)txtPostalCode.Value));
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void DeleteAdressBtn_Click(object sender, EventArgs e)
        {
            if (AdressDG.CurrentRow != null) {
                if (MessageBox.Show($"از حذف این آدرس مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteAdressData(AdressDG.CurrentRow.Cells[0].Value);
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("آدرسی انتخاب نشده است");
            }
        }
    }
}
