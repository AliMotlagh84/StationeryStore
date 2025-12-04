using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers
{
    public interface IProductManagementAccessController
    {
        void AllowProductsManagement(ToolStripButton productsButtonManagement, bool isAdmin);                                                                                                            
    }
}
