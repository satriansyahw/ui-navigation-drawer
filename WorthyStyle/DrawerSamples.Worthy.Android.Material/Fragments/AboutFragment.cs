using System;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;
using Intersoft.Crosslight.Android.v7.ComponentModels;

namespace DrawerSamples.Android.Activities
{
    [ImportBinding(typeof(AboutBindingProvider))]
    public class AboutFragment : Fragment<AboutNavigationViewModel>
    {
        #region Constructors

        public AboutFragment()
        {
        }

        public AboutFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.AboutFragmentLayout; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
            this.Appearance.Padding = new Thickness(16);
        }

        #endregion
    }
}