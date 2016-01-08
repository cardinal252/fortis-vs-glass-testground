using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.Fields
{

    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis6
    /// </summary>
    [TemplateMapping("{162BD956-AF0C-4C19-AC0C-B495E202C7E4}", "InterfaceMap")]
    public partial interface ICheckbox : ICustomItemWrapper
    {

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        IBooleanFieldWrapper HideFromNavigation { get; }
    }


    [TemplateMapping("{162BD956-AF0C-4C19-AC0C-B495E202C7E4}", "")]
    public partial class Checkbox : CustomItemWrapper, ICheckbox
    {
        private Item _item = null;

        public Checkbox(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public Checkbox(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public Checkbox(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public Checkbox(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        public virtual IBooleanFieldWrapper HideFromNavigation
        {
            get { return GetField<BooleanFieldWrapper>(NavigationItem.FieldNames.HideFromNavigation, NavigationItem.IndexFieldNames.HideFromNavigation); }
        }
    }
}
