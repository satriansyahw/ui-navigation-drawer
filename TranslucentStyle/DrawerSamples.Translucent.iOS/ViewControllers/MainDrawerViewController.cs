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
            // use default config
            // this.SetupDefaultConfig();

            // use "slide parallax" animation
            // this.SetupParallaxConfig();

            // use "scale" animation
            this.SetupScaleConfig();
        }

        #endregion

        #region Methods

        private void SetupDefaultConfig()
        {
            this.DrawerSettings.BackgroundImage = "app_bg.jpg";
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.TranslucentBlur;
            this.DrawerSettings.LeftStatusBarContentStyle = StatusBarContentStyle.Light;
            this.DrawerSettings.ShadowEnabled = false;
            this.DrawerSettings.CenterBackgroundBlurEnabled = true;
            this.DrawerSettings.EnableFadingAnimation = true;
        }

        private void SetupParallaxConfig()
        {
            this.SetupDefaultConfig();

            // enable parallax animation
            this.DrawerSettings.DrawerAnimation = DrawerAnimationKind.SlideParallax;

            // customizable parallax settings
            // this.DrawerSettings.SlideParallaxVelocity = 0.5f;
        }

        private void SetupScaleConfig()
        {
            this.DrawerSettings.BackgroundImage = "sky_bg.jpg";
            this.DrawerSettings.StatusBarTransitionMode = StatusBarTransitionMode.AnimateColor;
            this.DrawerSettings.LeftStatusBarContentStyle = StatusBarContentStyle.Light;
            this.DrawerSettings.LeftStatusBarColor = UIColor.Clear;
            this.DrawerSettings.CenterStatusBarColor = UIColor.Clear;

            // play with visual settings
            // 1) apply stronger shadow effects
            this.DrawerSettings.ShadowOffsetX = -10;
            this.DrawerSettings.ShadowOffsetX = 8;
            this.DrawerSettings.ShadowOffsetY = 10;
            this.DrawerSettings.ShadowRadius = 8;

            // 2) or apply translucent instead
            // this.DrawerSettings.ShadowEnabled = false;
            // this.DrawerSettings.CenterBackgroundBlurEnabled = true;

            // enable scale animation, parallax automatically enabled
            this.DrawerSettings.DrawerAnimation = DrawerAnimationKind.Scale;

            // customizable scale settings
            // this.DrawerSettings.ScaleVelocity = 0.1f;
        }

        #endregion
    }
}