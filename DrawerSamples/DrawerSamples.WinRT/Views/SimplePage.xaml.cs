using DrawerSamples.ViewModels;
using Intersoft.Crosslight;

namespace DrawerSamples.WinRT
{
    [ViewModelType(typeof(SimpleViewModel))]
    public sealed partial class SimplePage
    {
        public SimplePage()
        {
            this.InitializeComponent();
        }
    }
}
