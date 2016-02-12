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
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlack;
            this.DrawerSettings.CenterStatusBarContentStyle = StatusBarContentStyle.Light;
            this.DrawerSettings.NavigationBarColor = UIColor.FromRGB(47, 80, 147);
            this.DrawerSettings.NavigationBarTintColor = UIColor.White;
            this.DrawerSettings.NavigationBarTitleAttributes = new UITextAttributes()
            {
                TextColor = UIColor.White
            };
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            var searchButton = new UIBarButtonItem(UIBarButtonSystemItem.Search);
            // handle searchButton's Clicked event, or assign a command to be called in ViewModel.

            // add a custom left button item to our view
            this.LeftButtonItem = searchButton;

            // customize the right button item which automatically open/close the drawer
            this.RightButtonItem = new UIBarButtonItem();
            this.RightButtonItem.Image = UIImage.FromBundle("UserList.png");
        }

        #endregion
    }
}