// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC.Admin
{
    public class SharedController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _AdminLayout = "_AdminLayout";
                public readonly string _FoldersLightBox = "_FoldersLightBox";
                public readonly string _PictureLightBox = "_PictureLightBox";
                public readonly string _PicturesList = "_PicturesList";
            }
            public readonly string _AdminLayout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
            public readonly string _FoldersLightBox = "~/Areas/Admin/Views/Shared/_FoldersLightBox.cshtml";
            public readonly string _PictureLightBox = "~/Areas/Admin/Views/Shared/_PictureLightBox.cshtml";
            public readonly string _PicturesList = "~/Areas/Admin/Views/Shared/_PicturesList.cshtml";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
