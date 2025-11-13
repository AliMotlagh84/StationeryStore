using StationeryStoreAppLayer.Forms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
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
        public StoreManagerForm(IProductsManagerFormOpener productsManagerFormOpener)
        {
            InitializeComponent();
            _productsManagerFormOpener = productsManagerFormOpener;
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
    }
}
