using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;

namespace Testground.Website.TestCases.Fields
{
	public class CheckboxFieldTestCase : TestCase
	{
		public CheckboxFieldTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Checkbox Field"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.CheckboxID,
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = new Sitecore.Data.Fields.CheckboxField(item.Fields["Hide From Navigation"]).Checked;
            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.Fields.ICheckbox>(
				Const.CheckboxID, 
				Const.ItemCount);

		    foreach (var item in items)
		    {
		        var value = item.HideFromNavigation.Value;
		    }

		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Fields.Checkbox>(
				Const.CheckboxID, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = item.HideFromNavigation;
            }
        }
	}
}