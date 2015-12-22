using Fortis.Model;
using Glass.Mapper.Sc;

namespace Testground.Website.TestCases.Fields
{
	public class SingleLineTextFieldTwiceTestCase : TestCase
	{
		public SingleLineTextFieldTwiceTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Single Line Text Field Read Twice"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.SingleLineTextID,
				Const.ItemCount);

            foreach (var item in items)
            {
                var value1 = item["Navigation Title"];
                var value2 = item["Navigation Title"];
            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.Fields.ISingleLineText>(
				Const.SingleLineTextID, 
				Const.ItemCount);

		    foreach (var item in items)
		    {
		        var value1 = item.NavigationTitle.Value;
		        var value2 = item.NavigationTitle.Value;
		    }

		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Fields.SingleLineText>(
				Const.SingleLineTextID, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var value1 = item.NavigationTitle;
                var value2 = item.NavigationTitle;
            }
        }
	}
}