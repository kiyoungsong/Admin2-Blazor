#pragma checksum "C:\ASP.NET\admin2.user\Components\Home\SiteListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a4f47ea7cb0de0a3a04984323858d7ed4d2dc54"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace admin2.user.Components.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ASP.NET\admin2.user\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ASP.NET\admin2.user\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ASP.NET\admin2.user\_Imports.razor"
using admin2.user;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ASP.NET\admin2.user\_Imports.razor"
using admin2.user.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ASP.NET\admin2.user\_Imports.razor"
using admin2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ASP.NET\admin2.user\_Imports.razor"
using admin2.user.Components;

#line default
#line hidden
#nullable disable
    public partial class SiteListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\ASP.NET\admin2.user\Components\Home\SiteListComponent.razor"
  

    private List<Site> sites;

    public List<Site> Sites
    {
        get { return sites; }
        set { sites = value; }
    }


    protected override void OnInitialized()
    {
        sites = new List<Site>()
    {
            new Site { Id = 1, Title = "naver", Url = "http://www.naver.com", Description = "네이버" },
            new Site { Id = 2, Title = "google", Url = "http://www.google.com", Description = "구글"  },
            new Site { Id = 3, Title = "daum", Url = "http://www.daum.net", Description = "다음"  },
            new Site { Id = 4, Title = "youtube", Url = "http://www.youtube.com", Description = "유투브"  },
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
