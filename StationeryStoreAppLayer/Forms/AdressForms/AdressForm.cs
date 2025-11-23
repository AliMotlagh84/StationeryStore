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

namespace StationeryStoreAppLayer.Forms.AdressForms
{
    public partial class AdressForm : Form, IAdressForm
    {
        public AdressForm()
        {
            InitializeComponent();
        }

        private UserTable userInfo { get; set; }
        UserTable IAdressForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void AdressForm_Load(object sender, EventArgs e)
        {

        }
    }
}
