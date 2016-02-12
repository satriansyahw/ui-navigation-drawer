using System;
using Android.App;
using Android.Graphics;
using Android.Runtime;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight.Android;

namespace DrawerSamples.Android.Activities
{
    [Activity]
    public class MainDrawerActivity : Intersoft.Crosslight.Android.v7.DrawerActivity<DrawerViewModel>
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

        #region Methods

        protected override void Initialize()
        {
            base.Initialize();

            this.DrawerSettings = new DrawerSettings
            {
                LeftDrawerBackgroundColor = new Color(0, 0, 0, 150),
                ActionBarDrawerIcon = Resource.Drawable.ic_drawer,
                ShadowColor = new Color(255, 255, 255, 0)
            };
        }

        #endregion
    }
}