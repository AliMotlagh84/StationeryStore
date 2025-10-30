using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.DraftOrderForms
{
    public interface IDraftOrderForm
    {
        public UserTable Orderer { get; set; }
        public ProductsTable SelectedProduct { get; set; }
    }
}
