using Fortis.Model;
using Glass.Mapper.Sc;

namespace Testground.Website.TestCases.IsolationMapping
{
	public class GetItemPathIsolationTestCase : TestCase
	{
		public GetItemPathIsolationTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Get Item using Path"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.GetItemPath,
				Const.ItemCount);
		}

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.IsolationModels.IGetItem>(
				Const.GetItemPath, 
				Const.ItemCount);
		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.IsolationModels.GetItem>(
				Const.GetItemPath, 
				Const.ItemCount);
		}
	}
}