using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors
{
    public interface IProductEditor
    {
        void EditProduct(ProductsTable product);
    }
}
