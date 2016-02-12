using System;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight.Android.v7;

namespace DrawerSamples.Android.Activities
{
    public class RightFragment : Fragment<RightContentViewModel>
    {
        #region Constructors

        public RightFragment()
        {
        }

        public RightFragment(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion

        #region Properties

        protected override int ContentLayoutId
        {
            get { return Resource.Layout.RightFragmentLayout; }
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