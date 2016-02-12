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

            // this.Appearance.BackgroundImage = "app_bg.jpg";
            this.Appearance.BackgroundColor = UIColor.Clear;
            this.Appearance.TitleTextColor = UIColor.White;
            this.Appearance.CellBackgroundColor = UIColor.Clear;
            this.Appearance.CellSelectedBackgroundBlurEnabled = true;
            this.Appearance.CellSelectedBackgroundColor = UIColor.Clear;
            this.Appearance.ShowSeparator = false;
            this.Appearance.HideSeparatorOnEmptyCell = true;
            this.Appearance.ContentInset = new UIEdgeInsets(20, 0, 0, 0);

            // enable new vibrancy effects, note that ContentEffect will override SeparatorEffect
            // this.Appearance.SeparatorEffect = UIVibrancyEffect.FromBlurEffect(UIBlurEffect.FromStyle(UIBlurEffectStyle.Light));
            // this.Appearance.ContentEffect = UIVibrancyEffect.FromBlurEffect(UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark));

            // set TableView header
            this.Appearance.HeaderViewNibName = "HeaderTableView";

            // set navigation title
            this.NavigationItem.Title = "Crosslight App";
        }

        #endregion
    }
}