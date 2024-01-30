using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXAFAppBlazor.Module.BusinessObjects
{
    [Appearance("WebService_MethodVisibility_Show",
        Visibility = ViewItemVisibility.Show,
        TargetItems = nameof(Method),
        Criteria = "Appearence = 1")]

    [Appearance("WebService_MethodVisibility_Hide",
        Visibility = ViewItemVisibility.Hide,
        TargetItems = nameof(Method),
        Criteria = "Appearence = 0")]

    [NavigationItem("BMW Insane Setups")]
    public class WebService : BaseObject
    {
        [RuleRegularExpression(DefaultContexts.Save, @"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$",
            CustomMessageTemplate = "Should be a valid URL")]
        public virtual string Enpoint { get; set; }
        public virtual string Method { get; set; }
        public virtual string Body { get; set; }

        [ImmediatePostData]
        public virtual Appearence Appearence { get; set; }
        public virtual Setup Setup { get; set; }
        [DataSourceCriteria("[Setup.ID] == '@This.Setup.ID' ")]
        public virtual Authorization Authorization { get; set; }
    }

    public enum Appearence
    {
        HideMethod,
        ShowMethod,
    }
}
