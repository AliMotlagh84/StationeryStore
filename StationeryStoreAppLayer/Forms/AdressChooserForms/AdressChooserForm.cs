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

namespace StationeryStoreAppLayer.Forms.AdressChooserForms
{
    public partial class AdressChooserForm : Form,IAdressChooserForm
    {
        public AdressChooserForm()
        {
            InitializeComponent();
        }
        private UserTable userInfo;
        UserTable IAdressChooserForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void AdressChooserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
