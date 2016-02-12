using System;

using DrawerSamples.ViewModels;

using Intersoft.Crosslight;

using Intersoft.Crosslight.iOS;

using MonoTouch.Foundation;



namespace DrawerSamples.iOS
{

    [Register("MainViewController_iPad")]

    [RegisterNavigation(DeviceKind.Tablet)]

    [ImportBinding(typeof(NavigationBindingProvider))]

    public class MainViewController_iPad : UIMasterDetailViewController<NavigationViewModel>
    {

    }

}

