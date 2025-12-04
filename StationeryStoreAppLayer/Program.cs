using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.DebitCardPasswordValidators;
using StationaryStoreUtility.Validators.EmailValidator;
using StationaryStoreUtility.Validators.textValidators;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreUILayer.AppManagers.ApplicationContexts;
using StationeryStoreUILayer.AppManagers.AppRestartors;
using StationeryStoreUILayer.AppManagers.FormManagers;
using StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms;
using StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms.AdressAddreOrEditorHelpers.ValidateManagers;
using StationeryStoreUILayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm;
using StationeryStoreUILayer.Forms.AdressChooserForms;
using StationeryStoreUILayer.Forms.AdressForms;
using StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor;
using StationeryStoreUILayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreUILayer.Forms.DraftOrderForms;
using StationeryStoreUILayer.Forms.DraftOrderForms.DraftOrderHelpers.ProductCountCheckers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.GropBoxTextSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreUILayer.Forms.ManagerForms.BrandsManagerForm;
using StationeryStoreUILayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.ManagerForms.DraftOrdersManagerForms;
using StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.ManagerForms.UsersManagerForms;
using StationeryStoreUILayer.Forms.ProductAdderOrEditorForms;
using StationeryStoreUILayer.Forms.ProductCountIncreaserForms;
using StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_;
using StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.AdressChooserFormValidateHandlers;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderInfoShowerForms;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderInfoShowerForms.OrderShowInfoHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderRoadHelpers.OrderRoadHandlers;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderSenderForms;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaMakers;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaValidators;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.DiscountedAmountCalculator;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.PayerFormValidateHandlers;
using StationeryStoreUILayer.Forms.ShoppingCartForms;
using StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers;
using StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.SignUpForms;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.AdminSignUpValidateHandlers;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.UserSignUpValidateHandlers;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreUILayer.Forms.StoreManagerForms;
using StationeryStoreUILayer.Forms.UserEditorForms;
using StationeryStoreUILayer.LoginForms;
using StationeryStoreUILayer.PublicHelpers.ButtonTextSeters;
using StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreUILayer.PublicHelpers.ComboBoxValueSelectors;
using StationeryStoreUILayer.PublicHelpers.DataAdders.AdressDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataAdders.BrandDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreUILayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.AdressDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.BrandDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.BrandDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.ProductDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataEditors.AdressDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.BrandDataEditor;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreUILayer.PublicHelpers.Deleters.BrandDeleters;
using StationeryStoreUILayer.PublicHelpers.Deleters.DraftOrderDeleters;
using StationeryStoreUILayer.PublicHelpers.Deleters.ProductDeleters;
using StationeryStoreUILayer.PublicHelpers.Deleters.UserDeleters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.Editors.BrandEditors;
using StationeryStoreUILayer.PublicHelpers.Editors.DraftOrderEditors;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreUILayer.PublicHelpers.FormTextSeters;
using StationeryStoreUILayer.PublicHelpers.LabelSeters;
using StationeryStoreUILayer.PublicHelpers.NumericUdFillers;
using StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreUILayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreUILayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode;
using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher;
using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandSearcherByBrandName;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByAdminiSatate;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByEmail;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserId;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserName;
using StationeryStoreUILayer.PublicHelpers.TextBoxFillers;
using StationeryStoreUILayer.PublicHelpers.Validators.MaskedTextBoxValidators;
using System.Net.Http.Headers;

