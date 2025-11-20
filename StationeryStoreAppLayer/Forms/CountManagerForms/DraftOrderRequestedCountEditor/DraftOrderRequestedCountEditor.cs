using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor
{
    public partial class DraftOrderRequestedCountEditor : Form,IDraftOrderRequestedCountEditor
    {
        DraftOrdersTable draftOrdersInfo {  get; set; }
        DraftOrdersTable IDraftOrderRequestedCountEditor.DraftOrderInfo { get => draftOrdersInfo; set => draftOrdersInfo = value; }

        public DraftOrderRequestedCountEditor()
        {
            InitializeComponent();
        }


        private void DraftOrderRequestedCountEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
