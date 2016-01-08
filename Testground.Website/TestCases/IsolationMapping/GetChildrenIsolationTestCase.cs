using System.Collections.Generic;
using System.Linq;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.IsolationMapping
{
	public class GetChildrenIsolationTestCase : TestCase
	{
		private IEnumerable<Item> SitecoreItems;
		private IEnumerable<Testground.Model.Glass.IsolationModels.GetChildren> GlassItems;
		private IEnumerable<Testground.Model.Fortis.IsolationModels.IGetChildren> FortisItems;

		public GetChildrenIsolationTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Get Children"; }
		}

		protected override void SetUp()
		{
			this.GlassItems = this.GetGlassItems<Testground.Model.Glass.IsolationModels.GetChildren>(
				Const.GetChildrenID,
				Const.ItemCount);

			this.FortisItems = this.GetFortisItems<Testground.Model.Fortis.IsolationModels.IGetChildren>(
				Const.GetChildrenID,
				Const.ItemCount);

			this.SitecoreItems = this.GetSitecoreItems(
				Const.GetChildrenID,
				Const.ItemCount);
		}

		protected override void ExecuteSitecoreTest()
		{
			foreach (var item in this.SitecoreItems)
			{
				var children = item.GetChildren().ToList();
			}
		}

		protected override void ExecuteFortisTest()
		{
			foreach (var item in this.FortisItems)
			{
				var children = item.Children<Testground.Model.Fortis.IsolationModels.IGetChildren>().ToList();
			}
		}

		protected override void ExecuteGlassTest()
		{
			foreach (var item in this.GlassItems)
			{
				var children = item.Children.ToList();
			}
		}
	}
}