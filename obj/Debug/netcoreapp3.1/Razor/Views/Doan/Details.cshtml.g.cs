#pragma checksum "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\Doan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ff9889655d7875aee607c2b9ae8262ba54b6d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doan_Details), @"mvc.1.0.view", @"/Views/Doan/Details.cshtml")]
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
#line 1 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\_ViewImports.cshtml"
using tour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\_ViewImports.cshtml"
using tour.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ff9889655d7875aee607c2b9ae8262ba54b6d8", @"/Views/Doan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff28e97584599c34362f97f18e157895449dbb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Doan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\huyth\OneDrive\Máy tính\Tour\tour\Views\Doan\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Chi tiết đoàn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""content-wrapper"">
    <section class=""content-header"">
        <div class=""container-fluid"">
          <div class=""row mb-2"">
            <div class=""col-sm-6"">
              <h1>Danh sách đoàn khách</h1>
            </div>
            <div class=""col-sm-6"">
              <ol class=""breadcrumb float-sm-right"">
                <li class=""breadcrumb-item""><a href=""index3.html"">Trang chủ</a></li>
                <li class=""breadcrumb-item active"">Danh sách đoàn</li>
              </ol>
            </div>
          </div>
        </div><!-- /.container-fluid -->
      </section>
      <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
              <div class=""col-12"">
                <ul class=""nav nav-tabs"">
                  <li class=""nav-item"">
                    <a class=""nav-link active"" href=""#"" id=""link-customer"">Danh sách người đi</a>
                  </li>
                  <li class=""nav-item"">
                    <a cl");
            WriteLiteral(@"ass=""nav-link"" href=""#"" id=""link-nv"">Nhân viên</a>
                  </li>
                  <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Thêm chi phí</a>
                  </li>
                </ul>
              </div>
              <div class=""col-12"">
                <div class=""card"" id=""list-customer"">
                  <div class=""card-header"">
                    <div class=""btn-group btn-add"">
                      <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#form-add"">Thêm người đi</button>
                    </div>
                  </div>
                  <!-- /.card-header -->
                  <div class=""card-body"">
                    <table class=""table table-bordered table-hover"" id=""tableXemGiaTour"">
                      <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Tên</th>
                            <th scope=""c");
            WriteLiteral(@"ol"">Số điện thoại</th>
                            <th scope=""col"">Ngày sinh</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">Số chứng minh</th>
                            <th scope=""col"">Thao tác</th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr>
                            <td>D01</td>
                            <td>T01</td>
                            <td>2020-10-12</td>
                            <td>2020-10-16</td>
                            <td>3</td>
                            <td>3</td>
                            <td>
                              <a class=""btn btn-primary btn-sm"" href=""#"">
                                <i class=""fas fa-pencil-alt"">
                                </i>
                                Sửa
                              </a>
                              <a class=""btn btn-danger btn-sm"" href=""#"">
          ");
            WriteLiteral(@"                      <i class=""fas fa-trash""></i>
                              </a>
                            </td>
                          </tr>
                      </tbody>
                    </table>
                  </div>
                  <!-- /.card-body -->
                </div>
                <div class=""card"" id=""list-nv"">
                  <div class=""card-header"">
                    <div class=""col-12"">
                      <div class=""row"">
                        <div class=""col"">
                          <select class=""form-control"" id=""select_tour"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d88110", async() => {
                WriteLiteral("Chọn nhân viên");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d89388", async() => {
                WriteLiteral("Đà lạt - Nha trang");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d810587", async() => {
                WriteLiteral("Nha trang - Đà nẵng - Huế");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d811593", async() => {
                WriteLiteral("Nha trang - Đà nẵng - Huế");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d812599", async() => {
                WriteLiteral("Nha trang - Đà nẵng - Huế");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ff9889655d7875aee607c2b9ae8262ba54b6d813605", async() => {
                WriteLiteral("Nha trang - Đà nẵng - Huế");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </select>
                        </div>
                        <div class=""col"">
                          <button class=""btn btn-primary"">Thêm nhân viên</button>
                        </div>
                      </div>
                      
                    </div>
                  </div>
                  <div class=""card-body"">
                    <table class=""table table-bordered table-hover"" id=""tableXemGiaTour"">
                      <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Tên nhân viên</th>
                            <th scope=""col"">Số điện thoại</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">Nhiệm vụ</th>
                            <th scope=""col"">Thao tác</th>
                          </tr>
                        </thead>
                        <tbody>
                 ");
            WriteLiteral(@"         <tr>
                            <td>D01</td>
                            <td>T01</td>
                            <td>2020-10-12</td>
                            <td>2020-10-16</td>
                            <td>3</td>
                            <td>
                              <a class=""btn btn-danger btn-sm"" href=""#"">
                                <i class=""fas fa-trash""></i>
                              </a>
                            </td>
                          </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
              <!-- /.col -->
            </div>
            <!-- /.row -->
          </div>
      </section>
  </div>
  <!-- /.content-wrapper -->
  <div class=""modal fade"" id=""form-add"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
      <div class=""modal-content"">
        <div class=""modal-header"">
  ");
            WriteLiteral(@"        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm khách hàng</h5>
          <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
          </button>
        </div>
        <div class=""modal-body"">
          <div class=""col-12"">
            <div class=""row"">
                <div class=""col-12 form_tour_"" style=""padding: 20px;"">
                  <div class=""row"">
                    <div class=""col"">
                      <label>Người lớn</label>
                      <input type=""number"" class=""form-control"" value=""1"" id=""nguoi_lon"">
                    </div>
                    <div class=""col"">
                      <label>Trẻ em</label>
                      <input type=""number"" class=""form-control"" value=""0"" id=""tre_em"">
                    </div>
                    <div class=""col"">
                      <label>Số khách</label>
                      <input type=""text"" class=""form-control"" value=""1""");
            WriteLiteral(@" id=""tong_ng_di"" readonly>
                    </div>
                    <div class=""col"">
                        <label>Xử lý</label>
                        <button type=""button"" class=""form-control btn btn-primary"" id=""btn_khach_hang"">Xác nhận</button>
                    </div>
                  </div>
                </div>
                <div class=""col-12 collapse form_list_customer"">
                  <div class=""d-flex justify-content-center"" style=""margin-bottom: 20px;"">
                    <h3 class=""text-danger"">Danh sách khách hàng</h3>
                  </div>
                  <div class=""card"" id=""list_customer_main"">
                    <!-- <ul class=""list-group list-group-flush"">
                      <li class=""list-group-item"">Khách hàng 1</li>
                      <li class=""list-group-item"">
                        <div class=""row"">
                          <div class=""col"">
                            <label>Họ tên</label>
                            <input type");
            WriteLiteral(@"=""text"" class=""form-control"" placeholder=""Nhập họ tên"">
                          </div>
                          <div class=""col"">
                            <label>Số CMND</label>
                            <input type=""text"" class=""form-control"" placeholder=""Nhập số chứng minh"">
                          </div>
                          <div class=""col"">
                            <label>Địa chỉ</label>
                            <input type=""text"" class=""form-control"" placeholder=""Nhập địa chỉ"">
                          </div>
                          <div class=""col"">
                            <label>Số điện thoại</label>
                            <input type=""text"" class=""form-control"" placeholder=""Nhập số điện thoại"">
                          </div>
                          <div class=""col-3"">
                            <label>Ngày sinh</label>
                            <div class=""d-flex justify-content-end"">
                              <select class=""form-control"">");
            WriteLiteral(@"
                                <option value='0' selected='true'>Ngày</option>
                                <option>2</option>
                              </select>
                              <select class=""form-control"">
                                <option value='1' selected='true'>Tháng</option>
                                <option>2</option>
                              </select>
                              <select class=""form-control"">
                                <option value='1' selected='true'>Năm</option>
                                <option>2</option>
                              </select>
                            </div>
                          </div>
                        </div>
                      </li>
                      <li class=""list-group-item"">
                        <div class=""d-flex justify-content-end"">Trị giá :&nbsp
                          <label class=""text-danger"">2.399.000 VNĐ</label>
                        </div>
        ");
            WriteLiteral(@"              </li>
                    </ul> -->
                  </div>
                </div>
            </div>
          </div>
        </div>
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
          <button type=""button"" class=""btn btn-primary"">Lưu</button>
        </div>
      </div>
    </div>
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
