using Android.App;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DrawerSamples.Android
{
    [Activity(Label = "Crosslight App", Icon = "@drawable/icon")]
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class NavigationListActivity : ListFragmentActivity<NavigationViewModel>
    {
        #region Constructors

        public NavigationListActivity()
            : base(Resource.Layout.NavigationListActivityLayout, Resource.Id.item_list, Resource.Id.item_detail_container)
        {
        }

        #endregion

        #region Methods

        protected override void OnViewInitialized()
        {
            base.OnViewInitialized();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        #endregion
    }
}