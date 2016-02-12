using DrawerSamples.ViewModels;
using Foundation;
using Intersoft.Crosslight.iOS;
using UIKit;

namespace DrawerSamples.iOS
{
    [Register("MainDrawerViewController")]
    public class MainDrawerViewController : UIDrawerNavigationController<DrawerViewModel>
    {
        #region Constructors

        public MainDrawerViewController()
        {
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlur;
            this.DrawerSettings.LeftStatusBarColor = UIColor.GroupTableViewBackgroundColor;
        }

        #endregion
    }
}