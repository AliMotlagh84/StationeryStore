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

namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms
{
    public partial class AdressAdderOrEditorForm : Form, IAdressAdderOrEditorForm
    {
        private AdressTable adressTable { get; set; }
        AdressTable IAdressAdderOrEditorForm.AdressInfo { get => adressTable; set => adressTable = value; }

        public AdressAdderOrEditorForm()
        {
            InitializeComponent();
        }

        private void AdressAdderOrEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
