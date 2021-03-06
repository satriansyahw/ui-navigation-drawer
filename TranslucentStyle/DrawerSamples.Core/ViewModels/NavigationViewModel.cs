﻿using System.Collections.Generic;
using System.Linq;
using Intersoft.Crosslight;

namespace DrawerSamples.ViewModels
{
    public class NavigationViewModel : SampleListViewModelBase<NavigationItem>
    {
        #region Constructors

        public NavigationViewModel()
        {
            List<NavigationItem> items = new List<NavigationItem>();

            items.Add(new NavigationItem("Simple Page", "About", typeof(SimpleViewModel))
            {
                Image = "message.png"
            });
            items.Add(new NavigationItem("About This App", "About", typeof(AboutNavigationViewModel))
            {
                Image = "info.png"
            });

            this.SourceItems = items;
            this.RefreshGroupItems();
        }

        #endregion

        #region Properties

        private string _aboutText { get; set; }

        public string AboutText
        {
            get { return _aboutText; }
            set
            {
                if (_aboutText != value)
                {
                    _aboutText = value;
                    OnPropertyChanged("AboutText");
                }
            }
        }

        #endregion

        #region Methods

        public override void RefreshGroupItems()
        {
            if (this.Items != null)
                this.GroupItems = this.Items.GroupBy(o => o.Group).Select(o => new GroupItem<NavigationItem>(o)).ToList();
        }

        #endregion
    }
}