using StationeryStoreAppLayer.Forms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ProductCountIncreaserForms
{
    public interface IProductCountIncreaserForm :
        IProductDataEditor,
        IProductCountIncreaser
    {
        ProductsTable ProductsInfo { get; set; }
    }
}
