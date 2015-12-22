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
    /// This uses template /sitecore/templates/User Defined/FakeFortisTemplates/FakeFortis5
    /// </summary>
    [TemplateMapping("{CC8C7F69-EC8A-4A56-98A7-2972AC9A87A0}", "InterfaceMap")]
    public partial interface IRichText : ICustomItemWrapper
    {
        [IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
        IRichTextFieldWrapper ContentBody { get; }
    }

    [TemplateMapping("{CC8C7F69-EC8A-4A56-98A7-2972AC9A87A0}", "")]
    public partial class RichText : CustomItemWrapper, IRichText
    {
        private Item _item = null;

        public RichText(ISpawnProvider spawnProvider) : base(null, spawnProvider)
        {
        }

        public RichText(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public RichText(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
            : base(id, lazyFields, spawnProvider)
        {
        }

        public RichText(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        [IndexField(BodyFieldItem.IndexFieldNames.ContentBody)]
        public virtual IRichTextFieldWrapper ContentBody
        {
            get { return GetField<RichTextFieldWrapper>(BodyFieldItem.FieldNames.ContentBody, BodyFieldItem.IndexFieldNames.ContentBody); }
        }
    }
}
