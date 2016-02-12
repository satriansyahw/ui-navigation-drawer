using System;
using Android.App;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight.Android.v7;

namespace DrawerSamples.Android.Activities
{
    [Activity]
    public class MainDrawerActivity : DrawerActivity<DrawerViewModel>
    {
        #region Constructors

        public MainDrawerActivity()
        {
        }

        public MainDrawerActivity(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        #endregion
    }
}