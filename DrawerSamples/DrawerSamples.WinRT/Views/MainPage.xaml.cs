using DrawerSamples.ViewModels;
using Intersoft.Crosslight;

namespace DrawerSamples.WinRT
{
    /// <summary>
    ///     The main navigation page with the list view in the left panel and the detail frame in the right panel.
    /// </summary>
    [ViewModelType(typeof(DrawerViewModel))]
    public sealed partial class MainPage
    {
        #region Constructors

        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}