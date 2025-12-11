using StationaryStoreUtility.Convertores.DateConvertors;
using StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.ManagerForms.OrderManagerForms.OrderManagerFormHelpers.OrderCancelingHandlers;
using StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.ManagerForms.OrderManagerForms
{
    public partial class OrderManagerForm : Form, IOrderManagerForm,
        IOrdersDataGeter,
        IOrderSearcher,
        IOrderDataDeleter,
        IDgOrdersFiller,
        ITextBoxRestartor,
        IComboRestartor,
        INumericUdRestartor,
        IMaskedTextBoxRestartor,
        IBoolComboFiller,
        INumericUdDefaultValueSeter,
        IOrderCancelingHandler

    {
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;
        private IOrderDataDeleter _orderDataDeleter;
        private IDgOrdersFiller _dgOrdersFiller;
        private ITextBoxRestartor _textBoxRestartor;
        private IComboRestartor _comboRestartor;
        private INumericUdRestartor _numericUdRestartor;
        private IMaskedTextBoxRestartor _maskedTextBoxRestartor;
        private IBoolComboFiller _boolComboFiller;
        private INumericUdDefaultValueSeter _umericUdDefaultValueSeter;
        private IOrderCancelingHandler _orderCancelingHandler;

        public OrderManagerForm(
            IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IOrderDataDeleter orderDataDeleter,
            IDgOrdersFiller dgOrdersFiller,
            ITextBoxRestartor textBoxRestartor,
            IComboRestartor comboRestartor,
            INumericUdRestartor numericUdRestartor,
            IMaskedTextBoxRestartor maskedTextBoxRestartor,
            IBoolComboFiller boolComboFiller,
            INumericUdDefaultValueSeter umericUdDefaultValueSeter,
            IOrderCancelingHandler orderCancelingHandler
            )
        {
            InitializeComponent();
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _orderDataDeleter = orderDataDeleter;
            _dgOrdersFiller = dgOrdersFiller;
            _textBoxRestartor = textBoxRestartor;
            _comboRestartor = comboRestartor;
            _numericUdRestartor = numericUdRestartor;
            _maskedTextBoxRestartor = maskedTextBoxRestartor;
            _boolComboFiller = boolComboFiller;
            _umericUdDefaultValueSeter = umericUdDefaultValueSeter;
            _orderCancelingHandler = orderCancelingHandler;
        }

        public void FillBoolCombo(ComboBox comboBox, string allDisplay, string trueDispaly, string falseDispaly)
        {
            _boolComboFiller.FillBoolCombo(comboBox, allDisplay, trueDispaly, falseDispaly);
        }

        public void FillDgOrders(DataGridView dg, List<OrdersTable> orderData)
        {
            _dgOrdersFiller.FillDgOrders(dg, orderData);
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

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders, orderId, userId, userName, minDate, maxDate, minAmount, maxAmount, deliveryState);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _umericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        private void OrderManagerForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            FillBoolCombo(DeliveryStateCombo, "همه", "تحویل داده شده", "در انتظار رسیدن");
            SetNumericUdDefaultValue(0, txtMinAmount, txtMaxAmount);
            FillDgOrders(DgOrders, GetOrdersData());
            RestartCombo(DeliveryStateCombo);
            RestartMaskedTextBox(MinDatetxt, MaxDatetxt);
            RestartNumericUd(txtMinAmount, txtMaxAmount);
            RestartTextBox(txtUserName);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FillDgOrders(DgOrders, SearchInOrders(GetOrdersData(), null, null, txtUserName.Text, MinDatetxt.Text, MaxDatetxt.Text, (long?)txtMinAmount.Value, (long?)txtMaxAmount.Value, (bool?)DeliveryStateCombo.SelectedValue));
        }

        public void DeleteOrderData(OrdersTable order)
        {
            _orderDataDeleter.DeleteOrderData(order);
        }

        public void DeleteOrderData(object orderId)
        {
            _orderDataDeleter.DeleteOrderData(orderId);
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (DgOrders.CurrentRow != null)
            {
                if (MessageBox.Show("در صورت حذف یک سفارش در صورت  در حال انتظار بودن , سفارش لغو خواهد شد !!", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteOrderData(DgOrders.CurrentRow.Cells[0].Value);
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("سفارشی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            CancelOrder((int)DgOrders.CurrentRow.Cells[0].Value);
            RefreshForm();
        }

        public void CancelOrder(int orderId)
        {
            _orderCancelingHandler.CancelOrder(orderId);
        }
    }
}
