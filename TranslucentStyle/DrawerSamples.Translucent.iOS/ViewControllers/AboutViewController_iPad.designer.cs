// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DrawerSamples.iOS
{
    [Register("AboutViewController_iPad")]
    partial class AboutViewController_iPad
    {
        [Outlet]
        MonoTouch.UIKit.UILabel AboutLabel { get; set; }

        [Outlet]
        MonoTouch.UIKit.UILabel FooterLabel { get; set; }

        [Outlet]
        MonoTouch.UIKit.UILabel IntroductionLabel { get; set; }

        [Outlet]
        MonoTouch.UIKit.UIButton LearnMoreButton { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (IntroductionLabel != null)
            {
                IntroductionLabel.Dispose();
                IntroductionLabel = null;
            }

            if (LearnMoreButton != null)
            {
                LearnMoreButton.Dispose();
                LearnMoreButton = null;
            }

            if (AboutLabel != null)
            {
                AboutLabel.Dispose();
                AboutLabel = null;
            }

            if (FooterLabel != null)
            {
                FooterLabel.Dispose();
                FooterLabel = null;
            }
        }
    }
}
