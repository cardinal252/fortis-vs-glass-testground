﻿using System.Collections.Generic;
using System.Linq;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.TypeMapping
{
	public class GetChildrenTypeTestCase : TestCase
	{
		private IEnumerable<Item> SitecoreItems;
		private IEnumerable<INavigation> GlassItems;
		private IEnumerable<Model.Fortis.Templates.UserDefined.INavigation> FortisItems;

		public GetChildrenTypeTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Get Children"; }
		}

		protected override void SetUp()
		{
			this.GlassItems = this.GetGlassItems<Navigation>(
				Const.ContentPageID,
				Const.ItemCount);

			this.FortisItems = this.GetFortisItems<Model.Fortis.Templates.UserDefined.INavigation>(
				Const.ContentPageID,
				Const.ItemCount);

			this.SitecoreItems = this.GetSitecoreItems(
				Const.ContentPageID,
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
				var children = item.Children<Model.Fortis.Templates.UserDefined.INavigation>().ToList();
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