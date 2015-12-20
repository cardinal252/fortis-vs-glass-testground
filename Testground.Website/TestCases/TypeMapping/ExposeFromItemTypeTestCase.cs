using System.Collections.Generic;
using Fortis.Model;
using Fortis.Providers;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.TypeMapping
{
	public class ExposeFromItemTypeTestCase : TestCase
	{
		private IEnumerable<Item> SitecoreItems;
		protected readonly ISpawnProvider SpawnProvider;

		public ExposeFromItemTypeTestCase(IItemFactory fortisService, ISitecoreContext glassService, ISpawnProvider spawnProvider) 
			: base(fortisService, glassService)
		{
			this.SpawnProvider = spawnProvider;
		}

		public override string CaseName
		{
			get { return "Expose From Item"; }
		}

		protected override void SetUp()
		{
			base.SetUp();

			this.SitecoreItems = this.GetSitecoreItems(Const.ContentPageID, Const.ItemCount);
		}

		protected override void ExecuteSitecoreTest()
		{
		}

		protected override void ExecuteFortisTest()
		{
			foreach (var item in this.SitecoreItems)
			{
				var obj = this.SpawnProvider.FromItem<Model.Fortis.Templates.UserDefined.INavigationItem>(item);
			}
		}

		protected override void ExecuteGlassTest()
		{
			foreach (var item in this.SitecoreItems)
			{
				var obj = item.GlassCast<Navigation>();
			}
		}
	}
}