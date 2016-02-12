using System.Linq;
using DrawerSamples.Infrastructure;
using DrawerSamples.ModelServices;
using Intersoft.Crosslight;

namespace DrawerSamples.Models
{
    public class CategoryGroup : GroupItem<Item>
    {
        #region Constructors

        public CategoryGroup(IGrouping<string, Item> groupItem)
            : base(groupItem)
        {
            this.Category = this.CategoryRepository.GetByName(groupItem.Key);
        }

        #endregion

        #region Properties

        public Category Category { get; private set; }

        private ICategoryRepository CategoryRepository
        {
            get { return Container.Current.Resolve<ICategoryRepository>(); }
        }

        private IItemRepository ItemRepository
        {
            get { return Container.Current.Resolve<IItemRepository>(); }
        }

        #endregion
    }
}