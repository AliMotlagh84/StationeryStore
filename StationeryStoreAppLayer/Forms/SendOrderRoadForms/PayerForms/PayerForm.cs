using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaMakers;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.LabelSeters;
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

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms
{
    public partial class PayerForm : Form,IPayerForm,
        ICaptchaMaker,
        ILabelFillerByText,
        IDraftOrderTotalAmountsSumByUserIdGeter
    {
        List<DraftOrdersTable> draftOrdersTable ;

        private ICaptchaMaker _captchaMaker;
        private ILabelFillerByText _labelFillerByText;  
        private IDraftOrderTotalAmountsSumByUserIdGeter _draftOrderTotalAmountsSumByUserIdGeter;
        private AdressTable adressInfo;
        private UserTable userInfo;
        private Random randomCaptcha;

        AdressTable IPayerForm.AdressInfo { get => adressInfo; set => adressInfo = value; }
        UserTable IPayerForm.UserInfo { get => userInfo; set => userInfo = value; }
        Random IPayerForm.randomCaptcha { get => randomCaptcha; set => randomCaptcha = value; }

        public PayerForm(
            ICaptchaMaker captchaMaker,
            ILabelFillerByText labelFillerByText,
            IDraftOrderTotalAmountsSumByUserIdGeter draftOrderTotalAmountsSumByUserIdGeter
            )
        {
            InitializeComponent();
            _captchaMaker = captchaMaker;
            _labelFillerByText = labelFillerByText;
            _draftOrderTotalAmountsSumByUserIdGeter = draftOrderTotalAmountsSumByUserIdGeter;
        }

        private void PayerForm_Load(object sender, EventArgs e)
        {
            UpdateRandom();
            MakeCaptcha(CaptchaPB,randomCaptcha);
            SetLabelText(TotalAmountLbl,GetDraftOrderTotalAmountsSumByUserId(userInfo.UserId).ToString());
        }
        void UpdateRandom()
        {
            randomCaptcha = new Random();
        }

        public void MakeCaptcha(PictureBox pictureBox, Random random)
        {
            _captchaMaker.MakeCaptcha(pictureBox, random);
        }

        public void SetLabelText(Label label, string text)
        {
            _labelFillerByText.SetLabelText(label, text);
        }

        public long GetDraftOrderTotalAmountsSumByUserId(int userId)
        {
            return _draftOrderTotalAmountsSumByUserIdGeter.GetDraftOrderTotalAmountsSumByUserId(userId);
        }
    }
}
