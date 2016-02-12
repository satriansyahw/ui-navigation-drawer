using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using System.Linq;


namespace DrawerSamples.WinRT.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    [ViewModelType(typeof(NavigationViewModel))]
    public sealed partial class NavigationPage : DrawerSamples.WinRT.Common.LayoutAwarePage
    {
        public NavigationPage()
        {
            this.InitializeComponent();
        }

        public new NavigationViewModel ViewModel
        {
            get
            {
                return base.ViewModel as NavigationViewModel;
            }
        }

        protected override void InitializeViewModel()
        {
            base.InitializeViewModel();

            this.ViewModel.SelectedItem = this.ViewModel.Items.ElementAtOrDefault(0);
        }

        public override void InvalidateLayoutVisualState()
        {
            base.InvalidateLayoutVisualState();
        }
    }
}
