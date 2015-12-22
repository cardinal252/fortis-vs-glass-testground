using System;
using System.Collections.Generic;
using Fortis.Model;
using Glass.Mapper.Sc;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using StackExchange.Profiling;
using Testground.Model.Glass.Model.Glass;

namespace Testground.Website.TestCases
{
	public abstract class TestCase : ITestCase
	{
		protected readonly IItemFactory FortisService;
		protected readonly ISitecoreContext GlassService;

		public decimal SitecoreResult { get; protected set; }
		public decimal GlassResult { get; protected set; }
		public decimal FortisResult { get; protected set; }
		public abstract string CaseName { get; }

		protected TestCase(IItemFactory fortisService, ISitecoreContext glassService)
		{
			this.FortisService = fortisService;
			this.GlassService = glassService;
		}
		
		public void Execute()
		{
			this.SetUp();

			// Execute and measure glass case
			var profiler = MiniProfiler.Start();
			
			this.ExecuteSitecoreTest();
			
			MiniProfiler.Stop();
			this.SitecoreResult = profiler.DurationMilliseconds;


			profiler = MiniProfiler.Start();

			this.ExecuteGlassTest();

			MiniProfiler.Stop();
			this.GlassResult = profiler.DurationMilliseconds;

			// Execute and measure fortis case
			profiler = MiniProfiler.Start();

			this.ExecuteFortisTest();

			MiniProfiler.Stop();
			this.FortisResult = profiler.DurationMilliseconds;
		}

		protected virtual void SetUp()
		{
		}

		protected abstract void ExecuteSitecoreTest();
		protected abstract void ExecuteFortisTest();
		protected abstract void ExecuteGlassTest();

		protected IEnumerable<Item> GetSitecoreItems(Guid itemId, int count)
		{
			var ret = new List<Item>();

			for (int i = 0; i < count; i++)
			{
				ret.Add(Context.Database.GetItem(new ID(itemId)));
			}

			return ret;
		}

        protected IEnumerable<Item> GetSitecoreItems(string path, int count)
        {
            var ret = new List<Item>();

            for (int i = 0; i < count; i++)
            {
                ret.Add(Context.Database.GetItem(path));
            }

            return ret;
        }

        protected IEnumerable<T> GetGlassItems<T>(Guid itemId, int count)
			where T : class
		{
			var ret = new List<T>();

			for (int i = 0; i < count; i++)
			{
				ret.Add(this.GlassService.GetItem<T>(itemId));
			}

			return ret;
		}
        protected IEnumerable<T> GetGlassItems<T>(string path, int count)
           where T : class
        {
            var ret = new List<T>();

            for (int i = 0; i < count; i++)
            {
                ret.Add(this.GlassService.GetItem<T>(path));
            }

            return ret;
        }

        protected IEnumerable<T> GetFortisItems<T>(Guid itemId, int count) 
			where T : IItemWrapper
		{
			var ret = new List<T>();

			for (int i = 0; i < count; i++)
			{
				ret.Add(this.FortisService.Select<T>(itemId));
			}

			return ret;
		}
        protected IEnumerable<T> GetFortisItems<T>(string path, int count)
            where T : IItemWrapper
        {
            var ret = new List<T>();

            for (int i = 0; i < count; i++)
            {
                ret.Add(this.FortisService.Select<T>(path));
            }

            return ret;
        }
    }
}