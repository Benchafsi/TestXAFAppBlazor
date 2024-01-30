using Aqua.EnumerableExtensions;
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

namespace TestXAFAppBlazor.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class WebServiceMessageCtrl : ViewController<DetailView>
    {
        SimpleAction _showMessage;

        public WebServiceMessageCtrl()
        {
            InitializeComponent();

            _showMessage = new SimpleAction(this, "WebServiceShowMessage", PredefinedCategory.View)
            {
                PaintStyle = ActionItemPaintStyle.Caption,
                Caption = "Show Message",
                ToolTip = "Show Message",
                ConfirmationMessage = "Are sure you want to accept the selected parts?"
            };

            _showMessage.Execute += _showMessage_Execute;
        }

        private void _showMessage_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            if (ObjectSpace.ModifiedObjects.Any())
            {
                ObjectSpace.CommitChanges();
            }

            Application.ShowViewStrategy.ShowMessage("Test Message", InformationType.Error);
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();

            _showMessage.Execute -= _showMessage_Execute;
        }
    }
}