namespace StationeryStoreUILayer
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
            IAdminSignUpValidateHandler adminSignUpValidateHandler = new AdminSignUpValidateHandler(new NullOrWhiteSpaceValidator(), new EmailValidator(), new UniqeUserAndPasswordValidator(), new AdminiCodeValidator());
            IUserSignUpValidateHandler userSignUpValidateHandler = new UserSignUpValidateHandler(new NullOrWhiteSpaceValidator(), new EmailValidator(), new UniqeUserAndPasswordValidator());
            IAdressAdderOrEditorValidateManager adressAdderOrEditorValidateManager = new AdressAdderOrEditorValidateManager(new NullOrWhiteSpaceValidator());
            IAdressChooserFormValidateHandler adressChooserFormValidateHandler = new AdressChooserFormValidateHandler(new NullOrWhiteSpaceValidator());
            IPayerFormValidateHandler payerFormValidateHandler = new PayerFormValidateHandler(new MaskCompleteValidator(),new DebitCardPasswordLenghtValidator(),new CaptchaValidator());
            SignUpForm signUpForm = new SignUpForm(adminSignUpValidateHandler, userSignUpValidateHandler, new UserDataBuilder(), new UserDataAdder(), new AdminModeChanger(), new TextBoxRestartor());
            IProductSearcher productSearcher = new ProductSearcher(new ProductNameSearcher(), new ProductBrandSearcher(), new ProductAmountSearcher(), new ProductDateSearcher(new PersianToMiladiDateConvertor()), new ProductAvailablitySearcher());
            IDraftOrderSearcher draftOrderSearcher = new DraftOrderSearcher(new DraftOrderSearcherByDraftOrderId(), new DraftOrderSearcherByUserId(), new DraftOrderSearcherByUserName(), new DraftOrderSearcherByBrandId(), new DraftOrderSearcherByBrandName(), new DraftOrderSearcherByProductId(), new DraftOrderSearcherByProductName(), new DraftOrderSearcherByProductAmount(), new DraftOrderSearcherByTotalAmount(), new DraftOrderSearcherByRequestedCount());
            IBrandSearcher brandSearcher = new BrandSearcher(new BrandSearcherByBrandName(), new BrandSearcherByBrandId());
            IAdressSearcher adressSearcher = new AdressSearcher(new AdressSearcherByAdressId(),new AdressSearcherByUserId(),new AdressSearcherByUserName(),new AdressSearcherByCity(),new AdressSearcherByStreet(),new AdressSearcherByAlley(),new AdressSearcherByHouseNumber(),new AdressSearcherByPostalCode());
            IUserSeacher userSearcher = new UserSeacher(new UserSearcherByUserName(), new UserSearcherByUserId(), new UserSearcherByPassword(), new UserSearcherByEmail(), new UserSearcherByAdminiState());
            IProductDeleter productDeleter = new ProductDeleter(new ProductDataDeleter(), new DraftOrderDataGeter(), draftOrderSearcher, new DraftOrderDataDeleter());
            IUserDeleter userDeleter = new UserDeleter(new UserDataDeleter(), new DraftOrderDataGeter(), draftOrderSearcher, new DraftOrderDataDeleter());
            IBrandDeleter brandDeleter = new BrandDeleter(new BrandDataDeleter(), new ProductsDataGeter(), productSearcher, productDeleter, new DraftOrderDataGeter(), draftOrderSearcher, new DraftOrderDataDeleter());
            IProductEditor productEditor = new ProductEditor(new ProductDataEditor(), new DraftOrderDataGeter(), draftOrderSearcher, new DraftOrderDataBulider(), new DraftOrderDataEditor());
            IProductCountEditorByDraftOrderCountEdit productCountEditorByDraftOrderCountEdit = new ProductCountEditorByDraftOrderCountEdit(new ProductDataGeterById(), new ProductDataBuilder(), productEditor);
            IProductCountEditByDraftOrderDelete productCountEditByDraftOrderDelete = new ProductCountEditByDraftOrderDelete(new ProductDataGeterById(), new ProductDataBuilder(), productEditor);
            IBrandEditor brandEditor = new BrandEditor(new BrandDataEditor(), new ProductsDataGeter(), productSearcher, new ProductDataBuilder(), productEditor, new DraftOrderDataGeter(), draftOrderSearcher, new DraftOrderDataBulider(), new DraftOrderDataEditor());
            IDraftOrderEditor draftOrderEditor = new DraftOrderEditor(productCountEditorByDraftOrderCountEdit, new DraftOrderDataEditor());
            IDraftOrderDeleter draftOrderDeleter = new DraftOrderDeleter(new DraftOrderDataDeleter(), new DraftOrderDataGeterById(), productCountEditByDraftOrderDelete);
            ProductAdderOrEditorForm productAdderOrEditorForm = new ProductAdderOrEditorForm(new ProductDataBuilder(), new ProductDataAdder(), productEditor, new BrandsComboDataGeter(), new ComboBoxFiller(), new ComboBoxValueSelector(), new FormTextSeter(), new ButtonTextSeter(), new NumericUdFiller(), new TextBoxFiller(), new NumericUdRestartor(), new ComboRestartor(), new TextBoxRestartor(), new BrandDataGeter(), new NullOrWhiteSpaceValidator(), new NumericUdDefaultValueSeter());
            BrandAdderOrEditorForm brandAdderOrEditorForm = new BrandAdderOrEditorForm(new BrandDataBuilder(), brandEditor, new BrandDataAdder(), new NullOrWhiteSpaceValidator(), new TextBoxFiller(), new ButtonTextSeter(), new FormTextSeter(), new TextBoxRestartor());
            ProductCountIncreaserForm productCountIncreaserForm = new ProductCountIncreaserForm(new ProductDataEditor(), new ProductCountIncreaser(), new NumericUdDefaultValueSeter());
            ProductsManagerForm productsManagerForm = new ProductsManagerForm(new ProductsDataGeter(), new ProductDataBuilder(), new BrandDataGeter(), new BrandsComboDataGeter(), productSearcher, new DgFiller(), new ComboBoxFiller(), new BoolComboFiller(), new NumericUdDefaultValueSeter(), new TextBoxRestartor(), new NumericUdRestartor(), new ComboRestartor(), new MaskedTextBoxRestartor(), new ProductAdderOrEditorFormOpener<ProductAdderOrEditorForm>(productAdderOrEditorForm), new ProductCountIncreaserFormOpener<ProductCountIncreaserForm>(productCountIncreaserForm), productDeleter);
            BrandsManagerForm brandsManagerForm = new BrandsManagerForm(new BrandDataGeter(), new BrandDataBuilder(), brandDeleter, brandSearcher, new DgFiller(), new TextBoxRestartor(), new BrandAdderOrEditorFormOpener<BrandAdderOrEditorForm>(brandAdderOrEditorForm));
            DraftOrdersManagerForm draftOrdersManagerForm = new DraftOrdersManagerForm(new DraftOrderDataGeter(), new DraftOrderDataBulider(), new DraftOrderDataDeleter(), draftOrderSearcher, new BrandDataGeter(), new BrandsComboDataGeter(), new NumericUdDefaultValueSeter(), new DgFiller(), new ComboBoxFiller(), new ComboRestartor(), new NumericUdRestartor(), new TextBoxRestartor());
            UsersManagerForm usersManagerForm = new UsersManagerForm(new UsersDataGeter(), userSearcher, new UserDataBuilder(), userDeleter, new TextBoxRestartor(), new DgFiller());
            StoreManagerForm storeManagerForm = new StoreManagerForm(new ProductsManagerFormOpener<ProductsManagerForm>(productsManagerForm), new BrandsManagerFormOpener<BrandsManagerForm>(brandsManagerForm), new DraftOrdersManagerFormOpener<DraftOrdersManagerForm>(draftOrdersManagerForm), new UserManagerFormOpener<UsersManagerForm>(usersManagerForm));
            DraftOrderRequestedCountEditor draftOrderRequestedCountEditor = new DraftOrderRequestedCountEditor(new DraftOrderDataBulider(), draftOrderEditor, new NumericUdDefaultValueSeter());
            OrderSenderForm orderSenderForm = new OrderSenderForm();
            PayerForm payerForm = new PayerForm(new CaptchaMaker(),new LabelFillerByText(),new DraftOrderTotalAmountsSumByUserIdGeter(),new DiscountedAmountCaculator(),new NumericUdDefaultValueSeter(),payerFormValidateHandler,new OrderSenderFormOpener<OrderSenderForm>(orderSenderForm));
            OrderInfoShowerForm orderInfoShowerForm = new OrderInfoShowerForm(new DraftOrderDataGeter(),draftOrderSearcher,new TextBoxFiller(),new DgFiller(),new OrderRoadHandler(),new PayerFormOpener<PayerForm>(payerForm));
            AdressAdderOrEditorForm adressAdderOrEditorForm = new AdressAdderOrEditorForm(new AdressDataBuilder(), new AdressDataAdder(),new AdressDataEditor(),new FormTextSeter(),new ButtonTextSeter(),new TextBoxFiller(),new NumericUdFiller(),new NumericUdDefaultValueSeter(),new TextBoxRestartor(),new NumericUdRestartor(),adressAdderOrEditorValidateManager);
            AdressChooserForm adressChooserForm = new AdressChooserForm(new AdressesDataGeter(), adressSearcher, new TextBoxFiller(),new TextBoxRestartor(), new DgFiller(), new OrderInfoShowerFormOpener<OrderInfoShowerForm>(orderInfoShowerForm), new OrderRoadHandler(),adressChooserFormValidateHandler);
            IAdressChooserFormOpeningHandler adressChooserFormOpeningHandler = new AdressChooserFormOpeningHandler(new AdressAdderOrEditorFormOpener<AdressAdderOrEditorForm>(adressAdderOrEditorForm), new AdressChooserFormOpener<AdressChooserForm>(adressChooserForm), new AdressesDataGeter(),adressSearcher);
            AdressForm adressForm = new AdressForm(new AdressDataBuilder(), new AdressesDataGeter(), adressSearcher, new AdressDataDeleter(), new DgFiller(), new AdressAdderOrEditorFormOpener<AdressAdderOrEditorForm>(adressAdderOrEditorForm));           
            ShoppingCartForm shoppingCartForm = new ShoppingCartForm(new DraftOrderDataGeter(), draftOrderSearcher, draftOrderDeleter, new DraftOrderDataBulider(), new DgFiller(), new DraftOrderRequestedCountEditorFormOpener<DraftOrderRequestedCountEditor>(draftOrderRequestedCountEditor), new AdressFormOpener<AdressForm>(adressForm),adressChooserFormOpeningHandler);
          
            Form1 homeForm = new Form1(new ProductManagementAccessController(), new TimeLabelSeter(), new DateLabelSeter(new MiladiToPersianDateConvertor()), new GroupBoxTextSeter(), new IntroducingLabelSeter(), new AdminLabelSeter(), new FormCloser(), new FormManager(), new DgFiller(), new DgOrdersFillerByDeliveryState(new MiladiToPersianDateConvertor()), new ComboBoxFiller(), new BoolComboFiller(), new ProductsDataGeter(), new OrdersDataGeter(), new BrandDataGeter(), new BrandsComboDataGeter(), new NewProductsDataGeter(), new SingleProductDataGeter(), new NumericUdDefaultValueSeter(), productSearcher, new DraftOrderFormOpener<DraftOrderForm>(new DraftOrderForm(new ProductCountChecker(), new ProductDataEditor(), new ProductDataBuilder(), new DraftOrderDataBulider(), new DraftOrderDataAdder(), new NumericUdDefaultValueSeter())), new UserEditorFormOpener<UserEditorForm>(new UserEditorForm(new TextBoxFiller(), new UserDataBuilder(), new UserDataEditor(), new NullOrWhiteSpaceValidator(), new EmailValidator(), new AppRestartor())), new AppRestartor(), userDeleter, new StoreMangerFormOpener<StoreManagerForm>(storeManagerForm), new ShoppingCartFormOpener<ShoppingCartForm>(shoppingCartForm));
            Application.Run(new StationeryApplicationContext(new LoginUserValidator(), new HomeFormOpener<Form1>(homeForm), new SingleUserDataGeterByNameAndPassword(), new NullOrWhiteSpaceValidator(), new SignUpFormOpener<SignUpForm>(signUpForm), new TextBoxRestartor(), new FormManager()));


        }
    }
}