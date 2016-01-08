using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.Fields
{
    public class RichText
    {
        [SitecoreField(IBody_FieldConstants.Content_BodyFieldName)]
        public virtual  string ContentBody { get; set; }
    }
}
