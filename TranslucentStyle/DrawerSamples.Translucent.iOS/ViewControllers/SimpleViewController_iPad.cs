using DrawerSamples.ViewModels;

using Intersoft.Crosslight;

using Intersoft.Crosslight.iOS;



namespace DrawerSamples.iOS
{

    [ImportBinding(typeof(SimpleBindingProvider))]

    //[RegisterNavigation(DeviceKind.Tablet)]

    public partial class SimpleViewController_iPad : UIDetailViewController<SimpleViewModel>
    {

        #region Constructors



        public SimpleViewController_iPad() :
            base("SimpleView_iPad", null)
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