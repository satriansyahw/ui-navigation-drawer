using Intersoft.Crosslight;

namespace DrawerSamples
{
    public class NavigationBindingProvider : BindingProvider
    {
        #region Constructors

        public NavigationBindingProvider()
        {
            ItemBindingDescription itemBinding = new ItemBindingDescription()
            {
                DisplayMemberPath = "Title",
                NavigateMemberPath = "Target",
                ImageMemberPath = "Image"
            };

            this.AddBinding("TableView", BindableProperties.ItemsSourceProperty, "Items");
            this.AddBinding("TableView", BindableProperties.ItemTemplateBindingProperty, itemBinding, true);
            this.AddBinding("TableView", BindableProperties.SelectedItemProperty, "SelectedItem", BindingMode.TwoWay);
        }

        #endregion
    }
}