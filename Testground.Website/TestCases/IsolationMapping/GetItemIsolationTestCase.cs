using Fortis.Model;
using Glass.Mapper.Sc;
using Testground.Model.Fortis.Fields;
using Testground.Model.Fortis.IsolationModels;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.IsolationMapping
{
	public class GetItemIsolationTestCase : TestCase
	{
		public GetItemIsolationTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
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
				Const.GetItemPageID,
				Const.ItemCount);
		}

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.IsolationModels.IGetItem>(
				Const.GetItemPageID, 
				Const.ItemCount);
		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.IsolationModels.GetItem>(
				Const.GetItemPageID, 
				Const.ItemCount);
		}
	}
}