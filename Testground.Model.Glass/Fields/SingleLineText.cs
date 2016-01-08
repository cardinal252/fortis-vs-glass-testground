using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.Fields
{
    public class SingleLineText
    {
        [SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
        public virtual  string NavigationTitle { get; set; }
    }
}
