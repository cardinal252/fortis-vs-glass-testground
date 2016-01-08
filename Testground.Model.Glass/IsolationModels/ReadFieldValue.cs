using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data;

namespace Testground.Model.Glass.IsolationModels
{
    public class ReadFieldValue
    {
        [SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
        public virtual  string Navigation_Title { get; set; }
    }
}
