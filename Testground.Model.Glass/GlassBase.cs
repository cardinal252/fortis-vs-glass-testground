using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Testground.Model.Glass.Model.Glass
{
	public partial class GlassBase
	{
		[SitecoreInfo(SitecoreInfoType.TemplateId)]
		public Guid TemplateId { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Path)]
		public string Path { get; private set; }

		[SitecoreInfo(SitecoreInfoType.DisplayName)]
		public string DisplayName { get; set; }

		[SitecoreInfo(SitecoreInfoType.Name)]
		public string Name { get; set; }

		[SitecoreField("__Created")]
		public DateTime Created { get; set; }

		[SitecoreField("__Updated")]
		public DateTime Updated { get; set; }

		[SitecoreParent(InferType = true, IsLazy = true)]
		public IGlassBase Parent { get; private set; }

		[SitecoreChildren(InferType = true, IsLazy = true)]
		public IEnumerable<IGlassBase> Children { get; private set; }

		public string GenerateUrl()
		{
			return this.Url;
		}
	}
}
