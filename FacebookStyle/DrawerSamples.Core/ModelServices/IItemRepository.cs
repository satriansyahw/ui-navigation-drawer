using DrawerSamples.Models;
using Intersoft.Crosslight;

namespace DrawerSamples.ModelServices
{
    public interface IItemRepository : IEditableDataRepository<Item, string>
    {
        #region Methods

        CategoryGroup GetCategoryGroup(int group);
        GroupItem<Item> GetLocationGroup(string group);

        #endregion
    }
}