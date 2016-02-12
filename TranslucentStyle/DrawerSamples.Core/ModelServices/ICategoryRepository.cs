using DrawerSamples.Models;

namespace DrawerSamples.ModelServices
{
    public interface ICategoryRepository : IDataRepository<Category, int>
    {
        #region Methods

        Category GetByName(string name);

        #endregion
    }
}