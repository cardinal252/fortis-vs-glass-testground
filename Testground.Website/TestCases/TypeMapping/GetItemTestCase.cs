using Fortis.Model;
using Glass.Mapper.Sc;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.TypeMapping
{
	public class GetItemTypeTestCase : TestCase
	{
		public GetItemTypeTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
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
			var items = this.GetFortisItems<Model.Fortis.Templates.UserDefined.INavigationItem>(
				Const.ContentPageID, 
				Const.ItemCount);
		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Navigation>(
				Const.ContentPageID, 
				Const.ItemCount);
		}
	}
}