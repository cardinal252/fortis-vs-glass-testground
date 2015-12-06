using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Testground.Model.Glass.Model.Glass
{
	public partial interface IGlassBase
	{
		[SitecoreInfo(SitecoreInfoType.TemplateId)]
		Guid TemplateId { get; }

		[SitecoreInfo(SitecoreInfoType.Path)]
		string Path { get; }

		[SitecoreInfo(SitecoreInfoType.DisplayName)]
		string DisplayName { get; set; }

		[SitecoreInfo(SitecoreInfoType.Name)]
		string Name { get; set; }

		[SitecoreField("__Created")]
		DateTime Created { get; set; }

		[SitecoreField("__Updated")]
		DateTime Updated { get; set; }

		[SitecoreParent(InferType = true, IsLazy = true)]
		IGlassBase Parent { get; }

		[SitecoreChildren(InferType = true, IsLazy = true)]
		IEnumerable<IGlassBase> Children { get; }

		string GenerateUrl();
	}
}
