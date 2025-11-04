using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
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

namespace StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_
{
    public partial class ProductsManagerForm : Form,
        IProductsManagerForm,
        IProductDataEditor,
        IProductDataBuilder,
        IProductsDataGeter,
        IDgFiller

    {

        private IDgFiller _dgFiller;
        private IProductDataEditor _productDataEditor;
        private IProductDataBuilder _productDataBuilder;
        private IProductsDataGeter _productDataGeter;
        public ProductsManagerForm(
            IProductDataBuilder productDataBuilder,
            IProductsDataGeter productsDataGeter,
            IProductDataEditor productDataEditor,
            IDgFiller dgFiller
            )
        {
            InitializeComponent();
            _dgFiller = dgFiller;
            _productDataBuilder = productDataBuilder;
            _productDataGeter = productsDataGeter;
            _productDataEditor = productDataEditor;
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime, ProductIdForEdit);
        }

        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);

        }

        public List<ProductsTable> GetProductsData()
        {
            return _productDataGeter.GetProductsData();
        }

        private void ProductsManagerForm_Load(object sender, EventArgs e)
        {
            FillDg<ProductsTable>(DGPruducts,GetProductsData());
        }


    }
}
