using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;

namespace Testground.Website.TestCases.Fields
{
	public class ThreeFieldsTestCase : TestCase
	{
		public ThreeFieldsTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "All Three Fields"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.ThreeFieldsID,
				Const.ItemCount);

            foreach (var item in items)
            {
                var value1 = new Sitecore.Data.Fields.CheckboxField(item.Fields["Hide From Navigation"]).Checked;
                var value2 = FieldRenderer.Render(item, "Content Body");
                var value3 = item["Navigation Title"];
            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.Fields.IThreeFields>(
				Const.ThreeFieldsID, 
				Const.ItemCount);

		    foreach (var item in items)
		    {
		        var value1 = item.HideFromNavigation.Value;
		        var value2 = item.ContentBody.Value;
		        var value3 = item.NavigationTitle.Value;

		    }

		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Fields.ThreeFields>(
				Const.ThreeFieldsID, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var value1 = item.HideFromNavigation;
                var value2 = item.ContentBody;
                var value3 = item.NavigationTitle;
            }
        }
	}
}