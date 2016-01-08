using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.Renderings
{
    public class Menu
    {
        [SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
        public virtual  string NavigationTitle { get; set; }

       [SitecoreInfo(SitecoreInfoType.Url)]
       public virtual string Url { get; set; }

        [SitecoreField(INavigationConstants.Hide_From_NavigationFieldName)]
        public virtual bool HideFromNavigation { get; set; }

        public virtual IEnumerable<Menu> Children { get; set; } 
    }
}
