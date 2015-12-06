using System.Collections.Generic;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Sitecore.Web.UI.WebControls;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Website.TestCases.TypeMapping
{
	public class RenderFieldTypeTestCase : TestCase
	{
		protected readonly IGlassHtml GlassHtml;

		private IEnumerable<Item> SitecoreItems;
		private IEnumerable<INavigation> GlassItems;
		private IEnumerable<Model.Fortis.Templates.UserDefined.INavigation> FortisItems;

		public RenderFieldTypeTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
			this.GlassHtml = new GlassHtml(glassService);
		}

		public override string CaseName
		{
			get { return "Render Field"; }
		}

		protected override void SetUp()
		{
			this.SitecoreItems = this.GetSitecoreItems(
				Const.ContentPageID,
				Const.ItemCount);

			this.GlassItems = this.GetGlassItems<Navigation>(
				Const.ContentPageID,
				Const.ItemCount);

			this.FortisItems = this.GetFortisItems<Model.Fortis.Templates.UserDefined.INavigation>(
				Const.ContentPageID,
				Const.ItemCount);
		}

		protected override void ExecuteSitecoreTest()
		{
			foreach (var item in this.SitecoreItems)
			{
				var renderer = new FieldRenderer();
				renderer.Item = item;
				renderer.FieldName = "Navigation Title";
				var html = renderer.Render();
			}
		}

		protected override void ExecuteFortisTest()
		{
			foreach (var item in this.FortisItems)
			{
				var html = item.NavigationTitle.Render(editing: true);
			}
		}

		protected override void ExecuteGlassTest()
		{
			foreach (var item in this.GlassItems)
			{
				var html = this.GlassHtml.Editable(item, x => x.Navigation_Title);
			}
		}
	}
}