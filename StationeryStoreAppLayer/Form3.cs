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
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers;

namespace StationeryStoreAppLayer
{
    public partial class Form3 : Form
    {

        IAdressesDataGeter adressData = new AdressesDataGeter();
        AdressSearcherByAdressId adressSearcherByAdressId = new AdressSearcherByAdressId();
        AdressSearcherByUserId AdressSearcherByUserId = new AdressSearcherByUserId();
        AdressSearcherByUserName AdressSearcherByUserName = new AdressSearcherByUserName();
        AdressSearcherByCity AdressSearcherByCity = new AdressSearcherByCity();
        AdressSearcherByStreet AdressSearcherByStreet = new AdressSearcherByStreet();
        AdressSearcherByAlley AdressSearcherByAlley = new AdressSearcherByAlley();
        AdressSearcherByHouseNumber AdressSearcherByHouseNumber = new AdressSearcherByHouseNumber();
        AdressSearcherByPostalCode AdressSearcherByPostalCode = new AdressSearcherByPostalCode();
        IAdressSearcher adressSearcher = new AdressSearcher(new AdressSearcherByAdressId(),
            new AdressSearcherByUserId(),
            new AdressSearcherByUserName(),
            new AdressSearcherByCity(),
            new AdressSearcherByStreet(),
            new AdressSearcherByAlley(),
            new AdressSearcherByHouseNumber(),
            new AdressSearcherByPostalCode()
            );


        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            BindGrid();


        }

        void BindGrid()
        {
            DGPruducts.AutoGenerateColumns = false;
            DGPruducts.DataSource = adressData.GetAdressesData();
        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            //DGPruducts.DataSource = DraftOrderSearcherByBrandName.SearchInDarftOrdersByBrandName(dataGeter.GetDraftOrderData(),BrandNameTxt.Text);

            DGPruducts.DataSource = adressSearcher.SearchInAdresses(adressData.GetAdressesData(),(int?)AdressIdtxt.Value,(int?)txtUserId.Value,txtUserName.Text,txtCity.Text,txtStreet.Text,txtAlley.Text,txtHouseNumber.Text,(long?)txtPostalCode.Value);
        }


        private void ProductGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
