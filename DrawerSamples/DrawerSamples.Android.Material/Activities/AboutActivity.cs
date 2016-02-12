using Android.App;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DrawerSamples.Android.Activities
{
    [Activity(Label = "About Crosslight", Icon = "@drawable/icon")]
    [ImportBinding(typeof(AboutBindingProvider))]
    public class AboutActivity : FragmentActivity<AboutNavigationViewModel>
    {
        #region Constructors

        public AboutActivity()
            : base(Resource.Layout.AboutActivityLayout, Resource.Id.AboutFragment)
        {
        }

        #endregion
    }
}