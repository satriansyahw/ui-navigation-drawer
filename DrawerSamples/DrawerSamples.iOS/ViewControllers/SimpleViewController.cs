using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;

namespace DrawerSamples.iOS
{
    [ImportBinding(typeof(SimpleBindingProvider))]
    public partial class SimpleViewController : UIViewController<SimpleViewModel>
    {
        #region Constructors

        public SimpleViewController()
            : base("SimpleView", null)
        {
        }

        #endregion

        #region Properties

        public override bool HideKeyboardOnTap
        {
            get { return true; }
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.Title = "Crosslight App";
        }

        #endregion
    }
}