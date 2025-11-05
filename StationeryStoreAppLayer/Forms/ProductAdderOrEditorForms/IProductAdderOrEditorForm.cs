using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms
{
    public interface IProductAdderOrEditorForm:
        IProductDataBuilder,
        IProductDataAdder,
        IProductDataEditor
    {
        ProductsTable ProductsInfo { get; set; }
        bool EditMode { get; set; }
       
    }
}
