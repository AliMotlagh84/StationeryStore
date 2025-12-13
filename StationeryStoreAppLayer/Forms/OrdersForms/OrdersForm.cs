using StationerStoreApplicationLayer.Deleters.OrderDeleters;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.FormOpeners;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.OrderCancelers;
using StationeryStoreUILayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreUILayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreUILayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.OrdersForms
{
    public partial class OrdersForm : Form, IOrdersForm,
        IOrdersDataGeter,
        IOrderSearcher,
        IOrderDeleter,
        IOrderCanceler,
        IDgOrdersFiller,
        IComboRestartor,
        IMaskedTextBoxRestartor,
        INumericUdRestartor,
        INumericUdDefaultValueSeter,
        IBoolComboFiller,
        IOrderInfoFormOpener
    {
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;
        private IOrderDeleter _orderDeleter;
        private IOrderCanceler _orderCanceler;
        private IDgOrdersFiller _dgOrdersFiller;
        private IComboRestartor _comboRestartor;
        private IMaskedTextBoxRestartor _maskedTextBoxRestartor;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private INumericUdRestartor _numericUdRestartor;
        private IBoolComboFiller _boolComboFiller;
        private IOrderInfoFormOpener _orderInfoFormOpener;

        public OrdersForm(IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IOrderDeleter orderDeleter,
            IDgOrdersFiller dgOrdersFiller,
            IComboRestartor comboRestartor,
            IMaskedTextBoxRestartor maskedTextBoxRestartor,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            INumericUdRestartor numericUdRestartor,
            IBoolComboFiller boolComboFiller,
            IOrderCanceler orderCanceler,
            IOrderInfoFormOpener orderInfoFormOpener)
        {
            InitializeComponent();
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _orderDeleter = orderDeleter;
            _dgOrdersFiller = dgOrdersFiller;
            _comboRestartor = comboRestartor;
            _maskedTextBoxRestartor = maskedTextBoxRestartor;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _numericUdRestartor = numericUdRestartor;
            _boolComboFiller = boolComboFiller;
            _orderCanceler = orderCanceler;
            _orderInfoFormOpener = orderInfoFormOpener;
        }

        UserTable userInfo;
        UserTable IOrdersForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void RefreshForm()
        {
            FillBoolCombo(DeliveryStateCombo, "همه", "تحویل داده شده", "در انتظار رسیدن");
            SetNumericUdDefaultValue(0, txtMinAmount, txtMaxAmount);
            FillDgOrders(DgOrders, SearchInOrders(GetOrdersData(), null, userInfo.UserId));
            RestartCombo(DeliveryStateCombo);
            RestartMaskedTextBox(MinDatetxt, MaxDatetxt);
            RestartNumericUd(txtMinAmount, txtMaxAmount);
        }
        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders, orderId, userId, userName, minDate, maxDate, minAmount, maxAmount, deliveryState);
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public void RestartCombo(params ComboBox[] comboBoxes)
        {
            _comboRestartor.RestartCombo(comboBoxes);
        }

        public void RestartMaskedTextBox(params MaskedTextBox[] maskedTextBoxes)
        {
            _maskedTextBoxRestartor.RestartMaskedTextBox(maskedTextBoxes);
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public void FillBoolCombo(ComboBox comboBox, string allDisplay, string trueDispaly, string falseDispaly)
        {
            _boolComboFiller.FillBoolCombo(comboBox, allDisplay, trueDispaly, falseDispaly);
        }

        public void DeleteOrder(OrdersTable order)
        {
            _orderDeleter.DeleteOrder(order);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FillDgOrders(DgOrders, SearchInOrders(GetOrdersData(), null, userInfo.UserId, null, MinDatetxt.Text, MaxDatetxt.Text, (long?)txtMinAmount.Value, (long?)txtMaxAmount.Value, (bool?)DeliveryStateCombo.SelectedValue));

        }

        public void FillDgOrders(DataGridView dg, List<OrdersTable> orderData)
        {
            _dgOrdersFiller.FillDgOrders(dg, orderData);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        public void CancelOrder(int orderId)
        {
            _orderCanceler.CancelOrder(orderId);
        }

        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            CancelOrder((int)DgOrders.CurrentRow.Cells[0].Value);
            RefreshForm();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (DgOrders.CurrentRow != null)
            {
                if (MessageBox.Show("در صورت حذف یک سفارش در صورت  در حال انتظار بودن , سفارش لغو خواهد شد !!", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteOrder(SearchInOrders(GetOrdersData(), (int)DgOrders.CurrentRow.Cells[0].Value).FirstOrDefault());
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("سفارشی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenOrderInfoForm(Form senderForm, OrdersTable order)
        {
            _orderInfoFormOpener.OpenOrderInfoForm(senderForm, order);
        }

        private void DgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgOrders.CurrentRow != null)
            {
                if (DgOrders.CurrentCell.ColumnIndex == 6)
                {
                    var order = SearchInOrders(GetOrdersData(), (int)DgOrders.CurrentRow.Cells[0].Value).FirstOrDefault();
                    OpenOrderInfoForm(this, order);
                }
            }
        }
    }
}
