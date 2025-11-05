using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
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

namespace StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms
{
    public partial class ProductAdderOrEditorForm : Form, IProductAdderOrEditorForm
    {
        private ProductsTable productInfo;
        private bool editMode;
        ProductsTable IProductAdderOrEditorForm.ProductsInfo { get => productInfo; set => productInfo = value; }
        bool IProductAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        private IProductDataBuilder _productDataBuilder;
        private IProductDataAdder _productDataAdder;
        private IProductDataEditor _productDataEditor;
        public ProductAdderOrEditorForm(
            IProductDataBuilder productDataBuilder,
            IProductDataAdder productDataAdder,
            IProductDataEditor productDataEditor
            )
        {
            InitializeComponent();
            _productDataBuilder = productDataBuilder;
            _productDataAdder = productDataAdder;
            _productDataEditor = productDataEditor;
        }


        public void AddProductData(ProductsTable newPruduct)
        {
           _productDataAdder.AddProductData(newPruduct);
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit)
        {
            return _productDataBuilder.BuildProductData(newProductName,newBrandId,newBrandName,newProductAmount,newProductCount,addTime,ProductIdForEdit);
        }

        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
        }

        private void ProductAdderOrEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
