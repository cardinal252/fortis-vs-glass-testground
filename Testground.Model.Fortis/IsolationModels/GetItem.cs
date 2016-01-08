using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Providers;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.IsolationModels
{

    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis1
    /// </summary>
    [TemplateMapping("{05960472-6B77-49F0-AE2E-3C1525A61FD7}", "InterfaceMap")]
    public partial interface IGetItem : ICustomItemWrapper
    {
    }

    [TemplateMapping("{05960472-6B77-49F0-AE2E-3C1525A61FD7}", "")]
    public partial class GetItem : CustomItemWrapper, IGetItem
    {
        private Item _item = null;

        public GetItem(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public GetItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public GetItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public GetItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }
    }
}
