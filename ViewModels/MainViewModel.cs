using Prism.Mvvm;

namespace ETABSPlugin_Prism.ViewModels
{
    internal interface IMainViewModel
    {
        string MyText { get; set; }
    }

    public class MainViewModel : BindableBase, IMainViewModel
    {
        private string m_MyText = "Shell ViewModel Text";

        public string MyText
        {
            get { return m_MyText; }
            set { SetProperty(ref m_MyText, value); }
        }
    }
}
