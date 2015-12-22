using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.IsolationModels
{

    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis2
    /// </summary>
    [TemplateMapping("{90D0BF78-871A-4D46-BAA0-D5CE0B97C4C1}", "InterfaceMap")]
    public partial interface IReadFieldValue : ICustomItemWrapper
    {
        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        ITextFieldWrapper NavigationTitle { get; }
    }

    [TemplateMapping("{90D0BF78-871A-4D46-BAA0-D5CE0B97C4C1}", "")]
    public partial class ReadFieldValue : CustomItemWrapper, IReadFieldValue
    {
        private Item _item = null;

        public ReadFieldValue(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public ReadFieldValue(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public ReadFieldValue(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public ReadFieldValue(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        public virtual ITextFieldWrapper NavigationTitle
        {
            get { return GetField<TextFieldWrapper>(NavigationItem.FieldNames.NavigationTitle, NavigationItem.IndexFieldNames.NavigationTitle); }
        }
    }
}
