using StationeryStoreAppLayer.Forms.DraftOrderForms.DraftOrderHelpers.ProductCountCheckers;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.DraftOrderForms
{
    public interface IDraftOrderForm:IDraftOrderDataBuilder,IDraftOrderDataAdder,IProductCountChecker
    {
        public UserTable Orderer { get; set; }
        public ProductsTable SelectedProduct { get; set; }
    }
}
