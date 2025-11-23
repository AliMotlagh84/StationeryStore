using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.EmailValidator;
using StationaryStoreUtility.Validators.textValidators;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.AppManagers.ApplicationContexts;
using StationeryStoreAppLayer.AppManagers.AppRestartors;
using StationeryStoreAppLayer.AppManagers.FormManagers;
using StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms;
using StationeryStoreAppLayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm;
using StationeryStoreAppLayer.Forms.AdressForms;
using StationeryStoreAppLayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor;
using StationeryStoreAppLayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreAppLayer.Forms.DraftOrderForms;
using StationeryStoreAppLayer.Forms.DraftOrderForms.DraftOrderHelpers.ProductCountCheckers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.GropBoxTextSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm;
using StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.ManagerForms.DraftOrdersManagerForms;
using StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.ManagerForms.UsersManagerForms;
using StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms;
using StationeryStoreAppLayer.Forms.ProductCountIncreaserForms;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners;
using StationeryStoreAppLayer.Forms.ShoppingCartForms;
using StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.SignUpForms;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.AdminSignUpValidateHandlers;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.UserSignUpValidateHandlers;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreAppLayer.Forms.StoreManagerForms;
using StationeryStoreAppLayer.Forms.UserEditorForms;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxValueSelectors;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.AdressDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.BrandDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.UserDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.AdressDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.BrandDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.BrandDataDeleter;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.ProductDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.BrandDataEditor;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.BrandDeleters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.DraftOrderDeleters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.ProductDeleters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.UserDeleters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.Editors.BrandEditors;
using StationeryStoreAppLayer.PublicHelpers.Editors.DraftOrderEditors;
using StationeryStoreAppLayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreAppLayer.PublicHelpers.FormTextSeters;
using StationeryStoreAppLayer.PublicHelpers.NumericUdFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreAppLayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher;
using StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher.BrandSearcherByBrandName;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByAdminiSatate;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByEmail;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserId;
using StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserName;
using StationeryStoreAppLayer.PublicHelpers.TextBoxFillers;
using System.Net.Http.Headers;

