using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.Rendering
{

    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis8
    /// </summary>
    [TemplateMapping("{789AC4B3-29B5-4AC2-9ABF-921B88DBE8BB}", "InterfaceMap")]
    public partial interface IMenu : ICustomItemWrapper
    {

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        ITextFieldWrapper NavigationTitle { get; }

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        IBooleanFieldWrapper HideFromNavigation { get; }
    }


    [TemplateMapping("{789AC4B3-29B5-4AC2-9ABF-921B88DBE8BB}", "")]
    public partial class Menu : CustomItemWrapper, IMenu
    {
        private Item _item = null;

        public Menu(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public Menu(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public Menu(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public Menu(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        public virtual ITextFieldWrapper NavigationTitle
        {
            get { return GetField<TextFieldWrapper>(NavigationItem.FieldNames.NavigationTitle, NavigationItem.IndexFieldNames.NavigationTitle); }
        }

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        public virtual IBooleanFieldWrapper HideFromNavigation
        {
            get { return GetField<BooleanFieldWrapper>(NavigationItem.FieldNames.HideFromNavigation, NavigationItem.IndexFieldNames.HideFromNavigation); }
        }
    }
}
