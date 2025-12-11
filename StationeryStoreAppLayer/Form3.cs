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
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderId;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserName;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderDate;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByAmount;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByDeliveryState;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserId;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;

namespace StationeryStoreUILayer
{
    public partial class Form3 : Form
    {
        NumericUdDefaultValueSeter numericUdDefaultValueSeter = new NumericUdDefaultValueSeter();
        OrdersDataGeter ordersDataGeter = new OrdersDataGeter();
        OrderSearcherByOrderId orderSearcherByOrderId = new OrderSearcherByOrderId();
        OrderSearcherByUserName orderSearcherByUserName = new OrderSearcherByUserName();
        OrderSearcherByUserId orderSearcherByUserId = new OrderSearcherByUserId();
        OrderSearcherByOrderDate orderSearcherByOrderDate = new OrderSearcherByOrderDate(new PersianToMiladiDateConvertor());
        OrderSearcherByAmount orderSearcherByAmount = new OrderSearcherByAmount();
        OrderSearcherByDeliveryState orderSearcherByDeliveryState = new OrderSearcherByDeliveryState();
        IOrderSearcher orderSearcher = new OrderSearcher(new OrderSearcherByOrderId(), new OrderSearcherByUserId(), new OrderSearcherByUserName(), new OrderSearcherByOrderDate(new PersianToMiladiDateConvertor()), new OrderSearcherByAmount(), new OrderSearcherByDeliveryState());
        DgOrdersFiller DgOrdersFiller = new DgOrdersFiller();


        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            numericUdDefaultValueSeter.SetNumericUdDefaultValue(0, txtMinAmount, txtMaxAmount);
            BindGrid();
        }

        void BindGrid()
        {
            DgOrders.AutoGenerateColumns = false;
            DgOrdersFiller.FillDgOrders(DgOrders, ordersDataGeter.GetOrdersData());
        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            var FilteredOrders = orderSearcher.SearchInOrders(ordersDataGeter.GetOrdersData(),null,null,txtUserName.Text,null,null,(long)txtMinAmount.Value, (long)txtMaxAmount.Value);
            DgOrders.DataSource = FilteredOrders;
        }


        private void ProductGB_Enter(object sender, EventArgs e)
        {

        }

        private void ProductGB_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
