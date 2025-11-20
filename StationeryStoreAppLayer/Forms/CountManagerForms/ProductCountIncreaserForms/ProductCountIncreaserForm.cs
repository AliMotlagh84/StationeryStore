using StationeryStoreAppLayer.Forms.CountManagerForms.ProductCountIncreaserForms;
using StationeryStoreAppLayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
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

namespace StationeryStoreAppLayer.Forms.ProductCountIncreaserForms
{
    public partial class ProductCountIncreaserForm : Form,
        IProductCountIncreaserForm,
        INumericUdDefaultValueSeter
    {

        ProductsTable IProductCountIncreaserForm.ProductsInfo { get => productsInfo; set => productsInfo = value; }

        private ProductsTable productsInfo { get; set; }
        private IProductDataEditor _productDataEditor { get; set; }
        private IProductCountIncreaser _productCountIncreaser { get; set; }
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter { get; set; }

        public ProductCountIncreaserForm(
            IProductDataEditor productDataEditor,
            IProductCountIncreaser productCountIncreaser,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter

            )
        {
            InitializeComponent();
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _productDataEditor = productDataEditor;
            _productCountIncreaser = productCountIncreaser;
        }


        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            
           
            EditProductData(IncreaseProductCount(productsInfo, (int)ProductCountTxt.Value));
            MessageBox.Show($"تعداد {productsInfo.ProductName} با موفقیت به روزرسانی شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void ProductCountIncreaserForm_Load(object sender, EventArgs e)
        {
            SetNumericUdDefaultValue(0, ProductCountTxt);
        }

        public ProductsTable IncreaseProductCount(ProductsTable product, int IncreaseCount)
        {
            return _productCountIncreaser.IncreaseProductCount(product, IncreaseCount);
        }
    }
}
