using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestXAFAppBlazor.Module.BusinessObjects
{
    [NavigationItem("BMW Insane Setups")]
    public class Setup: BaseObject
    {
        public virtual string SystemName { get; set; }

        [RuleRegularExpression(@"(((http|https)\://)[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;amp;%\$#\=~])*)|([a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})", CustomMessageTemplate = @"Invalid ""Web Page Address"".")]
        public virtual string PortalServer { get; set; }
        public virtual bool Active { get; set; }
        public virtual SetupStatus Status { get; set; }

        public virtual IList<Authorization> Authorizations { get; set; } =
        new ObservableCollection<Authorization>();
        public virtual IList<WebService> Webservices { get; set; } =
        new ObservableCollection<WebService>();
    }

    public enum SetupStatus
    {
        Running,
        Closed
    }
}
