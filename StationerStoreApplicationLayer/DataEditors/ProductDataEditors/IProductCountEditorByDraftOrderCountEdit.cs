using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors
{
    public interface IProductCountEditorByDraftOrderCountEdit
    {
        void EditProductCountByDraftOrderCount(int ProductId, int newRequestedCount, int oldRequestedCount);
    }
}
