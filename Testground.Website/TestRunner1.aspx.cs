using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI;
using Fortis.Model;
using Fortis.Providers;
using Glass.Mapper.Sc;
using Sitecore.Data;
using Testground.Website.TestCases;
using Testground.Website.TestCases.Fields;
using Testground.Website.TestCases.InterfaceMapping;
using Testground.Website.TestCases.IsolationMapping;
using Testground.Website.TestCases.TypeMapping;

namespace Testground.Website
{
	public partial class TestRunner1 : Page
	{
		private IEnumerable<ITestCase> IsolationCases;
		private IEnumerable<ITestCase> FieldCases;

        protected IEnumerable<ITestCaseResult> IsolationResults
        {
            get { return this.IsolationCases; }
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

            this.IsolationCases = new List<ITestCase>
            {
                new GetItemIsolationTestCase(itemFactory,sitecoreContext),
                new GetItemPathIsolationTestCase(itemFactory,sitecoreContext),
                new GetChildrenIsolationTestCase(itemFactory,sitecoreContext),
                new ReadFieldValueIsolationTestCase(itemFactory,sitecoreContext)
            };

            this.FieldCases = new List<ITestCase>
            {
                new SingleLineTextFieldTestCase(itemFactory,sitecoreContext),
                new SingleLineTextFieldTwiceTestCase(itemFactory,sitecoreContext),
                new RichTextFieldTestCase(itemFactory,sitecoreContext),
                new CheckboxFieldTestCase(itemFactory, sitecoreContext),
                new ThreeFieldsTestCase(itemFactory, sitecoreContext)

            };

            foreach (var test in this.IsolationCases)
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