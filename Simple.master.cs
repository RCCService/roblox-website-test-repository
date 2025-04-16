using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Web.Base;
using Roblox.Web.Code;

namespace Roblox.Website
{
    public partial class Simple : SimpleMasterPageBase
    {
        protected override void Page_Init(object sender, EventArgs e) { }

        protected override void Page_Load(object sender, EventArgs e)
        {
            RobloxCSS.PageCSS.Add("~/CSS/PartialViews/Navigation.css");
            RobloxScripts.AddJQuery();
            RobloxScripts.AddMicrosoftAjax();
            RobloxScripts.BaseScripts.AddRange(new string[]
            {
                "~/js/jquery.simplemodal-1.3.5.js",
                "~/js/jquery.tipsy.js",
                "~/js/GoogleAnalytics/GoogleAnalyticsEvents.js",
                "~/js/json2.min.js",
                "~/js/jquery.cookie.js",
                "~/js/polyfill/ie7localStorage.js",
                "~/js/DropDownNav.js",
                "~/js/JSErrorTracker.js",
                "~/js/RobloxEventManager.js",
                "~/js/RobloxEventListener.js",
                "~/js/GoogleEventListener.js",
                "~/js/MongoEventListener.js",
                "~/js/SiteTouchEvent.js",
                "~/js/GenericConfirmation.js",
                "~/js/UpsellAdModal.js"
            });
        }
    }
}