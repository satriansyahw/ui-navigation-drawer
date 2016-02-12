﻿using DrawerSamples.ModelServices;
using DrawerSamples.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Containers;

namespace DrawerSamples.Infrastructure
{
    public sealed class CrosslightAppAppService : ApplicationServiceBase
    {
        #region Constructors

        public CrosslightAppAppService(IApplicationContext context)
            : base(context)
        {
            Container.Current.Register<IItemRepository, ItemRepository>().WithLifetimeManager(new ContainerLifetime());

            Container.Current.Register<ICategoryRepository, CategoryRepository>().WithLifetimeManager(new ContainerLifetime());
        }

        #endregion

        #region Methods

        protected override void OnStart(StartParameter parameter)
        {
            base.OnStart(parameter);


            // Register required core app-level services via IoC

            // Container.Current.Register<IPaymentProcessor, PaypalPaymentProcessor>();


            // Set the root ViewModel to be displayed at startup

            this.SetRootViewModel<DrawerViewModel>();
        }

        #endregion
    }
}