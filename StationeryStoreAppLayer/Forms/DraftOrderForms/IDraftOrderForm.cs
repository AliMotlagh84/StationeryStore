using StationeryStoreUILayer.Forms.DraftOrderForms.DraftOrderHelpers.ProductCountCheckers;
using StationeryStoreUILayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.DraftOrderForms
{
    public interface IDraftOrderForm:IDraftOrderDataBuilder,IDraftOrderDataAdder,IProductCountChecker
    {
        public UserTable Orderer { get; set; }
        public ProductsTable SelectedProduct { get; set; }
    }
}
