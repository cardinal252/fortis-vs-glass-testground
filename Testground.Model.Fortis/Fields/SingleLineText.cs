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
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis4
    /// </summary>
    [TemplateMapping("{4EE6BCD3-EBE3-4DC5-811C-0A6C2161B69B}", "InterfaceMap")]
    public partial interface ISingleLineText : ICustomItemWrapper
    {

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        ITextFieldWrapper NavigationTitle { get; }
    }


    [TemplateMapping("{4EE6BCD3-EBE3-4DC5-811C-0A6C2161B69B}", "")]
    public partial class SingleLineText : CustomItemWrapper, ISingleLineText
    {
        private Item _item = null;

        public SingleLineText(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public SingleLineText(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public SingleLineText(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public SingleLineText(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
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
