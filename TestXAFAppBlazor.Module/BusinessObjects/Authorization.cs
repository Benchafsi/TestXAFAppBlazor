using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXAFAppBlazor.Module.BusinessObjects
{
    [DefaultProperty(nameof(Username))]
    public class Authorization : BaseObject
    {
        public virtual int UserCode { get; set; }
        public virtual decimal UserCost { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }

        public virtual Setup Setup { get; set; }
        //public virtual WebService WebService { get; set; }
    }
}
