using StationeryStoreUILayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdderOrEditorForms.ProductAdderOrEditorForms
{
    public interface IProductAdderOrEditorForm:
        IProductDataBuilder,
        IProductDataAdder,
        IProductEditor

    {
        ProductsTable ProductsInfo { get; set; }
        bool EditMode { get; set; }
       
    }
}
