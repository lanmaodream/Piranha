﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Account
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Account/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Manager\Views\Account\Index.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Account.Title ;
    Layout = "" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"content-type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral("/>\r\n    <title>");

            
            #line 9 "..\..\Areas\Manager\Views\Account\Index.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 235), Tuple.Create("\"", 287)
, Tuple.Create(Tuple.Create("", 242), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 242), false)
);

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 331), Tuple.Create("\"", 383)
, Tuple.Create(Tuple.Create("", 338), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/img/icon.ico")
, 338), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral("> \r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 437), Tuple.Create("\"", 494)
, Tuple.Create(Tuple.Create("", 444), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/css/style.min.css")
, 444), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral("/>\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 568), Tuple.Create("\"", 633)
, Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/jquery-1.7.2.min.js")
, 574), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 680), Tuple.Create("\"", 739)
, Tuple.Create(Tuple.Create("", 686), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.manager.js")
, 686), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            $("".message"").click(function () { $(this).fadeOut(""medium""); });

            if ($(""#sysMsg"").text() != """") {
                floatBox.show(""boxMessage"");
            }

            $(""#login"").focus();
        });
    </script>
</head>
<body>
    <div");

WriteLiteral(" class=\"container_12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"grid_4 box login\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><small>");

            
            #line 32 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                                  Write("v" + ViewBag.Version);

            
            #line default
            #line hidden
WriteLiteral("</small><h2>");

            
            #line 32 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                                                                     Write(Piranha.Resources.Account.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n            <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                   Html.BeginForm("login", "account") ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Areas\Manager\Views\Account\Index.cshtml"
           Write(Html.Hidden("returnaction", "index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\Areas\Manager\Views\Account\Index.cshtml"
           Write(Html.Hidden("returncontroller", "page"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                    <li><label>");

            
            #line 38 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                          Write(Piranha.Resources.Account.Username);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral("><input");

WriteLiteral(" id=\"login\"");

WriteLiteral(" name=\"login\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" /></div></li>\r\n                    <li><label>");

            
            #line 40 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                          Write(Piranha.Resources.Account.Password);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral("><input");

WriteLiteral(" name=\"password\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" /></div></li>\r\n                </ul>\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn right\"");

WriteLiteral(">");

            
            #line 43 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                                                   Write(Piranha.Resources.Account.Login);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 44 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"boxMessage\"");

WriteLiteral(" class=\"floatbox\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bg\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 52 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                              Write(Piranha.Resources.Global.PopupMessageTitle);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n            <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(" style=\"width: 360px;min-height:60px;text-align:center\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" id=\"sysMsg\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Manager\Views\Account\Index.cshtml"
                          Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