namespace StationeryStoreAppLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form3());
            IAdminSignUpValidateHandler adminSignUpValidateHandler = new AdminSignUpValidateHandler(new NullOrWhiteSpaceValidator(),new EmailValidator(), new UniqeUserAndPasswordValidator(),new AdminiCodeValidator());
            IUserSignUpValidateHandler userSignUpValidateHandler = new UserSignUpValidateHandler(new NullOrWhiteSpaceValidator(),new EmailValidator(), new UniqeUserAndPasswordValidator());
            SignUpForm signUpForm = new SignUpForm(adminSignUpValidateHandler,userSignUpValidateHandler,new UserDataBuilder(),new UserDataAdder(),new AdminModeChanger(),new TextBoxRestartor());         
            IProductSearcher productSearcher = new ProductSearcher(new ProductNameSearcher(), new ProductBrandSearcher(), new ProductAmountSearcher(), new ProductDateSearcher(new PersianToMiladiDateConvertor()), new ProductAvailablitySearcher());
            IDraftOrderSearcher draftOrderSearcher = new DraftOrderSearcher(new DraftOrderSearcherByDraftOrderId(),new DraftOrderSearcherByUserId(),new DraftOrderSearcherByUserName(),new DraftOrderSearcherByBrandId(),new DraftOrderSearcherByBrandName(),new DraftOrderSearcherByProductId(),new DraftOrderSearcherByProductName(),new DraftOrderSearcherByProductAmount(),new DraftOrderSearcherByTotalAmount(),new DraftOrderSearcherByRequestedCount());
            IBrandSearcher brandSearcher = new BrandSearcher(new BrandSearcherByBrandName(),new BrandSearcherByBrandId());
            IUserSeacher userSearcher = new UserSeacher(new UserSearcherByUserName(),new UserSearcherByUserId(),new UserSearcherByPassword(),new UserSearcherByEmail(),new UserSearcherByAdminiState());
            IProductDeleter productDeleter = new ProductDeleter(new ProductDataDeleter(),new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataDeleter());
            IUserDeleter userDeleter = new UserDeleter(new UserDataDeleter(),new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataDeleter());
            IBrandDeleter brandDeleter = new BrandDeleter(new BrandDataDeleter(),new ProductsDataGeter(),productSearcher,productDeleter,new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataDeleter());
            IProductEditor productEditor = new ProductEditor(new ProductDataEditor(),new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataBulider(),new DraftOrderDataEditor());
            IProductCountEditorByDraftOrderCountEdit productCountEditorByDraftOrderCountEdit = new ProductCountEditorByDraftOrderCountEdit(new ProductDataGeterById(),new ProductDataBuilder(),productEditor);
            IProductCountEditByDraftOrderDelete productCountEditByDraftOrderDelete = new ProductCountEditByDraftOrderDelete(new ProductDataGeterById(),new ProductDataBuilder(),productEditor);
            IBrandEditor brandEditor = new BrandEditor(new BrandDataEditor(),new ProductsDataGeter(),productSearcher,new ProductDataBuilder(),productEditor,new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataBulider(),new DraftOrderDataEditor());
            IDraftOrderEditor draftOrderEditor = new DraftOrderEditor(productCountEditorByDraftOrderCountEdit,new DraftOrderDataEditor());
            IDraftOrderDeleter draftOrderDeleter = new DraftOrderDeleter(new DraftOrderDataDeleter(),new DraftOrderDataGeterById(), productCountEditByDraftOrderDelete);
            ProductAdderOrEditorForm productAdderOrEditorForm = new ProductAdderOrEditorForm(new ProductDataBuilder(),new ProductDataAdder(),productEditor,new BrandsComboDataGeter(),new ComboBoxFiller(),new ComboBoxValueSelector(),new FormTextSeter(),new ButtonTextSeter(),new NumericUdFiller(),new TextBoxFiller(),new NumericUdRestartor(),new ComboRestartor(),new TextBoxRestartor(),new BrandDataGeter(),new NullOrWhiteSpaceValidator(),new NumericUdDefaultValueSeter());
            BrandAdderOrEditorForm brandAdderOrEditorForm = new BrandAdderOrEditorForm(new BrandDataBuilder(),brandEditor,new BrandDataAdder(),new NullOrWhiteSpaceValidator(),new TextBoxFiller(),new ButtonTextSeter(),new FormTextSeter(),new TextBoxRestartor());
            ProductCountIncreaserForm productCountIncreaserForm = new ProductCountIncreaserForm(new ProductDataEditor(),new ProductCountIncreaser(),new NumericUdDefaultValueSeter());
            ProductsManagerForm productsManagerForm = new ProductsManagerForm(new ProductsDataGeter(),new ProductDataBuilder(),new BrandDataGeter(),new BrandsComboDataGeter(),productSearcher,new DgFiller(),new ComboBoxFiller(),new BoolComboFiller(),new NumericUdDefaultValueSeter(),new TextBoxRestartor(),new NumericUdRestartor(),new ComboRestartor(),new MaskedTextBoxRestartor(),new ProductAdderOrEditorFormOpener<ProductAdderOrEditorForm>(productAdderOrEditorForm),new ProductCountIncreaserFormOpener<ProductCountIncreaserForm>(productCountIncreaserForm),productDeleter);
            BrandsManagerForm brandsManagerForm = new BrandsManagerForm(new BrandDataGeter(),new BrandDataBuilder(),brandDeleter,brandSearcher,new DgFiller(),new TextBoxRestartor(),new BrandAdderOrEditorFormOpener<BrandAdderOrEditorForm>(brandAdderOrEditorForm));
            DraftOrdersManagerForm draftOrdersManagerForm = new DraftOrdersManagerForm(new DraftOrderDataGeter(),new DraftOrderDataBulider(),new DraftOrderDataDeleter(),draftOrderSearcher,new BrandDataGeter(),new BrandsComboDataGeter(),new NumericUdDefaultValueSeter(),new DgFiller(),new ComboBoxFiller(),new ComboRestartor(),new NumericUdRestartor(),new TextBoxRestartor());
            UsersManagerForm usersManagerForm = new UsersManagerForm(new UsersDataGeter(),userSearcher,new UserDataBuilder(),userDeleter,new TextBoxRestartor(),new DgFiller());            
            StoreManagerForm storeManagerForm = new StoreManagerForm(new ProductsManagerFormOpener<ProductsManagerForm>(productsManagerForm),new BrandsManagerFormOpener<BrandsManagerForm>(brandsManagerForm),new DraftOrdersManagerFormOpener<DraftOrdersManagerForm>(draftOrdersManagerForm),new UserManagerFormOpener<UsersManagerForm>(usersManagerForm));
            DraftOrderRequestedCountEditor draftOrderRequestedCountEditor = new DraftOrderRequestedCountEditor(new DraftOrderDataBulider(),draftOrderEditor,new NumericUdDefaultValueSeter());
            AdressAdderOrEditorForm adressAdderOrEditorForm = new AdressAdderOrEditorForm(new AdressDataBuilder(),new AdressDataAdder());
            AdressForm adressForm = new AdressForm(new AdressDataBuilder(),new AdressesDataGeter(),new DgFiller(),new AdressAdderOrEditorFormOpener<AdressAdderOrEditorForm>(adressAdderOrEditorForm));
            ShoppingCartForm shoppingCartForm = new ShoppingCartForm(new DraftOrderDataGeter(), draftOrderSearcher,draftOrderDeleter,new DraftOrderDataBulider(),new DgFiller(),new DraftOrderRequestedCountEditorFormOpener<DraftOrderRequestedCountEditor>(draftOrderRequestedCountEditor),new AdressFormOpener<AdressForm>(adressForm));
            Form1 homeForm = new Form1(new ProductManagementAccessController(), new TimeLabelSeter(), new DateLabelSeter(new MiladiToPersianDateConvertor()),new GroupBoxTextSeter(), new IntroducingLabelSeter(), new AdminLabelSeter(), new FormCloser(), new FormManager(), new DgFiller(), new DgOrdersFillerByDeliveryState(new MiladiToPersianDateConvertor()), new ComboBoxFiller(),new BoolComboFiller(), new ProductsDataGeter(), new OrdersDataGeter(),new BrandDataGeter(), new BrandsComboDataGeter(), new NewProductsDataGeter(),new SingleProductDataGeter(), new NumericUdDefaultValueSeter(), productSearcher,new DraftOrderFormOpener<DraftOrderForm>(new DraftOrderForm(new ProductCountChecker(),new ProductDataEditor(),new ProductDataBuilder(),new DraftOrderDataBulider(),new DraftOrderDataAdder(),new NumericUdDefaultValueSeter())),new UserEditorFormOpener<UserEditorForm>(new UserEditorForm(new TextBoxFiller(),new UserDataBuilder(),new UserDataEditor(),new NullOrWhiteSpaceValidator(),new EmailValidator(),new AppRestartor())),new AppRestartor(), userDeleter, new StoreMangerFormOpener<StoreManagerForm>(storeManagerForm),new ShoppingCartFormOpener<ShoppingCartForm>(shoppingCartForm));
            Application.Run(new StationeryApplicationContext(new LoginUserValidator(), new HomeFormOpener<Form1>(homeForm), new SingleUserDataGeterByNameAndPassword(), new NullOrWhiteSpaceValidator(), new SignUpFormOpener<SignUpForm>(signUpForm), new TextBoxRestartor(), new FormManager()));
            

        }
    }
}