using Microsoft.EntityFrameworkCore.Storage;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStore.DataLayer.Models;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
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
        NumericUdDefaultValueSeter numericUdDefaultValueSeter = new NumericUdDefaultValueSeter();
        //List<int, string> brandData = new Dictionary<int, string>();




        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId = 0 , BrandName = "همه" },
            new Brand(){BrandId = 1 , BrandName = "FabelCastle" },
            new Brand(){BrandId = 2 , BrandName = "Bike" },
            new Brand(){BrandId = 3 , BrandName = "دوکا" },

        };
            AvailablityCombo.DisplayMember = "BrandName";
            AvailablityCombo.ValueMember = "BrandId";
            AvailablityCombo.DataSource = brands;

            //    brandData.Add(0,"همه");
            //    brandData.Add(brands[0].BrandId, brands[0].BrandName);
            //    brandData.Add(brands[1].BrandId, brands[1].BrandName);
            //    brandData.Add(brands[2].BrandId, brands[2].BrandName);
            numericUdDefaultValueSeter.SetNumericUdDefaultValue(0, MinAmounttxt, MaxAmountTxt);



        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            DGPruducts.DataSource = test1();
        }
        IEnumerable<ProductsTable> test1()
        {
            var data = pdg.GetProductsData();
            return ps.SearchInProducts(data, txtProductName.Text,(int?)AvailablityCombo.SelectedValue, null, (int?)MinAmounttxt.Value, (int?)MaxAmountTxt.Value, maskedAsDatetxt.Text, maskedToDatetxt.Text);
        }
    }

    class Brand
    {
        public int BrandId {  get; set; }
        public string BrandName { get; set; }
    }
}
