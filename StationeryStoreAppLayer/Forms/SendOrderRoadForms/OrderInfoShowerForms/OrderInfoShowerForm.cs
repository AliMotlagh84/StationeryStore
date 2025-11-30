using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms.OrderShowInfoHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderRoadHelpers.OrderRoadHandlers;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers;
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

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms
{
    public partial class OrderInfoShowerForm : Form, IOrderInfoShowerForm,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        ITextBoxFiller,
        IDgFiller,
        IOrderRoadHandler,
        IPayerFormOpener
    {
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private ITextBoxFiller _textBoxFiller;
        private IDgFiller _dgFiller;
        private IOrderRoadHandler _orderRoadHandler;
        private IPayerFormOpener _payerFormOpener;
        private UserTable userInfo { get; set; }
        private AdressTable adressInfo { get; set; }
        UserTable IOrderInfoShowerForm.UserInfo { get => userInfo; set => userInfo = value; }
        AdressTable IOrderInfoShowerForm.AdressInfo { get => adressInfo; set => adressInfo = value; }

        public OrderInfoShowerForm(
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            ITextBoxFiller textBoxFiller,
            IDgFiller dgFiller,
            IOrderRoadHandler orderRoadHandler,
            IPayerFormOpener payerFormOpener
            )
        {
            InitializeComponent();
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _textBoxFiller = textBoxFiller;
            _dgFiller = dgFiller;
            _payerFormOpener = payerFormOpener;
            _orderRoadHandler = orderRoadHandler;
        }

        private void OrderInfoShowerForm_Load(object sender, EventArgs e)
        {
            FillDg(DraftOrdersDG, SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId));
            txtCity.Text = adressInfo.City;
            txtStreet.Text = adressInfo.Street;
            txtAlley.Text = adressInfo.Alley;
            txtHouseNumber.Text = adressInfo.HouseNumber;
            txtPostalCode.Text = adressInfo.PostalCode.ToString();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید سفارش را  لغو کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                DialogResult = DialogResult.OK;

            }
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {

        }

        private void GoBackBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public void FillTextBox(TextBox textBox, string? text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        private void SendOrderBtn_Click(object sender, EventArgs e)
        {
            HandleOrderRoad(this, OpenPayerForm(this,userInfo,adressInfo));
        }

        public void HandleOrderRoad(Form thisForm, DialogResult nextFormDialogResult)
        {
            _orderRoadHandler.HandleOrderRoad(thisForm, nextFormDialogResult);
        }

        public DialogResult OpenPayerForm(Form senderForm, UserTable userInfo, AdressTable adressInfo)
        {
            return _payerFormOpener.OpenPayerForm(senderForm,userInfo,adressInfo);
        }
    }
}
