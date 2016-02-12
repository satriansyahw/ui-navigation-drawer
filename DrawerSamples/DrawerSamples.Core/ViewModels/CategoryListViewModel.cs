using DrawerSamples.Infrastructure;
using DrawerSamples.Models;
using DrawerSamples.ModelServices;
using Intersoft.Crosslight;
using Intersoft.Crosslight.ViewModels;

namespace DrawerSamples.ViewModels
{
    public class CategoryListViewModel : ListViewModelBase<Category>
    {
        #region Constructors

        public CategoryListViewModel()
        {
            this.SourceItems = this.Repository.GetAll().ToObservable();
        }

        #endregion

        #region Properties

        private ICategoryRepository Repository
        {
            get
            {
                if (Container.Current.CanResolve<ICategoryRepository>())
                    return Container.Current.Resolve<ICategoryRepository>();
                else
                    return new CategoryRepository(); // for designer support
            }
        }

        #endregion
    }
}