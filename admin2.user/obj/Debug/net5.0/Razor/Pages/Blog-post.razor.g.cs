#pragma checksum "C:\ASP.NET\admin2.user\Pages\Blog-post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3ba5fd61eb75206faa147ce7fb26555e249425"
// <auto-generated/>
#pragma warning disable 1591
namespace admin2.user.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog-post")]
    public partial class Blog_post : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n\r\n        \r\n        <h1 class=\"mt-4 mb-3\">\r\n            Post Title\r\n            <small>\r\n                by\r\n                <a href=\"#\">Start Bootstrap</a>\r\n            </small>\r\n        </h1>\r\n\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a href=\"/Index\">Home</a>\r\n            </li>\r\n            <li class=\"breadcrumb-item active\">Blog Home 2</li>\r\n        </ol>\r\n\r\n        <div class=\"row\">\r\n\r\n            \r\n            <div class=\"col-lg-8\">\r\n\r\n                \r\n                <img class=\"img-fluid rounded\" src=\"http://placehold.it/900x300\" alt>\r\n\r\n                <hr>\r\n\r\n                \r\n                <p>Posted on January 1, 2017 at 12:00 PM</p>\r\n\r\n                <hr>\r\n\r\n                \r\n                <p class=\"lead\">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus, vero, obcaecati, aut, error quam sapiente nemo saepe quibusdam sit excepturi nam quia corporis eligendi eos magni recusandae laborum minus inventore?</p>\r\n\r\n                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.</p>\r\n\r\n                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos, doloribus, dolorem iusto blanditiis unde eius illum consequuntur neque dicta incidunt ullam ea hic porro optio ratione repellat perspiciatis. Enim, iure!</p>\r\n\r\n                <blockquote class=\"blockquote\">\r\n                    <p class=\"mb-0\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>\r\n                    <footer class=\"blockquote-footer\">\r\n                        Someone famous in\r\n                        <cite title=\"Source Title\">Source Title</cite>\r\n                    </footer>\r\n                </blockquote>\r\n\r\n                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Error, nostrum, aliquid, animi, ut quas placeat totam sunt tempora commodi nihil ullam alias modi dicta saepe minima ab quo voluptatem obcaecati?</p>\r\n\r\n                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Harum, dolor quis. Sunt, ut, explicabo, aliquam tenetur ratione tempore quidem voluptates cupiditate voluptas illo saepe quaerat numquam recusandae? Qui, necessitatibus, est!</p>\r\n\r\n                <hr>\r\n\r\n                \r\n                <div class=\"card my-4\">\r\n                    <h5 class=\"card-header\">Leave a Comment:</h5>\r\n                    <div class=\"card-body\">\r\n                        <form>\r\n                            <div class=\"form-group\">\r\n                                <textarea class=\"form-control\" rows=\"3\"></textarea>\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                        </form>\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"media mb-4\">\r\n                    <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\" alt>\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">Commenter Name</h5>\r\n                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"media mb-4\">\r\n                    <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\" alt>\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">Commenter Name</h5>\r\n                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.\r\n\r\n                        <div class=\"media mt-4\">\r\n                            <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\" alt>\r\n                            <div class=\"media-body\">\r\n                                <h5 class=\"mt-0\">Commenter Name</h5>\r\n                                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"media mt-4\">\r\n                            <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\" alt>\r\n                            <div class=\"media-body\">\r\n                                <h5 class=\"mt-0\">Commenter Name</h5>\r\n                                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            \r\n            <div class=\"col-md-4\">\r\n\r\n                \r\n                <div class=\"card mb-4\">\r\n                    <h5 class=\"card-header\">Search</h5>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"input-group\">\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"Search for...\">\r\n                            <span class=\"inpug-group-append\">\r\n                                <button class=\"btn btn-secondary\" type=\"button\">Go!</button>\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"card my-4\">\r\n                    <h5 class=\"card-header\">Categories</h5>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6\">\r\n                                <ul class=\"list-unstyled mb-0\">\r\n                                    <li>\r\n                                        <a href=\"#\">Web Design</a>\r\n                                    </li>\r\n                                    <li>\r\n                                        <a href=\"#\">HTML</a>\r\n                                    </li>\r\n                                    <li>\r\n                                        <a href=\"#\">Freebies</a>\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <ul class=\"list-unstyled mb-0\">\r\n                                    <li>\r\n                                        <a href=\"#\">JavaScript</a>\r\n                                    </li>\r\n                                    <li>\r\n                                        <a href=\"#\">CSS</a>\r\n                                    </li>\r\n                                    <li>\r\n                                        <a href=\"#\">Tutorials</a>\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"card my-4\">\r\n                    <h5 class=\"card-header\">Side Widget</h5>\r\n                    <div class=\"card-body\">\r\n                        You can put anything you want inside of these side widgets. They are easy to use, and feature the new Bootstrap 4 card containers!\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n        \r\n\r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
