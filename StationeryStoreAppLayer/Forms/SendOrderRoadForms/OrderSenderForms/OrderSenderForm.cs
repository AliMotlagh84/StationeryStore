using Microsoft.Identity.Client;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderSenderForms
{
    public partial class OrderSenderForm : Form,IOrderSenderForm
    {
        private UserTable userInfo;
        private long orderTotalAmount;
        UserTable IOrderSenderForm.UserInfo { get => userInfo; set => userInfo = value; }
        long IOrderSenderForm.OrderTotalAmount { get => orderTotalAmount; set => orderTotalAmount = value; }
             
        public OrderSenderForm()
        {
            InitializeComponent();
        }


        private void OrderSenderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
