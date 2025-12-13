using StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor;
using StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers;
using StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
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
using StationerStoreApplicationLayer.Deleters.DraftOrderDeleters;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms
{
    public partial class ShoppingCartForm : Form, IShoppingCartForm,
    IDraftOrderSearcher,
    IDraftOrderDataBuilder,
    IDraftOrderDeleter,
    IDgFiller,
    IDraftOrderRequestedCountEditorFormOpener,
    IAdressFormOpener,
    IAdressChooserFormOpeningHandler,
    IOrderFormOpener


    {

        UserTable userInfo { get; set; }
        UserTable IShoppingCartForm.UserInfo { get => userInfo; set => userInfo = value; }

        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDeleter _draftOrderDeleter;
        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDgFiller _dgFiller;
        private IDraftOrderRequestedCountEditorFormOpener _draftOrderRequestedCountEditorFormOpener;
        private IAdressFormOpener _adressFormOpener;
        private IAdressChooserFormOpeningHandler _adressChooserFormOpeningHandler;
        private IOrderFormOpener _orderFormOpener;

        public ShoppingCartForm(
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDeleter draftOrderDeleter,
            IDraftOrderDataBuilder draftOrderDataBuilder,
            IDgFiller dgFiller,
            IDraftOrderRequestedCountEditorFormOpener draftOrderRequestedCountEditorFormOpener,
            IAdressFormOpener adressFormOpener,
            IAdressChooserFormOpeningHandler adressChooserFormOpeningHandler,
            IOrderFormOpener orderFormOpener
            )
        {
            InitializeComponent();
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDeleter = draftOrderDeleter;
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _dgFiller = dgFiller;
            _draftOrderRequestedCountEditorFormOpener = draftOrderRequestedCountEditorFormOpener;
            _adressFormOpener = adressFormOpener;
            _adressChooserFormOpeningHandler = adressChooserFormOpeningHandler;
            _orderFormOpener = orderFormOpener;
        }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderDataBuilder.BuildDraftOrderData(userId, userName, productId, productName, brandId, brandName, productAmount, requestedCount, DraftOrderIdForEdit);
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            FillDg(DraftOrdersDG, SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId));
        }

        private void DeleteDraftOrderBtn_Click(object sender, EventArgs e)
        {
            if (DraftOrdersDG.CurrentRow != null)
            {
                if (MessageBox.Show($"از حذف این پیش سفارش مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var currentRowCells = DraftOrdersDG.CurrentRow.Cells;
                    DeleteDrfatOrder(BuildDraftOrderData((int)currentRowCells[1].Value, (string)currentRowCells[2].Value, (int)currentRowCells[3].Value, (string)currentRowCells[4].Value, (int)currentRowCells[5].Value, (string)currentRowCells[6].Value, (long)currentRowCells[8].Value, (int)currentRowCells[7].Value, (int)currentRowCells[0].Value));
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("پیش سفارسی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshForm()
        {
            FillDg(DraftOrdersDG, SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId));
        }

        private void DeleteAllDraftOrdersBtn_Click(object sender, EventArgs e)
        {
            if (DraftOrdersDG.CurrentRow != null)
            {
                if (MessageBox.Show($"از حذف پیش سفارش ها مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var drfatOrders = SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId);
                    foreach (var draftOrder in drfatOrders)
                    {
                        DeleteDrfatOrder(draftOrder);
                    }
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("پیش سفارسی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenDraftOrderRequestedCountEditor(DraftOrdersTable draftOrderInfo)
        {
            _draftOrderRequestedCountEditorFormOpener.OpenDraftOrderRequestedCountEditor(draftOrderInfo);
        }

        private void EditDraftOrderCountBtn_Click(object sender, EventArgs e)
        {
            if (DraftOrdersDG.CurrentRow != null)
            {

                var DgCurrentRowCells = DraftOrdersDG.CurrentRow.Cells;
                var draftOrderInfo = BuildDraftOrderData((int)DgCurrentRowCells[1].Value, (string)DgCurrentRowCells[2].Value, (int)DgCurrentRowCells[3].Value, (string)DgCurrentRowCells[4].Value, (int)DgCurrentRowCells[5].Value, (string)DgCurrentRowCells[6].Value, (long)DgCurrentRowCells[8].Value, (int)DgCurrentRowCells[7].Value, (int)DgCurrentRowCells[0].Value);
                OpenDraftOrderRequestedCountEditor(draftOrderInfo);
                RefreshForm();
            }
            else
            {
                MessageBox.Show("پیش سفارسی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteDrfatOrder(DraftOrdersTable draftOrder)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrder);
        }

        public void DeleteDrfatOrder(object draftOrderId)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrderId);

        }

        public void OpenAdressForm(Form senderForm, UserTable userInfo)
        {
            _adressFormOpener.OpenAdressForm(senderForm, userInfo);
        }

        private void AdressFormBtn_Click(object sender, EventArgs e)
        {
            OpenAdressForm(this, userInfo);
        }
        public void HandleAdressChooserFormOpening(Form HandlerForm, UserTable userInfo)
        {
            _adressChooserFormOpeningHandler.HandleAdressChooserFormOpening(HandlerForm, userInfo);
        }

        private void SendOrderBtn_Click(object sender, EventArgs e)
        {
            HandleAdressChooserFormOpening(this, userInfo);
            RefreshForm();
        }

        private void OrdersFormBtn_Click(object sender, EventArgs e)
        {
          OpenOrderForm(this, userInfo);
          RefreshForm() ;
        }

        public void OpenOrderForm(Form senderForm, UserTable userInfo)
        {
            _orderFormOpener.OpenOrderForm(senderForm, userInfo);
        }
    }
}
