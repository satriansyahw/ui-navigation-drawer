using Android.App;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace DrawerSamples.Android.Activities
{
    [Activity(Label = "Simple Activity", Icon = "@drawable/icon")]
    [ImportBinding(typeof(SimpleBindingProvider))]
    public class SimpleActivity : FragmentActivity<SimpleViewModel>
    {
        #region Constructors

        public SimpleActivity()
            : base(Resource.Layout.SimpleActivityLayout, Resource.Id.SimpleFragment)
        {
        }

        #endregion
    }
}