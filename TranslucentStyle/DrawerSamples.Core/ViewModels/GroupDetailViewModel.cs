﻿using DrawerSamples.Infrastructure;
using DrawerSamples.Models;
using DrawerSamples.ModelServices;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace DrawerSamples.ViewModels
{
    public class GroupDetailViewModel : GroupListViewModelBase<CategoryGroup, Item>
    {
        #region Properties

        [StateAware]
        public int GroupKey
        {
            get { return this.Group.Category.Id; }
            set { this.Group = this.ItemRepository.GetCategoryGroup(value); }
        }

        private IItemRepository ItemRepository
        {
            get { return Container.Current.Resolve<IItemRepository>(); }
        }

        #endregion

        #region Methods

        public override void Navigated(NavigatedParameter parameter)
        {
            base.Navigated(parameter);

            if (parameter.Data != null)
                this.Group = parameter.Data as CategoryGroup;
        }

        #endregion
    }
}