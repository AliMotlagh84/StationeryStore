using StationeryStoreUILayer.Forms.CountManagerForms.ProductCountIncreaserForms;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.FormOpeners
{
    public class ProductCountIncreaserFormOpener<T> : IProductCountIncreaserFormOpener where T : Form,IProductCountIncreaserForm
    {
        private T _productCountIncreaserForm;
        public ProductCountIncreaserFormOpener(T productCountIncreaserForm)
        {
            _productCountIncreaserForm = productCountIncreaserForm;
        }
        public void OpenProductCountIncreaserForm(ProductsTable productInfo)
        {
            _productCountIncreaserForm.ProductsInfo = productInfo;
            _productCountIncreaserForm.ShowDialog();
        }
    }
}
