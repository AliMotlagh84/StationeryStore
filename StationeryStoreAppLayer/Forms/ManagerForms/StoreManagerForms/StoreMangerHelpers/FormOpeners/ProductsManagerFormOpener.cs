using StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class ProductsManagerFormOpener<T> : IProductsManagerFormOpener where T : Form,IProductsManagerForm
    {
        private T _productsManagerForm;
        public ProductsManagerFormOpener(T productsManagerForm)
        {
            _productsManagerForm = productsManagerForm;
        }
        public void OpenProductsManagerForm(Form? senderFormToHide = null)
        {
            senderFormToHide?.Hide();
                _productsManagerForm.ShowDialog();
            senderFormToHide?.Show();

        }
    }
}
