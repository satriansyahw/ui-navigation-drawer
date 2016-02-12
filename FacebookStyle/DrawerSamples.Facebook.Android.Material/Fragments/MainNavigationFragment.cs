using System;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using Intersoft.Crosslight.Android.v7;

namespace DrawerSamples.Android.Activities
{
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class MainNavigationFragment : RecyclerViewFragment<NavigationViewModel>
    {
        #region Constructors

        public MainNavigationFragment()
        {
        }

        public MainNavigationFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int FooterLayoutId
        {
            get { return Resource.Layout.FooterLayout; }
        }

        protected override int HeaderLayoutId
        {
            get { return Resource.Layout.nav_header; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.CellStyle = CellStyle.NavigationDrawer;
            this.InteractionMode = ListViewInteraction.Navigation;
        }

        #endregion
    }
}