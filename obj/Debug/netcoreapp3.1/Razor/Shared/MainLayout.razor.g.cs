#pragma checksum "/home/mickael/develop/BlazorApp/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7157216654495f1977771b0da7a56fb59bcca325"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/mickael/develop/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mickael/develop/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mickael/develop/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/mickael/develop/BlazorApp/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width: 100%; height: 100vh; background: #eee;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "navigation");
            __builder.AddAttribute(5, "style", "z-index: 999;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenMenu>(7);
            __builder.AddAttribute(8, "Style", "display: flex; justify-content: space-between; width: 100%; padding: 0 12px; align-items: center; z-index: 999;");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "style", "display: flex; align-items: center;");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<div style=\"margin-right: 16px;\">\r\n                    <h1 style=\"font-size: 18px; font-weight: bold; margin-top: 12px; color: gray; cursor: pointer;\">TRACKIT</h1>\r\n                </div>\r\n                \r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenuItem>(15);
                __builder2.AddAttribute(16, "Text", "Ferramentas");
                __builder2.AddAttribute(17, "Icon", "build");
                __builder2.AddAttribute(18, "Style", "z-index: 999;");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(21);
                    __builder3.AddAttribute(22, "Text", "Mapa");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(25);
                        __builder4.AddAttribute(26, "Text", "Editor de mapa");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(28);
                        __builder4.AddAttribute(29, "Text", "Mapa");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(31);
                        __builder4.AddAttribute(32, "Text", "Mapa Histórico");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n                    \r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(35);
                    __builder3.AddAttribute(36, "Text", "Equipamento");
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(38, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(39);
                        __builder4.AddAttribute(40, "Text", "Linha do Tempo");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(42);
                        __builder4.AddAttribute(43, "Text", "Monitor");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        \r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenuItem>(47);
                __builder2.AddAttribute(48, "Text", "Cadastro");
                __builder2.AddAttribute(49, "Icon", "create");
                __builder2.AddAttribute(50, "Style", "z-index: 999;");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(53);
                    __builder3.AddAttribute(54, "Text", "Equipamento");
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(56, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(57);
                        __builder4.AddAttribute(58, "Text", "Alarme");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        \r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenuItem>(62);
                __builder2.AddAttribute(63, "Text", "Relatórios");
                __builder2.AddAttribute(64, "Icon", "description");
                __builder2.AddAttribute(65, "Style", "z-index: 999;");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(68);
                    __builder3.AddAttribute(69, "Text", "Operação");
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(71, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(72);
                        __builder4.AddAttribute(73, "Text", "Equipamento");
                        __builder4.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(75, "\r\n                            ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenMenuItem>(76);
                            __builder5.AddAttribute(77, "Text", "Conferência de Alocação");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(78, "\r\n                        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(79, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n                    \r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMenuItem>(81);
                    __builder3.AddAttribute(82, "Text", "Equipamento");
                    __builder3.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(84, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMenuItem>(85);
                        __builder4.AddAttribute(86, "Text", "Horímetro");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(87, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        \r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMenuItem>(90);
                __builder2.AddAttribute(91, "Text", "Admin");
                __builder2.AddAttribute(92, "Icon", "admin_panel_settings");
                __builder2.AddAttribute(93, "Style", "z-index: 999;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            \r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(96);
                __builder2.AddAttribute(97, "Style", "width: 100%; margin: 0 16px;");
                __builder2.AddAttribute(98, "Placeholder", "Pesquisar ...");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n        \r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenProfileMenu>(100);
                __builder2.AddAttribute(101, "Style", "max-width: 125px;");
                __builder2.AddAttribute(102, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(103, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGravatar>(104);
                    __builder3.AddAttribute(105, "Email", "admin@admin.com");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\r\n                ");
                }
                ));
                __builder2.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(109);
                    __builder3.AddAttribute(110, "Text", "Perfil");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(112);
                    __builder3.AddAttribute(113, "Text", "Sair");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    \r\n    ");
            __builder.AddContent(118, 
#nullable restore
#line 61 "/home/mickael/develop/BlazorApp/Shared/MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(121);
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(123);
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(125);
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(127);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
