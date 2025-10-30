using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.DraftOrderForms
{
    public partial class DraftOrderForm : Form ,IDraftOrderForm
    {
        private UserTable orderer;
        private ProductsTable selectedProduct;        
        ProductsTable IDraftOrderForm.SelectedProduct { get => selectedProduct; set => selectedProduct = value; }
        UserTable IDraftOrderForm.Orderer { get =>orderer; set =>orderer=value; }

        public DraftOrderForm()
        {
            InitializeComponent();
        }
        private void SendDraftOrderBtn_Click(object sender, EventArgs e)
        {

        }

        private void DraftOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
