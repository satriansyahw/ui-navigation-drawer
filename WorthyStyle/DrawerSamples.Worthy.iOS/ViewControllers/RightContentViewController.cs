using DrawerSamples.ViewModels;
using Intersoft.Crosslight.iOS;

namespace DrawerSamples.iOS
{
    public partial class RightContentViewController : UIViewController<RightContentViewModel>
    {
        #region Constructors

        public RightContentViewController()
            : base("RightContentView", null)
        {
        }

        #endregion
    }
}