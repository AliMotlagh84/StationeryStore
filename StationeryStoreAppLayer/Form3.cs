using Microsoft.EntityFrameworkCore.Storage;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreDataLayer.Models;
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
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms;

namespace StationeryStoreAppLayer
{
    public partial class Form3 : Form
    {
        ProductsDataGeter pdg = new ProductsDataGeter();
        ProductSearcher ps = new ProductSearcher(new ProductNameSearcher(), new ProductBrandSearcher(), new ProductAmountSearcher(), new ProductDateSearcher(new PersianToMiladiDateConvertor()), new ProductAvailablitySearcher());
        NumericUdDefaultValueSeter numericUdDefaultValueSeter = new NumericUdDefaultValueSeter();
        DraftOrderDataGeter dataGeter = new DraftOrderDataGeter();
        DraftOrderSearcherByUserId draftOrderSearcherByUserId = new DraftOrderSearcherByUserId();
        DraftOrderSearcherByUserName draftOrderSearcherByUserName = new DraftOrderSearcherByUserName();
        DraftOrderSearcherByBrandId draftOrderSearcherByBrandId = new DraftOrderSearcherByBrandId();
        DraftOrderSearcherByBrandName draftOrderSearcherByBrandName = new DraftOrderSearcherByBrandName();
        DraftOrderSearcherByProductAmount draftOrderSearcherByProductAmount = new DraftOrderSearcherByProductAmount();
        DraftOrderSearcherByTotalAmount draftOrderSearcherByTotalAmount = new DraftOrderSearcherByTotalAmount();
        DraftOrderSearcherByProductId draftOrderSearcherByProductId = new DraftOrderSearcherByProductId();
        DraftOrderSearcherByProductName draftOrderSearcherByProductName = new DraftOrderSearcherByProductName();
        DraftOrderSearcherByRequestedCount draftOrderSearcherByRequestedCount = new DraftOrderSearcherByRequestedCount();
        DraftOrderSearcherByDraftOrderId draftOrderSearcherByDraftOrderId = new DraftOrderSearcherByDraftOrderId();
        IDraftOrderSearcher draftOrderSearcher = new DraftOrderSearcher(new DraftOrderSearcherByDraftOrderId(),new DraftOrderSearcherByUserId(),new DraftOrderSearcherByUserName(),new DraftOrderSearcherByBrandId(),new DraftOrderSearcherByBrandName(),new DraftOrderSearcherByProductId(),new DraftOrderSearcherByProductName(),new DraftOrderSearcherByProductAmount(),new DraftOrderSearcherByTotalAmount(),new DraftOrderSearcherByRequestedCount());




        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            BindGrid();
            //    List<Brand> brands = new List<Brand>()
            //{
            //    new Brand(){BrandId = 0 , BrandName = "همه" },
            //    new Brand(){BrandId = 1 , BrandName = "FabelCastle" },
            //    new Brand(){BrandId = 2 , BrandName = "Bike" },
            //    new Brand(){BrandId = 3 , BrandName = "دوکا" },

            //};
            //    AvailablityCombo.DisplayMember = "BrandName";
            //    AvailablityCombo.ValueMember = "BrandId";
            //    AvailablityCombo.DataSource = brands;

            //    //    brandData.Add(0,"همه");
            //    //    brandData.Add(brands[0].BrandId, brands[0].BrandName);
            //    //    brandData.Add(brands[1].BrandId, brands[1].BrandName);
            //    //    brandData.Add(brands[2].BrandId, brands[2].BrandName);
            //    numericUdDefaultValueSeter.SetNumericUdDefaultValue(0, MinAmounttxt, MaxAmountTxt);



        }

        void BindGrid()
        {
            DGPruducts.AutoGenerateColumns = false;
            DGPruducts.DataSource = dataGeter.GetDraftOrderData();
        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            //DGPruducts.DataSource = DraftOrderSearcherByBrandName.SearchInDarftOrdersByBrandName(dataGeter.GetDraftOrderData(),BrandNameTxt.Text);

            DGPruducts.DataSource = draftOrderSearcher.SearchInDraftOrders(dataGeter.GetDraftOrderData(),(int?)DraftOrderIdTxt.Value,null,null,(int?)ProductIdTxt.Value,txtProductName.Text,(int?)BrandIdtxt.Value,BrandNameTxt.Text,(int?)MinRequestedCountTxt.Value,(int?)MaxCountTxt.Value,(long?)MinAmounttxt.Value, (long?)MaxAmountTxt.Value, (long?)MinTotalAmountTxt.Value, (long?)MaxTotalAmountTxt.Value);
        }


        private void ProductGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
