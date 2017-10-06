using Prism.Unity;
using POCPrism.Views;
using Xamarin.Forms;
using DLToolkit.Forms.Controls;

namespace POCPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            FlowListView.Init();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SpeakPage>();
            Container.RegisterTypeForNavigation<Likes>();
            Container.RegisterTypeForNavigation<Following>();
            Container.RegisterTypeForNavigation<Followers>();
            Container.RegisterTypeForNavigation<Followers>();
        }
    }
}
