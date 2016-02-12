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

        public override UITableViewStyle TableViewStyle
        {
            get { return UITableViewStyle.Grouped; }
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            // set TableView header
            this.Appearance.HeaderViewNibName = "HeaderTableView";
            this.Appearance.FooterViewNibName = "FooterTableView";

            // set navigation title
            this.NavigationItem.Title = "Crosslight App";
        }

        #endregion
    }
}