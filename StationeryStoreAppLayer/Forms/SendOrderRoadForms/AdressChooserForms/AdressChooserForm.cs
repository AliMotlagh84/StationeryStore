using StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.FormTextSeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers;
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

namespace StationeryStoreAppLayer.Forms.AdressChooserForms
{
    public partial class AdressChooserForm : Form, IAdressChooserForm,
        IAdressesDataGeter,
        IAdressSearcher,
        ITextBoxFiller,
        IDgFiller



    {

        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressSearcher;
        private ITextBoxFiller _textBoxFiller;
        private IDgFiller _dgFiller;

        public AdressChooserForm(
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            ITextBoxFiller textBoxFiller,
            IDgFiller dgFiller
            )
        {
            InitializeComponent();
            _adressesDataGeter = adressesDataGeter;
            _adressSearcher = adressSearcher;
            _textBoxFiller = textBoxFiller;
            _dgFiller = dgFiller;
        }

        private UserTable userInfo;
        UserTable IAdressChooserForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void AdressChooserForm_Load(object sender, EventArgs e)
        {
            FillDg(AdressDG, SearchInAdresses(GetAdressesData(),null,userInfo.UserId));
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressSearcher.SearchInAdresses(adresses, adressId, userId, userName, city, street, alley, houseNumber, postalCode);
        }
        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        private void AdressDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedAdress = SearchInAdresses(GetAdressesData(), (object?)(AdressDG.CurrentRow.Cells[0].Value)).First();

            txtCity.Text = selectedAdress.City;
            txtHouseNumber.Text = selectedAdress.HouseNumber;
            txtPostalCode.Text = selectedAdress.PostalCode.ToString();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
           _dgFiller.FillDg(dg, data);
        }
    }
}
