using System.Collections.Generic;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;

using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.IsolationMapping
{
	public class ReadFieldValueIsolationTestCase : TestCase
	{
		private IEnumerable<Item> SitecoreItems;
		private IEnumerable<Testground.Model.Glass.IsolationModels.ReadFieldValue> GlassItems;
		private IEnumerable<Testground.Model.Fortis.IsolationModels.ReadFieldValue> FortisItems;

		public ReadFieldValueIsolationTestCase(IItemFactory fortisService, ISitecoreContext glassService)
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Read Field Value"; }
		}

		protected override void SetUp()
		{
			this.SitecoreItems = this.GetSitecoreItems(
				Const.ReadFieldValueID,
				Const.ItemCount);

			this.GlassItems = this.GetGlassItems<Testground.Model.Glass.IsolationModels.ReadFieldValue>(
				Const.ReadFieldValueID,
				Const.ItemCount);

			this.FortisItems = this.GetFortisItems<Testground.Model.Fortis.IsolationModels.ReadFieldValue>(
				Const.ReadFieldValueID,
				Const.ItemCount);
		}

		protected override void ExecuteSitecoreTest()
		{
			foreach (var item in this.SitecoreItems)
			{
				var value = item.Fields["Navigation Title"].Value;
			}
		}

		protected override void ExecuteFortisTest()
		{
			foreach (var item in this.FortisItems)
			{
				var value = item.NavigationTitle.Value;
			}
		}

		protected override void ExecuteGlassTest()
		{
			foreach (var item in this.GlassItems)
			{
				var value = item.Navigation_Title;
			}
		}
	}
}