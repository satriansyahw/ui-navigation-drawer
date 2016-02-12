﻿namespace DrawerSamples.ViewModels
{
    public class AboutNavigationViewModel : AboutViewModelBase
    {
        #region Constructors

        public AboutNavigationViewModel()
        {
            this.Title = "About This App";
            this.AboutText = "Navigation Services enables you to perform navigation from within the ViewModel. You can navigate to a ViewModel by providing the type, or a known identifier.";
        }

        #endregion
    }
}