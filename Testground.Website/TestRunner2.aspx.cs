using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI;
using Fortis.Model;
using Fortis.Providers;
using Glass.Mapper.Sc;
using Sitecore.Data;
using Testground.Model.Fortis.Rendering;
using Testground.Website.TestCases;
using Testground.Website.TestCases.Fields;
using Testground.Website.TestCases.InterfaceMapping;
using Testground.Website.TestCases.IsolationMapping;
using Testground.Website.TestCases.Rendering;
using Testground.Website.TestCases.TypeMapping;

namespace Testground.Website
{
	public partial class TestRunner2 : Page
	{
		private IEnumerable<ITestCase> RenderingCases;
		private IEnumerable<ITestCase> FieldCases;

        protected IEnumerable<ITestCaseResult> RenderingResults
        {
            get { return this.RenderingCases; }
        }
        protected IEnumerable<ITestCaseResult> FieldResults
        {
            get { return this.FieldCases; }
        }

        protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            // Make sure context site and database are set to required values
            Sitecore.Context.SetActiveSite(Const.ContextSiteName);
			Sitecore.Context.Database = Database.GetDatabase(Const.DatabaseName);

			var sitecoreContext = new SitecoreContext();
			var itemFactory = DependencyResolver.Current.GetService<IItemFactory>();
			var spawnProvider = DependencyResolver.Current.GetService<ISpawnProvider>();

            this.RenderingCases = new List<ITestCase>
            {
                new MenuRenderingTestCase(itemFactory, sitecoreContext)
            };

            this.FieldCases = new List<ITestCase>
            {

            };

            foreach (var test in this.RenderingCases)
            {
                test.Execute();
            }
            foreach (var test in this.FieldCases)
            {
                test.Execute();
            }
        }
	}
}