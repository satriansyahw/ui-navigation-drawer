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
            this.DrawerSettings.EnableStatusBarTransition = false;
            this.DrawerSettings.NavigationBarTintColor = UIColor.Gray;
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            // customize right button image
            this.RightButtonItem = new UIBarButtonItem();
            this.RightButtonItem.Image = UIImage.FromBundle("Group.png");
        }

        #endregion
    }
}