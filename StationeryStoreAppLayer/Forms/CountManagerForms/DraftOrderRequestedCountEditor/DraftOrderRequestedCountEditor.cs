using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.Editors.DraftOrderEditors;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
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

namespace StationeryStoreUILayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor
{
    public partial class DraftOrderRequestedCountEditor : Form, IDraftOrderRequestedCountEditor,
        IDraftOrderDataBuilder,
        IDraftOrderEditor,
        INumericUdDefaultValueSeter
    {

        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDraftOrderEditor _draftOrderEditor;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        DraftOrdersTable draftOrdersInfo { get; set; }
        DraftOrdersTable IDraftOrderRequestedCountEditor.DraftOrderInfo { get => draftOrdersInfo; set => draftOrdersInfo = value; }

        public DraftOrderRequestedCountEditor(IDraftOrderDataBuilder draftOrderDataBuilder,
            IDraftOrderEditor draftOrderEditor,
            INumericUdDefaultValueSeter umericUdDefaultValueSeter)
        {
            InitializeComponent();
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _draftOrderEditor = draftOrderEditor;
            _numericUdDefaultValueSeter = umericUdDefaultValueSeter;
        }

        private void DraftOrderRequestedCountEditor_Load(object sender, EventArgs e)
        {
            SetNumericUdDefaultValue(1, txtRequestedCount);
        }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderDataBuilder.BuildDraftOrderData(userId, userName, productId, productName, brandId, brandName, productAmount, requestedCount, DraftOrderIdForEdit);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public void EditDraftOrder(DraftOrdersTable draftOrder, int oldRequestedCount)
        {
            _draftOrderEditor.EditDraftOrder(draftOrder, oldRequestedCount);
        }

        private void EditDraftOrderRequestedCountBtn_Click(object sender, EventArgs e)
        {
            var newDrfatOrder = BuildDraftOrderData(draftOrdersInfo.UserId, draftOrdersInfo.UserName,draftOrdersInfo.ProductId, draftOrdersInfo.ProductName, draftOrdersInfo.BrandId, draftOrdersInfo.BrandName, draftOrdersInfo.Amount,(int)txtRequestedCount.Value,draftOrdersInfo.DraftOrderId);
            EditDraftOrder(newDrfatOrder,draftOrdersInfo.RequestedCount);
            MessageBox.Show("تعداد درخواستی با موفقیت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
