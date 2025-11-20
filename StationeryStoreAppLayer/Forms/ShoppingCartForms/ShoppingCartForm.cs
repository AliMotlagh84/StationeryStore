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

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms
{
    public partial class ShoppingCartForm : Form,IShoppingCartForm
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        UserTable userInfo { get; set;}
        UserTable IShoppingCartForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
