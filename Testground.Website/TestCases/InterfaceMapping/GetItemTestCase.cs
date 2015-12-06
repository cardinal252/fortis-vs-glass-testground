using Fortis.Model;
using Glass.Mapper.Sc;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.InterfaceMapping
{
	public class GetItemTestCase : TestCase
	{
		public GetItemTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Get Item"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.ContentPageID,
				Const.ItemCount);
		}

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Model.Fortis.Templates.UserDefined.INavigation>(
				Const.ContentPageID, 
				Const.ItemCount);
		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<INavigation>(
				Const.ContentPageID, 
				Const.ItemCount);
		}
	}
}