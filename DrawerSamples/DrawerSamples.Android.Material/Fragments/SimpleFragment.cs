using System;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android.v7;

namespace DrawerSamples.Android.Activities
{
    [ImportBinding(typeof(SimpleBindingProvider))]
    public class SimpleFragment : Fragment<SimpleViewModel>
    {
        #region Constructors

        public SimpleFragment()
        {
        }

        public SimpleFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.simple_fragment_layout; }
        }

        #endregion

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.IconId = Resource.Drawable.ic_toolbar;
        }

        #endregion
    }
}