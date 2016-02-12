using DrawerSamples.ViewModels;

using Intersoft.Crosslight;

using Intersoft.Crosslight.iOS;



namespace DrawerSamples.iOS
{

    [ImportBinding(typeof(AboutBindingProvider))]

    [RegisterNavigation(DeviceKind.Tablet)]

    public partial class AboutViewController_iPad : UIDetailViewController<AboutNavigationViewModel>
    {

        #region Properties



        public override bool AutoFitContentSize
        {
            get { return true; }
        }



        #endregion



        #region Constructors



        public AboutViewController_iPad()
            : base("AboutView_iPad", null)
        {

        }



        #endregion



        #region Methods



        protected override void OnViewInitialized()
        {

            base.OnViewInitialized();


            this.Title = "Detail";

        }



        #endregion

    }

}