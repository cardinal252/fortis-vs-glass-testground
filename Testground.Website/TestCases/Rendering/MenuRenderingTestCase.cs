using System.Linq;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Links;
using Sitecore.Web.UI.WebControls;

namespace Testground.Website.TestCases.Rendering
{
	public class MenuRenderingTestCase : TestCase
	{
		public MenuRenderingTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Generate Menu"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.MenuId,
				Const.ItemCount);

            foreach (var item in items)
            {
                var title1 = item["Navigation Title"];
                var url1 = LinkManager.GetItemUrl(item);
                //get child menu items

                foreach (
                    var child in
                        item.Children.Where(
                            x => new Sitecore.Data.Fields.CheckboxField(item.Fields["Hide From Navigation"]).Checked == false))
                {
                    var title2 = child["Navigation Title"];
                    var url2 = LinkManager.GetItemUrl(child);

                }

            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.Rendering.IMenu>(
				Const.MenuId, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var title1 = item.NavigationTitle.Value;
                var url1 = item.GenerateUrl();
                //get child menu items

                foreach (
                    var child in
                        item.Children< Testground.Model.Fortis.Rendering.IMenu>().Where(x=>x.HideFromNavigation.Value == false))
                {
                    var title2 = child.NavigationTitle.Value;
                    var url2 = child.GenerateUrl();
                }
            }

        }

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Renderings.Menu>(
				Const.MenuId, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var title1 = item.NavigationTitle;
                var url1 = item.Url;
                //get child menu items

                foreach (
                    var child in
                        item.Children.Where(x => x.HideFromNavigation == false))
                {
                    var title2 = child.NavigationTitle;
                    var url2 = child;
                }

            }
        }
	}
}