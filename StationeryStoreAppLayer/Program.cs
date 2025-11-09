using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.textValidators;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.AppManagers.ApplicationContexts;
using StationeryStoreAppLayer.AppManagers.AppRestartors;
using StationeryStoreAppLayer.AppManagers.FormManagers;
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
using StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms;
using StationeryStoreAppLayer.Forms.ProductCountIncreaserForms;
using StationeryStoreAppLayer.Forms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners;
using StationeryStoreAppLayer.Forms.SignUpForms;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreAppLayer.Forms.UserEditorForms;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.ProductDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.ProductDeleters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.NumericUpDownDefaultValueSeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor;
using StationeryStoreAppLayer.PublicHelpers.Restartors.MaskedTextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
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
            SignUpForm signUpForm = new SignUpForm(new NullOrWhiteSpaceValidator(), new UniqeUserAndPasswordValidator(), new AdminModeChanger(), new AdminiCodeValidator(), new UserBuilder(), new TextBoxRestartor());
            ProductSearcher productSearcher = new ProductSearcher(new ProductNameSearcher(), new ProductBrandSearcher(), new ProductAmountSearcher(), new ProductDateSearcher(new PersianToMiladiDateConvertor()), new ProductAvailablitySearcher());
            DraftOrderSearcher draftOrderSearcher = new DraftOrderSearcher(new DraftOrderSearcherByDraftOrderId(),new DraftOrderSearcherByUserId(),new DraftOrderSearcherByUserName(),new DraftOrderSearcherByBrandId(),new DraftOrderSearcherByBrandName(),new DraftOrderSearcherByProductId(),new DraftOrderSearcherByProductName(),new DraftOrderSearcherByProductAmount(),new DraftOrderSearcherByTotalAmount(),new DraftOrderSearcherByRequestedCount());
            ProductDeleter productDeleter = new ProductDeleter(new ProductDataDeleter(),new DraftOrderDataGeter(),draftOrderSearcher,new DraftOrderDataDeleter());
            ProductAdderOrEditorForm productAdderOrEditorForm = new ProductAdderOrEditorForm(new ProductDataBuilder(),new ProductDataAdder(),new ProductDataEditor());
            ProductCountIncreaserForm productCountIncreaserForm = new ProductCountIncreaserForm(new ProductDataEditor(),new ProductCountIncreaser(),new NumericUdDefaultValueSeter());
            ProductsManagerForm productsManagerForm = new ProductsManagerForm(new ProductsDataGeter(),new ProductDataBuilder(),new BrandsComboDataGeter(new BrandDataGeter()),productSearcher,new DgFiller(),new ComboBoxFiller(),new BoolComboFiller(),new NumericUdDefaultValueSeter(),new TextBoxRestartor(),new NumericUdRestartor(),new ComboRestartor(),new MaskedTextBoxRestartor(),new ProductAdderOrEditorFormOpener<ProductAdderOrEditorForm>(productAdderOrEditorForm),new ProductCountIncreaserFormOpener<ProductCountIncreaserForm>(productCountIncreaserForm),productDeleter);
            Form1 homeForm = new Form1(new ProductManagementAccessController(), new TimeLabelSeter(), new DateLabelSeter(new MiladiToPersianDateConvertor()),new GroupBoxTextSeter(), new IntroducingLabelSeter(), new AdminLabelSeter(), new FormCloser(), new FormManager(), new DgFiller(), new DgOrdersFiller(), new ComboBoxFiller(),new BoolComboFiller(), new ProductsDataGeter(), new OrdersDataGeter(),new BrandDataGeter(), new BrandsComboDataGeter(new BrandDataGeter()), new NewProductsDataGeter(),new SingleProductDataGeter(), new NumericUdDefaultValueSeter(), productSearcher,new DraftOrderFormOpener<DraftOrderForm>(new DraftOrderForm(new ProductCountChecker(),new ProductDataEditor(),new ProductDataBuilder(),new DraftOrderDataBulider(),new DraftOrderDataAdder(),new NumericUdDefaultValueSeter())),new UserEditorFormOpener<UserEditorForm>(new UserEditorForm(new TextBoxFiller(),new UserDataBuilder(),new UserDataEditor())),new AppRestartor(),new UserDataDeleterById(),new ProductsManagerFormOpener<ProductsManagerForm>(productsManagerForm));
            Application.Run(new StationeryApplicationContext(new LoginUserValidator(), new HomeFormOpener<Form1>(homeForm), new SingleUserDataGeterByNameAndPassword(), new NullOrWhiteSpaceValidator(), new SignUpFormOpener<SignUpForm>(signUpForm), new TextBoxRestartor(), new FormManager()));
        }
    }
}