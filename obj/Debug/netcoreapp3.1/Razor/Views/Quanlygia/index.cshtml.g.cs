#pragma checksum "C:\Users\Hieu\Documents\GitHub\Tour-du-lich\Views\Quanlygia\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13afcab1ab32f358f5e9f9450a0cac6d9b75f258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quanlygia_index), @"mvc.1.0.view", @"/Views/Quanlygia/index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Hieu\Documents\GitHub\Tour-du-lich\Views\_ViewImports.cshtml"
using tour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hieu\Documents\GitHub\Tour-du-lich\Views\_ViewImports.cshtml"
using tour.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13afcab1ab32f358f5e9f9450a0cac6d9b75f258", @"/Views/Quanlygia/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff28e97584599c34362f97f18e157895449dbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Quanlygia_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hieu\Documents\GitHub\Tour-du-lich\Views\Quanlygia\index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Quản lý giá";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""content-wrapper"">
    <section class=""content-header"">
      <div class=""container-fluid"">
        <div class=""row mb-2"">
          <div class=""col-sm-6"">
            <h1>Danh sách giá theo ngày</h1>
          </div>
          <div class=""col-sm-6"">
            <ol class=""breadcrumb float-sm-right"">
              <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
              <li class=""breadcrumb-item active"">Danh sách giá</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>
    <section class=""content"">
      <div class=""container-fluid"">
          <div class=""row"">
            <div class=""col-12"">
              <div class=""card"">
                <div class=""card-header"">
                  <div class=""btn-group btn-add"" role=""group"" aria-label=""Basic example"">
                    <a href=""/Quanlygia/Create"" class=""btn btn-primary"">Thêm giá mới</a>
                  </div>
                </div>
          ");
            WriteLiteral(@"      <!-- /.card-header -->
                <div class=""card-body"">
                  <table class=""table table-bordered table-hover"" id=""tableXemGiaTour"">
                    <thead class=""thead-light"">
                      <tr>
                        <th scope=""col"">Id giá</th>
                        <th scope=""col"">Giá</th>
                        <th scope=""col"">Giá từ</th>
                        <th scope=""col"">Giá đến</th>
                        <th scope=""col"">Hành động</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr>
                        <th>DL001</th>
                        <td>1.500.000 VNĐ</td>
                        <td>2-2-2020</td>
                        <td>5-5-2020</td>
                        <td>
                          <a class=""btn btn-primary btn-sm"" href=""#"">
                            <i class=""fas fa-pencil-alt"">
                            </i>
                            Sửa
    ");
            WriteLiteral(@"                      </a>
                          <a class=""btn btn-danger btn-sm"" href=""#"">
                            <i class=""fas fa-trash""></i>
                          </a>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </div>
                <!-- /.card-body -->
              </div>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
      </div>
    </section>
  </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
