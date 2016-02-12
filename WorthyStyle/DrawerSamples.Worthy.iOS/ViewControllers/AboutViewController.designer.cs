// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using UIKit;

namespace DrawerSamples.iOS
{
    partial class AboutViewController
    {
        [Outlet]
        UILabel IntroductionLabel { get; set; }

        [Outlet]
        UILabel AboutLabel { get; set; }

        [Outlet]
        UIButton LearnMoreButton { get; set; }

        [Outlet]
        UILabel FooterLabel { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (IntroductionLabel != null)
            {
                IntroductionLabel.Dispose();
                IntroductionLabel = null;
            }

            if (AboutLabel != null)
            {
                AboutLabel.Dispose();
                AboutLabel = null;
            }

            if (LearnMoreButton != null)
            {
                LearnMoreButton.Dispose();
                LearnMoreButton = null;
            }

            if (FooterLabel != null)
            {
                FooterLabel.Dispose();
                FooterLabel = null;
            }
        }
    }
}
