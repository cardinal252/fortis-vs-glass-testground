using Fortis.Model;
using Glass.Mapper.Sc;
using Testground.Model.Fortis.Fields;
using Testground.Model.Fortis.Rendering;

namespace Testground.Website.TestCases.Fields
{
	public class SingleLineTextFieldTestCase : TestCase
	{
		public SingleLineTextFieldTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Single Line Text Field"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.SingleLineTextID,
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = item["Navigation Title"];
            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<ISingleLineText>(
				Const.SingleLineTextID, 
				Const.ItemCount);

		    foreach (var item in items)
		    {
		        var value = item.NavigationTitle.Value;
		    }

		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Fields.SingleLineText>(
				Const.SingleLineTextID, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = item.NavigationTitle;
            }
        }
	}
}