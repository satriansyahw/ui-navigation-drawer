using DrawerSamples.ViewModels;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;

namespace DrawerSamples.iOS
{
    [Register("AboutViewController")]
    [ImportBinding(typeof(AboutBindingProvider))]
    public partial class AboutViewController : UIViewController<AboutNavigationViewModel>
    {
        #region Constructors

        public AboutViewController(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {
        }


        public AboutViewController()
            : base("AboutView", null)
        {
        }

        #endregion

        #region Properties

        public override bool AutoFitContentSize
        {
            get { return true; }
        }

        #endregion
    }
}