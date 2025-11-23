using StationeryStoreAppLayer.PublicHelpers.DataAdders.AdressDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.AdressDataBuilders;
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
    public partial class AdressAdderOrEditorForm : Form, IAdressAdderOrEditorForm,
        IAdressDataBuilder,
        IAdressDataAdder
    {
        private AdressTable adressTable { get; set; }
        private bool editMode { get; set; }
        private UserTable userInfo { get; set; }
        AdressTable IAdressAdderOrEditorForm.AdressInfo { get => adressTable; set => adressTable = value; }
        bool IAdressAdderOrEditorForm.EditMode { get => editMode; set => editMode = value; }
        UserTable IAdressAdderOrEditorForm.UserInfo { get => userInfo; set => userInfo = value; }
        private IAdressDataBuilder _adressDataBuilder;
        private IAdressDataAdder _adressDataAdder;
        public AdressAdderOrEditorForm(
            IAdressDataBuilder adressDataBuilder,
            IAdressDataAdder adressDataAdder
            )
        {
            InitializeComponent();
            _adressDataBuilder = adressDataBuilder;
            _adressDataAdder = adressDataAdder;
        }

        private void AdressAdderOrEditorForm_Load(object sender, EventArgs e)
        {

        }

        public AdressTable BuildAdressData(int userId, string userName, string city, string street, string alley, string houseNumber, long postalCode, int? adressIdForEdit = null)
        {
            return _adressDataBuilder.BuildAdressData(userId, userName, city, street, alley, houseNumber, postalCode, adressIdForEdit);
        }

        public void AddAdressData(AdressTable adress)
        {
            _adressDataAdder.AddAdressData(adress);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            AddAdressData(BuildAdressData(userInfo.UserId, userInfo.UserName, txtCityName.Text, txtStreetName.Text, txtAlleyName.Text, txtHouseNumber.Text, (long)txtPostalCode.Value));
            MessageBox.Show("آدرس با موفقیت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
