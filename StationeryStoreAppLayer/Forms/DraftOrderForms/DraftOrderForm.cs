using StationeryStoreAppLayer.Forms.DraftOrderForms.DraftOrderHelpers.ProductCountCheckers;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.DraftOrderForms
{
    public partial class DraftOrderForm : Form,
        IDraftOrderForm,
        INumericUdDefaultValueSeter,
        IProductDataBuilder,
        IProductDataEditor
    {
        private UserTable orderer;
        private ProductsTable selectedProduct;
        private IProductCountChecker _productCountChecker;
        private IProductDataEditor _productDataEditor;
        private IProductDataBuilder _productDataBuilder;
        private IDraftOrderDataBuilder _draftOrderBuilder;
        private IDraftOrderDataAdder _draftOrderSender;
        private INumericUdDefaultValueSeter _numericUdDefaultValueSeter;
        ProductsTable IDraftOrderForm.SelectedProduct { get => selectedProduct; set => selectedProduct = value; }
        UserTable IDraftOrderForm.Orderer { get => orderer; set => orderer = value; }

        public DraftOrderForm(
            IProductCountChecker productCountChecker,
            IProductDataEditor productDataEditor,
            IProductDataBuilder productDataBuilder,
            IDraftOrderDataBuilder draftOrderBuilder,
            IDraftOrderDataAdder draftOrderSender,
            INumericUdDefaultValueSeter numericUdDefaultValueSeter
            )

        {
            InitializeComponent();
            _productCountChecker = productCountChecker;
            _productDataEditor = productDataEditor;
            _draftOrderSender = draftOrderSender;
            _draftOrderBuilder = draftOrderBuilder;
            _numericUdDefaultValueSeter = numericUdDefaultValueSeter;
            _productDataBuilder = productDataBuilder;
        }
        private void SendDraftOrderBtn_Click(object sender, EventArgs e)
        {
            if (CheckProductCount(selectedProduct.Count, (int)RequestedProductCounttxt.Value))
            {
                AddDraftOrderData(BuildDraftOrderData(orderer.UserId,orderer.UserName,selectedProduct.ProductId,selectedProduct.ProductName,selectedProduct.BrandId,selectedProduct.BrandName,selectedProduct.Amount, (int)RequestedProductCounttxt.Value));
                EditProductData(BuildProductData(selectedProduct.ProductName, selectedProduct.BrandId, selectedProduct.BrandName, selectedProduct.Amount,((selectedProduct.Count)-((int)RequestedProductCounttxt.Value)),selectedProduct.AddTime,selectedProduct.ProductId));
                MessageBox.Show("محصول به سبد خرید اضافه شد","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("محصول به تعدادی که شما میخواهید موجود نیست","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DraftOrderForm_Load(object sender, EventArgs e)
        {
            SetNumericUdDefaultValue(1, RequestedProductCounttxt);
            //    MessageBox.Show($"  {orderer.UserName}  {orderer.Password}  {orderer.UserId}  {orderer.Email}");
            //    MessageBox.Show($"  {selectedProduct.ProductName}  {selectedProduct.BrandName}  {selectedProduct.Amount}  {selectedProduct.Count}");
        }

        public bool CheckProductCount(int productCount, int requstedCount)
        {
            return _productCountChecker.CheckProductCount(productCount, requstedCount);
        }

        public void AddDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderSender.AddDraftOrderData(draftOrder);
        }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderBuilder.BuildDraftOrderData(userId,userName,productId,productName,brandId,brandName,productAmount,requestedCount,DraftOrderIdForEdit);
        }

        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            _numericUdDefaultValueSeter.SetNumericUdDefaultValue(defaultValue, numericUdCollection);
        }

        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime,ProductIdForEdit);
        }

    }
}
