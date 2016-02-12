using Intersoft.Crosslight.ViewModels;

namespace DrawerSamples.ViewModels
{
    public class DrawerViewModel : DrawerViewModelBase
    {
        #region Constructors

        public DrawerViewModel()
        {
            this.LeftViewModel = new NavigationViewModel();
            this.CenterViewModel = new SimpleViewModel();
            this.RightViewModel = new RightContentViewModel();
        }

        #endregion
    }
}