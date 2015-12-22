using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.Fields
{
    public class Checkbox
    {
        [SitecoreField(INavigationConstants.Hide_From_NavigationFieldName)]
        public virtual  bool HideFromNavigation { get; set; }
    }
}
