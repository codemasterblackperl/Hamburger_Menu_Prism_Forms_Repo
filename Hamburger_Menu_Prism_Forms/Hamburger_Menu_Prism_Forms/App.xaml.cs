using Prism.Unity;
using Hamburger_Menu_Prism_Forms.Views;

namespace Hamburger_Menu_Prism_Forms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MDPage/MyNavigationPage/BillingPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MDPage>();
            Container.RegisterTypeForNavigation<BillingPage>();
            Container.RegisterTypeForNavigation<PlaceOrderPage>();
            Container.RegisterTypeForNavigation<SettingsPage>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
        }
    }
}
