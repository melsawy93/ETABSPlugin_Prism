using ETABSPlugin_Prism.ViewModels;
using System.Windows;
using Unity;

namespace ETABSPlugin_Prism.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private readonly IUnityContainer _container;
        public MainView(IUnityContainer container)
        {
            InitializeComponent();

            _container = container;

            this.DataContext = _container.Resolve<IMainViewModel>();
        }
    }
}
