using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestXAFAppBlazor.Module.BusinessObjects;

namespace TestXAFAppBlazor.Module.Controllers
{
    public partial class InitializeAuthCtrl : ObjectViewController<ObjectView, WebService>
    {
        public InitializeAuthCtrl()
        {
            InitializeComponent();
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            var newObjectViewController = Frame.GetController<NewObjectViewController>();
            if (newObjectViewController != null)
            {
                newObjectViewController.ObjectCreated += NewObjectViewController_ObjectCreated;
            }
        }
        private void NewObjectViewController_ObjectCreated(object sender, ObjectCreatedEventArgs e)
        {
            try
            {
                if (e.CreatedObject is WebService record)
                {
                    var newObjectViewController = sender as NewObjectViewController;
                    if (newObjectViewController.Frame is NestedFrame nestedFrame)
                    {
                        var setup = nestedFrame.ViewItem.CurrentObject as Setup;
                        record.Setup = setup;
                    }
                }
            }
            catch (Exception ex)
            {
                Tracing.Tracer.LogError(ex);
                throw new UserFriendlyException(ex);
            }
        }

        protected override void OnDeactivated()
        {
            base.OnDeactivated();
            var newObjectViewController = Frame.GetController<NewObjectViewController>();
            if (newObjectViewController != null)
            {
                newObjectViewController.ObjectCreated -= NewObjectViewController_ObjectCreated;
            }
        }
    }
}
