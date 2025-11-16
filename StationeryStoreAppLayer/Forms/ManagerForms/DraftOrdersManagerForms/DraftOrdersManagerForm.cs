using StationeryStoreAppLayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreAppLayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
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

namespace StationeryStoreAppLayer.Forms.ManagerForms.DraftOrdersManagerForms
{
    public partial class DraftOrdersManagerForm : Form, IDraftOrdersManagerForm,
     IDraftOrderDataGeter,
     IDraftOrderDataBuilder,
     IDraftOrderDataDeleter,
     IDraftOrderSearcher,
     IBrandDataGeter,
     IBrandsComboDataGeter,
     INumericUdDefaultValueSeter,
     IDgFiller,
     IComboBoxFiller,
     IComboRestartor,
     ITextBoxRestartor,
     INumericUdRestartor






    {

        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IBrandDataGeter _brandDataGeter;
        private IBrandsComboDataGeter _brandComboDataGeter;
        private INumericUdDefaultValueSeter _umericUdDefaultValueSeter;
        private IDgFiller _dgFiller;
        private IComboBoxFiller _comboBoxFiller;
        private IComboRestartor _comboRestartor;
        private INumericUdRestartor _numericUdRestartor;
        private ITextBoxRestartor _textBoxRestartor;

        public DraftOrdersManagerForm(
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderDataBuilder draftOrderDataBuilder,
            IDraftOrderDataDeleter draftOrderDataDeleter,
            IDraftOrderSearcher draftOrderSearcher,
            IBrandDataGeter brandDataGeter,
            IBrandsComboDataGeter brandComboDataGeter,
            INumericUdDefaultValueSeter umericUdDefaultValueSeter,
            IDgFiller dgFiller,
            IComboBoxFiller comboBoxFiller,
            IComboRestartor comboRestartor,
            INumericUdRestartor numericUdRestartor,
            ITextBoxRestartor textBoxRestartor
            )
        {
            InitializeComponent();
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _draftOrderDataDeleter = draftOrderDataDeleter;
            _draftOrderSearcher = draftOrderSearcher;
            _brandDataGeter = brandDataGeter;
            _brandComboDataGeter = brandComboDataGeter;
            _umericUdDefaultValueSeter = umericUdDefaultValueSeter;
            _textBoxRestartor = textBoxRestartor;
            _dgFiller = dgFiller;
            _comboBoxFiller = comboBoxFiller;
            _comboRestartor = comboRestartor;
            _numericUdRestartor = numericUdRestartor;
            _textBoxRestartor = textBoxRestartor;
        }

        private void DraftOrdersManagerForm_Load(object sender, EventArgs e)
        {
            FillDg(DraftOrdersDG, GetDraftOrderData());
            FillCombo(BarndIdCombo, GetBrandsComboData(GetBrandsData()), "BrandName", "BrandId");
            SetNumericUdDefaultValue(0, txtMaxAmount, txtMinAmount, MaxTotalAmountTxt, MinTotalAmounttxt,txtMinRequestedCount, txtMaxRequestedCount);
        }
        private void RefreshForm()
        {
            FillDg(DraftOrdersDG, GetDraftOrderData());
            RestartCombo(BarndIdCombo);
            RestartTextBox(txtProductName, txtUserName);
            RestartNumericUd(txtMinAmount, txtMaxAmount, txtMaxRequestedCount, txtMinRequestedCount, MinTotalAmounttxt, MaxTotalAmountTxt);
        }

        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);

        }

        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox, data, displayMember, ValueMember);
        }

        public List<BrandsTable> GetBrandsComboData(List<BrandsTable> brandsData)
        {
            return _brandComboDataGeter.GetBrandsComboData(brandsData);
        }

        public List<BrandsTable> GetBrandsData()
        {
            return _brandDataGeter.GetBrandsData();
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public void RestartCombo(params ComboBox[] comboBoxes)
        {
            _comboRestartor.RestartCombo(comboBoxes);
        }

        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            _numericUdRestartor.RestartNumericUd(numericUpDowns);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _umericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FillDg(DraftOrdersDG, SearchInDraftOrders(GetDraftOrderData(), null, null, txtUserName.Text, null, txtProductName.Text, (int?)BarndIdCombo.SelectedValue, null, (int?)txtMinRequestedCount.Value, (int?)txtMaxRequestedCount.Value, (long?)txtMinAmount.Value, (long?)txtMaxAmount.Value, (long?)MinTotalAmounttxt.Value, (long?)MaxTotalAmountTxt.Value));
        }

        private void RefreshFrom_Click(object sender, EventArgs e)
        {
            RefreshForm();
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

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderDataBuilder.BuildDraftOrderData(userId, userName, productId, productName, brandId, brandName, productAmount, requestedCount, DraftOrderIdForEdit);
        }
    }
}
