using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors
{
    public interface IProductCountEditByDraftOrderDelete
    {
        void EditProductCountByDraftOrderDelete(int ProductId, int RequestedCount);
    }
}
