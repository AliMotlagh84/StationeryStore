using StationeryStoreAppLayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor;
using StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers;
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

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms
{
    public partial class ShoppingCartForm : Form, IShoppingCartForm,
    IDraftOrderSearcher,
    IDraftOrderDataBuilder,
    IDraftOrderDataDeleter,
    IDgFiller,
    IDraftOrderRequestedCountEditorFormOpener


    {
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDgFiller _dgFiller;
        private IDraftOrderRequestedCountEditorFormOpener _draftOrderRequestedCountEditorFormOpener;
        public ShoppingCartForm(
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataDeleter draftOrderDataDeleter,
            IDraftOrderDataBuilder draftOrderDataBuilder,
            IDgFiller dgFiller,
            IDraftOrderRequestedCountEditorFormOpener draftOrderRequestedCountEditorFormOpener
            )
        {
            InitializeComponent();
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataDeleter = draftOrderDataDeleter;
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _dgFiller = dgFiller;
            _draftOrderRequestedCountEditorFormOpener = draftOrderRequestedCountEditorFormOpener;
        }

        UserTable userInfo { get; set; }
        UserTable IShoppingCartForm.UserInfo { get => userInfo; set => userInfo = value; }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderDataBuilder.BuildDraftOrderData(userId, userName, productId, productName, brandId, brandName, productAmount, requestedCount, DraftOrderIdForEdit);
        }

        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
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
                    DeleteDraftOrderData(BuildDraftOrderData((int)currentRowCells[1].Value, (string)currentRowCells[2].Value, (int)currentRowCells[3].Value, (string)currentRowCells[4].Value, (int)currentRowCells[5].Value, (string)currentRowCells[6].Value, (long)currentRowCells[8].Value, (int)currentRowCells[7].Value, (int)currentRowCells[0].Value));
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
                        DeleteDraftOrderData(draftOrder);
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
    }
}
