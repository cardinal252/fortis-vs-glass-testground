using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Providers;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.IsolationModels
{

    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis3
    /// </summary>
    [TemplateMapping("{E8F2474F-659E-4B64-BEA5-A7BC6879EFF7}", "InterfaceMap")]
    public partial interface IGetChildren : ICustomItemWrapper
    {
    }

    [TemplateMapping("{E8F2474F-659E-4B64-BEA5-A7BC6879EFF7}", "")]
    public partial class GetChildren : CustomItemWrapper, IGetChildren
    {
        private Item _item = null;

        public GetChildren(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public GetChildren(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public GetChildren(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public GetChildren(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }
    }
}
