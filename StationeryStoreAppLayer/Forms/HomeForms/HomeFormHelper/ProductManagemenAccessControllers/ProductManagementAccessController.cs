using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers
{
    public class ProductManagementAccessController : IProductManagementAccessController
    {
        public void AllowProductsManagement(ToolStripButton productsButtonManagement, bool isAdmin)
        {
            if (!isAdmin)
            {
                productsButtonManagement.Visible = false;
            }
        }
    }
}
