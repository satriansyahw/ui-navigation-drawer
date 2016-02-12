using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace DrawerSamples.ViewModels
{
    public class SampleListViewModelBase<T> : ListViewModelBase<T> where T : NavigationItem
    {
        #region Constructors

        public SampleListViewModelBase()
        {
            this.FooterText = "Powered by Crosslight®";
        }

        #endregion

        #region Fields

        private string _footerText;

        #endregion

        #region Properties

        public string FooterText
        {
            get { return _footerText; }
            set
            {
                if (_footerText != value)
                {
                    _footerText = value;
                    OnPropertyChanged("FooterText");
                }
            }
        }

        #endregion
    }
}