using DrawerSamples.Infrastructure;
using Intersoft.Crosslight;

namespace DrawerSamples.iOS.Infrastructure
{
    public sealed class AppInitializer : IApplicationInitializer
    {
        #region Methods

        public IApplicationService GetApplicationService(IApplicationContext context)
        {
            return new CrosslightAppAppService(context);
        }

        public void InitializeApplication(IApplicationHost appHost)
        {
        }

        public void InitializeComponents(IApplicationHost appHost)
        {
        }

        public void InitializeServices(IApplicationHost appHost)
        {
        }

        #endregion
    }
}