using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Editors.ProductEditors;
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
    public partial class ProductAdderOrEditorForm : Form,
        IProductAdderOrEditorForm,
        IBrandsComboDataGeter,
        IComboBoxFiller

    {
        private ProductsTable productInfo;
        private bool editMode;
        ProductsTable IProductAdderOrEditorForm.ProductsInfo { get => productInfo; set => productInfo = value; }
        bool IProductAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        private IProductDataBuilder _productDataBuilder;
        private IProductDataAdder _productDataAdder;
        private IProductEditor _productEditor;
        private IBrandsComboDataGeter _brandsComboDataGeter;
        private IComboBoxFiller _comboBoxFiller;

        public ProductAdderOrEditorForm(
            IProductDataBuilder productDataBuilder,
            IProductDataAdder productDataAdder,
            IProductEditor productEditor,
            IBrandsComboDataGeter brandsComboDataGeter,
            IComboBoxFiller comboBoxFiller
            )
        {
            InitializeComponent();
            _productDataBuilder = productDataBuilder;
            _productDataAdder = productDataAdder;
            _productEditor = productEditor;
            _brandsComboDataGeter = brandsComboDataGeter;
            _comboBoxFiller = comboBoxFiller;
        }


        public void AddProductData(ProductsTable newPruduct)
        {
            _productDataAdder.AddProductData(newPruduct);
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit)
        {
            return _productDataBuilder.BuildProductData(newProductName, newBrandId, newBrandName, newProductAmount, newProductCount, addTime, ProductIdForEdit);
        }

        private void ProductAdderOrEditorForm_Load(object sender, EventArgs e)
        {
            FillCombo(BarndCombo,GetBrandsComboData(),"BrandName","BrandId");
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                EditProduct(BuildProductData(txtProductName.Text,(int)(BarndCombo.SelectedValue),(string)(BarndCombo.SelectedText),(long)(AmountTxt.Value),(int)(CountTxt.Value),productInfo.AddTime,productInfo.ProductId));
                MessageBox.Show("محصول با موفقیت به روزرسانی شد","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

            }
            DialogResult = DialogResult.OK;
        }

        public void EditProduct(ProductsTable product)
        {
            _productEditor.EditProduct(product);            
        }

        public List<BrandsTable> GetBrandsComboData()
        {
            return _brandsComboDataGeter.GetBrandsComboData();
        }

        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            _comboBoxFiller.FillCombo(comboBox,data,displayMember,ValueMember);
        }
    }
}
