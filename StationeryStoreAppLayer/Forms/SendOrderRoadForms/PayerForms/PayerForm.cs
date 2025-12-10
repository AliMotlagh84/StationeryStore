using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderInfoShowerForms.OrderShowInfoHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaMakers;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.DiscountedAmountCalculator;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.PayerFormValidateHandlers;
using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.LabelSeters;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.PublicHelpers.Validators.MaskedTextBoxValidators;
using StationeryStoreInfrastructureLayer.Models;
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

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms
{
    public partial class PayerForm : Form, IPayerForm,
        ICaptchaMaker,
        ILabelFillerByText,
        IDraftOrderTotalAmountsSumByUserIdGeter,
        IDiscountedAmountCaculator,
        INumericUdDefaultValueSeter,
        IPayerFormValidateHandler,
        IOrderSenderFormOpener

    {
        List<DraftOrdersTable> draftOrdersTable;

        private ICaptchaMaker _captchaMaker;
        private ILabelFillerByText _labelFillerByText;
        private IDraftOrderTotalAmountsSumByUserIdGeter _draftOrderTotalAmountsSumByUserIdGeter;
        private IDiscountedAmountCaculator _discountedAmountCaculator;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        private IPayerFormValidateHandler _payerFormValidateHandler;
        private IOrderSenderFormOpener _orderSenderFormOpener;
        private AdressTable adressInfo;
        private UserTable userInfo;
        private Random captchaRnd;
        private string captchaCode;

        AdressTable IPayerForm.AdressInfo { get => adressInfo; set => adressInfo = value; }
        UserTable IPayerForm.UserInfo { get => userInfo; set => userInfo = value; }
        Random IPayerForm.CaptchaRnd { get => captchaRnd; set => value = captchaRnd; }
        string IPayerForm.CaptchaCode { get => captchaCode; set => value = captchaCode; }

        public PayerForm(
            ICaptchaMaker captchaMaker,
            ILabelFillerByText labelFillerByText,
            IDraftOrderTotalAmountsSumByUserIdGeter draftOrderTotalAmountsSumByUserIdGeter,
            IDiscountedAmountCaculator discountedAmountCaculator,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter,
            IPayerFormValidateHandler payerFormValidateHandler,
            IOrderSenderFormOpener orderSenderFormOpener
            )
        {
            InitializeComponent();
            _captchaMaker = captchaMaker;
            _labelFillerByText = labelFillerByText;
            _draftOrderTotalAmountsSumByUserIdGeter = draftOrderTotalAmountsSumByUserIdGeter;
            _discountedAmountCaculator = discountedAmountCaculator;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _payerFormValidateHandler = payerFormValidateHandler;
            _orderSenderFormOpener = orderSenderFormOpener;


        }

        private void PayerForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            UpdateCaptchaCode(ref captchaRnd, ref captchaCode);
            SetLabelText(TotalAmountLbl, GetDraftOrderTotalAmountsSumByUserId(userInfo.UserId).ToString());
            SetLabelText(DiscountedAmountLbl, CalculateDiscountedAmount<double>(GetDraftOrderTotalAmountsSumByUserId(userInfo.UserId), "precentageDiscount", 0.1, new PercentageDiscountCalculator()).ToString());
            SetNumericUdDefaultValue(1111, txtPassword);
        }

        void UpdateCaptchaCode(ref Random captchaRnd, ref string captchaCode)
        {
            captchaRnd = new Random();
            captchaCode = MakeCaptcha(CaptchaPB, captchaRnd);
        }

        public string MakeCaptcha(PictureBox pictureBox, Random random)
        {
            return _captchaMaker.MakeCaptcha(pictureBox, random);
        }

        public void SetLabelText(Label label, string text)
        {
            _labelFillerByText.SetLabelText(label, text);
        }

        public long GetDraftOrderTotalAmountsSumByUserId(int userId)
        {
            return _draftOrderTotalAmountsSumByUserIdGeter.GetDraftOrderTotalAmountsSumByUserId(userId);
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

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (CanUserPay(txtDebitCardNumber, txtCVV2, txtCaptcha, (int)txtPassword.Value, txtCaptcha.Text, captchaCode))
            {
                var discountedTotalAmount = CalculateDiscountedAmount<double>(GetDraftOrderTotalAmountsSumByUserId(userInfo.UserId), "precentageDiscount", 0.1, new PercentageDiscountCalculator());
                OpenPayerFormSender(this, userInfo, discountedTotalAmount);
                Refresh();
            }
        }

        public long CalculateDiscountedAmount<T>(long amount, string discountName, T discountValue, IDiscountCalculator discountCalculator) where T : INumber<T>
        {
            return _discountedAmountCaculator.CalculateDiscountedAmount<T>(amount, discountName, discountValue, discountCalculator);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public void OpenPayerFormSender(Form senderForm, UserTable userInfo, long orderTotalAmount)
        {
            _orderSenderFormOpener.OpenPayerFormSender(senderForm, userInfo, orderTotalAmount);
        }

        public bool CanUserPay(MaskedTextBox cardNumber, MaskedTextBox cVV2, MaskedTextBox txtCaptcha, int password, string userCaptchaCode, string captchaCode)
        {
            return _payerFormValidateHandler.CanUserPay(cardNumber, cVV2, txtCaptcha, password, userCaptchaCode, captchaCode);
        }

        private void CaptchaPB_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCapchaBtn_Click(object sender, EventArgs e)
        {
            UpdateCaptchaCode(ref captchaRnd,ref captchaCode);
        }
    }
}
