using StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.OrderInfoForms
{
    public partial class OrderInfoForm : Form, IOrderInfoForm,
        IDgFiller,
        IJsonToDrfatOrderRestorer
    {
        private IDgFiller _dgFiller;
        private IJsonToDrfatOrderRestorer _jsonToDrfatOrderRestorer;
        public OrderInfoForm(IDgFiller dgFiller, IJsonToDrfatOrderRestorer jsonToDrfatOrderRestorer)
        {
            InitializeComponent();
            _dgFiller = dgFiller;
            _jsonToDrfatOrderRestorer = jsonToDrfatOrderRestorer;
        }

        OrdersTable order;
        OrdersTable IOrderInfoForm.Order { get => order; set => order = value; }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            FillDg(DraftOrdersDG,RestorJsonToDraftOrder(order.OrderInfo));
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<DraftOrdersTable> RestorJsonToDraftOrder(string JsonString)
        {
            return _jsonToDrfatOrderRestorer.RestorJsonToDraftOrder(JsonString);
        }
    }
}
