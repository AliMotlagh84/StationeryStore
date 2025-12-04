using Microsoft.EntityFrameworkCore.Storage;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.Forms.ProductAdderOrEditorForms;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;

namespace StationeryStoreUILayer
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
