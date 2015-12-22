using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore.ContentSearch;
using Sitecore.Data.Items;
using Testground.Model.Fortis.Templates.UserDefined;

namespace Testground.Model.Fortis.Fields
{
    /// <summary>
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis7
    /// </summary>
    [TemplateMapping("{DF1BD86D-48EC-4424-8F65-A25FB1DD10FD}", "InterfaceMap")]
    public partial interface IThreeFields : ICustomItemWrapper
    {

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        IBooleanFieldWrapper HideFromNavigation { get; }

        [IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
        IRichTextFieldWrapper ContentBody { get; }

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        ITextFieldWrapper NavigationTitle { get; }
    }


    [TemplateMapping("{DF1BD86D-48EC-4424-8F65-A25FB1DD10FD}", "")]
    public partial class ThreeFields : CustomItemWrapper, IThreeFields
    {
        private Item _item = null;

        public ThreeFields(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public ThreeFields(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public ThreeFields(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public ThreeFields(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        [IndexField(NavigationItem.IndexFieldNames.HideFromNavigation)]
        public virtual IBooleanFieldWrapper HideFromNavigation
        {
            get { return GetField<BooleanFieldWrapper>(NavigationItem.FieldNames.HideFromNavigation, NavigationItem.IndexFieldNames.HideFromNavigation); }
        }

        [IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
        public virtual IRichTextFieldWrapper ContentBody
        {
            get { return GetField<RichTextFieldWrapper>(BodyFieldItem.FieldNames.ContentBody, BodyFieldItem.IndexFieldNames.ContentBody); }
        }

        [IndexField(NavigationItem.IndexFieldNames.NavigationTitle)]
        public virtual ITextFieldWrapper NavigationTitle
        {
            get { return GetField<TextFieldWrapper>(NavigationItem.FieldNames.NavigationTitle, NavigationItem.IndexFieldNames.NavigationTitle); }
        }
    }
}
