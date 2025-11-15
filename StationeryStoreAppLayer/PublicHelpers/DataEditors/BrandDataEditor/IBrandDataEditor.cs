using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataEditors.BrandDataEditor
{
    public interface IBrandDataEditor
    {
        void EditBrandData(BrandsTable brand);
    }
}
