using Microsoft.EntityFrameworkCore.Storage;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStore.DataLayer.Models;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer
{
    public partial class Form3 : Form
    {
        ProductsDataGeter pdg = new ProductsDataGeter();
        ProductSearcher ps = new ProductSearcher(new ProductNameSearcher(), new ProductBrandSearcher(), new ProductAmountSearcher(), new ProductDateSearcher(new PersianToMiladiDateConvertor()), new ProductAvailablitySearcher());
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AvailablityCombo.DisplayMember = "Name";
            AvailablityCombo.ValueMember = "Id";

        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            DGPruducts.DataSource = test1();
        }
        IEnumerable<ProductsTable> test1()
        {
            var data = pdg.GetProductsData();
            return ps.SearchInProducts(data, txtProductName.Text, (int)BrandIdtxt.Value, null, (int)MinAmounttxt.Value, (int)MaxAmountTxt.Value, maskedAsDatetxt.Text, maskedToDatetxt.Text);
        }
    }
}
