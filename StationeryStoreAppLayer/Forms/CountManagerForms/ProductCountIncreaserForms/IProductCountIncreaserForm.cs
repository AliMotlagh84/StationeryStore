using StationeryStoreUILayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.CountManagerForms.ProductCountIncreaserForms
{
    public interface IProductCountIncreaserForm :
        IProductDataEditor,
        IProductCountIncreaser
    {
        ProductsTable ProductsInfo { get; set; }
    }
}
