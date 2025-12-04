using StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms;
using StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.StoreManagerForms
{
    public partial class StoreManagerForm : Form, IStoreManagerForm
    {
        private IProductsManagerFormOpener _productsManagerFormOpener;
        private IBrandsManagerFormOpener _brandsManagerFormOpener;
        private IUserManagerFormOpener _userManagerFormOpener;
        private IDraftOrdersManagerFormOpener _draftOrdersManagerFormOpener;
        public StoreManagerForm(IProductsManagerFormOpener productsManagerFormOpener,
            IBrandsManagerFormOpener brandsManagerFormOpener,
            IDraftOrdersManagerFormOpener draftOrdersManagerFormOpener,
            IUserManagerFormOpener userManagerFormOpener)
        {
            InitializeComponent();
            _productsManagerFormOpener = productsManagerFormOpener;
            _brandsManagerFormOpener = brandsManagerFormOpener;
            _draftOrdersManagerFormOpener = draftOrdersManagerFormOpener;
            _userManagerFormOpener = userManagerFormOpener;
        }

        public void OpenProductsManagerForm(Form? senderFormToHide = null)
        {
            _productsManagerFormOpener.OpenProductsManagerForm(senderFormToHide);
        }

        private void StoreManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void ProductManagementPB_Click(object sender, EventArgs e)
        {
            OpenProductsManagerForm(this);
        }

        private void BrandsManagementPB_Click(object sender, EventArgs e)
        {
            OpneBrandsManagerForm(this);
        }

        public void OpneBrandsManagerForm(Form senderForm)
        {
            _brandsManagerFormOpener.OpneBrandsManagerForm(senderForm);
        }

        private void DraftOrdersManagementPB_Click(object sender, EventArgs e)
        {
            OpenDraftOrdersManagerForm(this);
        }

        public void OpenDraftOrdersManagerForm(Form senderForm)
        {
            _draftOrdersManagerFormOpener.OpenDraftOrdersManagerForm(senderForm);
        }

        private void UsersManagementPB_Click(object sender, EventArgs e)
        {
            OpenUserManagerForm(this);
        }

        public void OpenUserManagerForm(Form senderForm)
        {
            _userManagerFormOpener.OpenUserManagerForm(senderForm);
        }
    }
}
