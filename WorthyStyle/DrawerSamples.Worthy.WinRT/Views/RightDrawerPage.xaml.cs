using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DrawerSamples.WinRT.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    [ViewModelType(typeof(RightContentViewModel))]
    public sealed partial class RightDrawerPage : DrawerSamples.WinRT.Common.LayoutAwarePage
    {
        public RightDrawerPage()
        {
            this.InitializeComponent();
        }
    }
}
