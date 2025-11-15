using Microsoft.EntityFrameworkCore;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataEditors.BrandDataEditor
{
    public class BrandDataEditor : IBrandDataEditor
    {
        public void EditBrandData(BrandsTable brand)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Update(brand);
                db.Save();
            }
        }
    }
}
