using Intersoft.Crosslight.ViewModels;

namespace DrawerSamples.ViewModels
{
    public class DrawerViewModel : DrawerViewModelBase
    {
        #region Constructors

        public DrawerViewModel()
        {
            this.RightViewModel = new NavigationViewModel();
            this.CenterViewModel = new SimpleViewModel();
        }

        #endregion
    }
}