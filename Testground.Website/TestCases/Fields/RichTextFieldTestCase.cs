using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;

namespace Testground.Website.TestCases.Fields
{
	public class RichTextFieldTestCase : TestCase
	{
		public RichTextFieldTestCase(IItemFactory fortisService, ISitecoreContext glassService) 
			: base(fortisService, glassService)
		{
		}

		public override string CaseName
		{
			get { return "Rich Text Field"; }
		}

		protected override void ExecuteSitecoreTest()
		{
			var items = this.GetSitecoreItems(
				Const.RichTextID,
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = FieldRenderer.Render(item, "Content Body");
            }
        }

		protected override void ExecuteFortisTest()
		{
			var items = this.GetFortisItems<Testground.Model.Fortis.Fields.IRichText>(
				Const.RichTextID, 
				Const.ItemCount);

		    foreach (var item in items)
		    {
		        var value = item.ContentBody.Value;
		    }

		}

		protected override void ExecuteGlassTest()
		{
			var items = this.GetGlassItems<Testground.Model.Glass.Fields.RichText>(
				Const.RichTextID, 
				Const.ItemCount);

            foreach (var item in items)
            {
                var value = item.ContentBody;
            }
        }
	}
}