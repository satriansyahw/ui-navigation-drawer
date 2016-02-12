using DrawerSamples.ViewModels;
using Foundation;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using UIKit;

namespace DrawerSamples.iOS.ViewControllers
{
    [Register("NavigationViewController")]
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class NavigationViewController : UITableViewController<NavigationViewModel>
    {
        #region Properties

        public override bool DeselectRowOnNavigate
        {
            get { return true; }
        }

        public override TableViewInteraction InteractionMode
        {
            get { return TableViewInteraction.Navigation; }
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            // set general appearance settings
            this.Appearance.ShowSeparator = false;
            this.Appearance.TitleTextColor = UIColor.DarkGray;

            this.Appearance.TitleTextAttributes = new UITextAttributes()
            {
                Font = UIFont.FromName("HelveticaNeue-Light", 16f)
            };

            // set TableView header
            this.Appearance.HeaderViewNibName = "HeaderTableView";
            this.Appearance.FooterViewNibName = "FooterTableView";

            // set navigation title
            this.NavigationItem.Title = "Crosslight App";
        }

        #endregion
    }
}