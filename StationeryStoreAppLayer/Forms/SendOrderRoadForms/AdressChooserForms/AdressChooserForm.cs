using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.AdressChooserFormValidateHandlers;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderRoadHelpers.OrderRoadHandlers;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.FormTextSeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
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
        ITextBoxRestartor,
        IDgFiller,
        IOrderInfoShowerFormOpener,
        IOrderRoadHandler,
        IAdressChooserFormValidateHandler



    {

        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressSearcher;
        private ITextBoxFiller _textBoxFiller;
        private ITextBoxRestartor _textBoxRestartor;
        private IDgFiller _dgFiller;
        private IOrderInfoShowerFormOpener _orderInfoShowerFormOpener;
        private IOrderRoadHandler _orderRoadHandler;
        private IAdressChooserFormValidateHandler _AdressChooserFormValidateHandler;

        public AdressChooserForm(
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            ITextBoxFiller textBoxFiller,
            ITextBoxRestartor textBoxRestartor,
            IDgFiller dgFiller,
            IOrderInfoShowerFormOpener orderInfoShowerFormOpener,
            IOrderRoadHandler orderRoadHandler,
            IAdressChooserFormValidateHandler AdressChooserFormValidateHandler
            )
        {
            InitializeComponent();
            _adressesDataGeter = adressesDataGeter;
            _adressSearcher = adressSearcher;
            _textBoxFiller = textBoxFiller;
            _textBoxRestartor = textBoxRestartor;
            _dgFiller = dgFiller;
            _orderInfoShowerFormOpener = orderInfoShowerFormOpener;
            _orderRoadHandler = orderRoadHandler;
            _AdressChooserFormValidateHandler = AdressChooserFormValidateHandler;
        }

        private UserTable userInfo;
        UserTable IAdressChooserForm.UserInfo { get => userInfo; set => userInfo = value; }
        private void AdressChooserForm_Load(object sender, EventArgs e)
        {
            RestartTextBox(txtCity,txtHouseNumber,txtPostalCode);
            FillDg(AdressDG, SearchInAdresses(GetAdressesData(), null, userInfo.UserId));
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
            DialogResult = DialogResult.Cancel;
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید سفارش را  لغو کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                DialogResult = DialogResult.OK;

            }
        }

        private void SendOrderBtn_Click(object sender, EventArgs e)
        {
            if (AdressDG.CurrentRow != null)
            {
                if (HandleAdressFormValidate(txtCity.Text, txtHouseNumber.Text, txtPostalCode.Text))
                {
                    var selectedAdress = SearchInAdresses(GetAdressesData(), (object?)(AdressDG.CurrentRow.Cells[0].Value)).First();
                    HandleOrderRoad(this, OpenOrderInfoShowerForm(this, userInfo, selectedAdress));

                }
            }
            else
            {
                MessageBox.Show("پیش سفارسی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public DialogResult OpenOrderInfoShowerForm(Form senderForm, UserTable userInfo, AdressTable OrderAdress)
        {
            return _orderInfoShowerFormOpener.OpenOrderInfoShowerForm(senderForm, userInfo, OrderAdress);
        }

        public void HandleOrderRoad(Form thisForm, DialogResult nextFormDialogResult)
        {
            _orderRoadHandler.HandleOrderRoad(thisForm, nextFormDialogResult);
        }
        public bool HandleAdressFormValidate(string txtCity, string txtHouseNumber, string txtPostalNumber)
        {
            return _AdressChooserFormValidateHandler.HandleAdressFormValidate(txtCity, txtHouseNumber, txtPostalNumber);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }
    }
}
