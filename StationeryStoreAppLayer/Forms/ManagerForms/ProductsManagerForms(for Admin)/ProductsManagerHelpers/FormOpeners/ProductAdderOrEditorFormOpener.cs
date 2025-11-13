using StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners
{
    public class ProductAdderOrEditorFormOpener<T> : IProductAdderOrEditorFormOpener where T : Form,IProductAdderOrEditorForm
    {
        private T _productAdderOrEditorForm;
        public ProductAdderOrEditorFormOpener(T productAdderOrEditorForm)
        {
            _productAdderOrEditorForm = productAdderOrEditorForm;
        }
        public void OpenProductAdderOrEditorForm(ProductsTable productInfo, bool editMode, Form senderForm)
        {
            senderForm.Hide();
            _productAdderOrEditorForm.ProductsInfo = productInfo;
            _productAdderOrEditorForm.EditMode = editMode;
            _productAdderOrEditorForm.ShowDialog();
            senderForm.Show();

        }
    }
}
