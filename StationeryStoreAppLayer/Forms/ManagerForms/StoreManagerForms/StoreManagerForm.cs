using StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms;
using StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.StoreManagerForms
{
    public partial class StoreManagerForm : Form, IStoreManagerForm
    {
        private IProductsManagerFormOpener _productsManagerFormOpener;
        private IBrandsManagerFormOpener _brandsManagerFormOpener;
        public StoreManagerForm(IProductsManagerFormOpener productsManagerFormOpener,
            IBrandsManagerFormOpener brandsManagerFormOpener)
        {
            InitializeComponent();
            _productsManagerFormOpener = productsManagerFormOpener;
            _brandsManagerFormOpener = brandsManagerFormOpener;
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
    }
}
