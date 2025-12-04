using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.Deleters.ProductDeleters;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors
{
    public class ProductCountEditByDraftOrderDelete : IProductCountEditByDraftOrderDelete,
        IProductDataGeterById,
        IProductDataBuilder,
        IProductEditor
    {
        private IProductDataGeterById _productDataGeterById;
        private IProductDataBuilder _productDataBuilder;
        private IProductEditor _productEditor;

        public ProductCountEditByDraftOrderDelete(
            IProductDataGeterById productDataGeterById,
            IProductDataBuilder productDataBuilder,
            IProductEditor productEditor
            )
        {
            _productDataGeterById = productDataGeterById;
            _productDataBuilder = productDataBuilder;
            _productEditor = productEditor;
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName,newBrandId,newBrandName,newProductAmount,newProductCount,addTime,ProductIdForEdit);
        }

        public void EditProduct(ProductsTable product)
        {
            _productEditor.EditProduct(product);
        }

        public void EditProductCountByDraftOrderDelete(int ProductId, int RequestedCount)
        {
            var product = GetProductDataById(ProductId);
            product.Count += RequestedCount;
            EditProduct(product);
        }

        public ProductsTable GetProductDataById(object ProductId)
        {
           return _productDataGeterById.GetProductDataById(ProductId);
        }
    }
}
