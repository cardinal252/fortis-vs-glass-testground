using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.Fields
{
    public class ThreeFields
    {
        [SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
        public virtual  string NavigationTitle { get; set; }

        [SitecoreField(IBody_FieldConstants.Content_BodyFieldName)]
        public virtual string ContentBody { get; set; }

        [SitecoreField(INavigationConstants.Hide_From_NavigationFieldName)]
        public virtual bool HideFromNavigation { get; set; }
    }
}
