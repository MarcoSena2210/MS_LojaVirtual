#pragma checksum "C:\Users\msena\Desktop\Sistemas\MS_LojaVirtual\MS_LojaVirtual\MS_LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced3c846dea0ce4c55d78d6fb03f00265b17a05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarrinhoCompras.cshtml", typeof(AspNetCore.Views_Home_CarrinhoCompras))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced3c846dea0ce4c55d78d6fb03f00265b17a05f", @"/Views/Home/CarrinhoCompras.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\msena\Desktop\Sistemas\MS_LojaVirtual\MS_LojaVirtual\MS_LojaVirtual\Views\Home\CarrinhoCompras.cshtml"
  
     ViewData["Title"] = "CarrinhoCompras";

#line default
#line hidden
            BeginContext(54, 12710, true);
            WriteLiteral(@"
<main role=""main"">
     <section class=""container"" id=""order"" style=""margin-top: 50px"">

          <h2 class=""title-doc""># Order </h2>


          <h4 class=""subtitle-doc"">
               # Shopping cart
               <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
          </h4>
          <div id=""code_cart"">
               <div class=""card"">
                    <table class=""table table-hover shopping-cart-wrap"">
                         <thead class=""text-muted"">
                              <tr>
                                   <th scope=""col"">Product</th>
                                   <th scope=""col"" width=""120"">Quantity</th>
                                   <th scope=""col"" width=""120"">Price</th>
                                   <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                              </tr>
                         </thead>
                         <tbody>
                              <tr>
                              ");
            WriteLiteral(@"     <td>
                                        <figure class=""media"">
                                             <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                             <figcaption class=""media-body"">
                                                  <h6 class=""title text-truncate"">Product name goes here </h6>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Size: </dt>
                                                       <dd>XXL</dd>
                                                  </dl>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Color: </dt>
                                                       <dd>Orange color</dd>
                                                  </dl>
                                             </figcap");
            WriteLiteral(@"tion>
                                        </figure>
                                   </td>
                                   <td>
                                        <select class=""form-control"">
                                             <option>1</option>
                                             <option>2</option>
                                             <option>3</option>
                                             <option>4</option>
                                        </select>
                                   </td>
                                   <td>
                                        <div class=""price-wrap"">
                                             <var class=""price"">USD 145</var>
                                             <small class=""text-muted"">(USD5 each)</small>
                                        </div> <!-- price-wrap .// -->
                                   </td>
                                   <td class=""text-right"">
       ");
            WriteLiteral(@"                                 <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                        <a href="""" class=""btn btn-outline-danger""> × Remove</a>
                                   </td>
                              </tr>
                              <tr>
                                   <td>
                                        <figure class=""media"">
                                             <div class=""img-wrap""><img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                             <figcaption class=""media-body"">
                                                  <h6 class=""title text-truncate"">Product name goes here </h6>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Size: </dt>
     ");
            WriteLiteral(@"                                                  <dd>XXL</dd>
                                                  </dl>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Color: </dt>
                                                       <dd>Orange color</dd>
                                                  </dl>
                                             </figcaption>
                                        </figure>
                                   </td>
                                   <td>
                                        <select class=""form-control"">
                                             <option>1</option>
                                             <option>2</option>
                                             <option>3</option>
                                             <option>4</option>
                                        </select>
                                   <");
            WriteLiteral(@"/td>
                                   <td>
                                        <div class=""price-wrap"">
                                             <var class=""price"">USD 35</var>
                                             <small class=""text-muted"">(USD10 each)</small>
                                        </div> <!-- price-wrap .// -->
                                   </td>
                                   <td class=""text-right"">
                                        <a title="""" href="""" class=""btn btn-outline-success"" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                        <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                   </td>
                              </tr>
                              <tr>
                                   <td>
                                        <figure class=""media"">
         ");
            WriteLiteral(@"                                    <div class=""img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                             <figcaption class=""media-body"">
                                                  <h6 class=""title text-truncate"">Product name goes here </h6>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Size: </dt>
                                                       <dd>XXL</dd>
                                                  </dl>
                                                  <dl class=""dlist-inline small"">
                                                       <dt>Color: </dt>
                                                       <dd>Orange color</dd>
                                                  </dl>
                                             </figcaption>
                                        </figure>
                          ");
            WriteLiteral(@"         </td>
                                   <td>
                                        <select class=""form-control"">
                                             <option>1</option>
                                             <option>2</option>
                                             <option>3</option>
                                             <option>4</option>
                                        </select>
                                   </td>
                                   <td>
                                        <div class=""price-wrap"">
                                             <var class=""price"">USD 45</var>
                                             <small class=""text-muted"">(USD15 each)</small>
                                        </div> <!-- price-wrap .// -->
                                   </td>
                                   <td class=""text-right"">
                                        <a title="""" href="""" class=""btn btn-outline-success""");
            WriteLiteral(@" data-toggle=""tooltip""
                                           data-original-title=""Save to Wishlist""><i class=""fa fa-heart""></i></a>
                                        <a href="""" class=""btn btn-outline-danger btn-round""> × Remove</a>
                                   </td>
                              </tr>
                         </tbody>
                    </table>
               </div> <!-- card.// -->
          </div> <!-- code-wrap.// -->
     </section>
     <br />
     <br />
     <section class=""container"">
          <div class=""row"">
               <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                         # Cálculo de frete
                         <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_simple"">
                         <div class=""box"">
                              <dl>
                                   <dt>Some info: </dt>
       ");
            WriteLiteral(@"                            <dd>
                                        Dolor sit amet, consectetur adipisicing elit do eiusmod
                                        tempor incididunt
                                   </dd>
                              </dl>
                              <dl>
                                   <dt>Parameter: </dt>
                                   <dd>Value name</dd>
                              </dl>
                              <dl>
                                   <dt>Discount:</dt>
                                   <dd>USD 658</dd>
                              </dl>
                         </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
               </aside>
               <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                         # Cupom desconto
                         <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                    </h4>
            ");
            WriteLiteral(@"        <div id=""code_desc_align"">
                         <div class=""box"">
                              <dl class=""dlist-align"">
                                   <dt>Some info: </dt>
                                   <dd> Everything in this life is always tempporary</dd>
                              </dl>
                              <dl class=""dlist-align"">
                                   <dt>Parameter: </dt>
                                   <dd>Value name</dd>
                              </dl>
                              <dl class=""dlist-align"">
                                   <dt>Color:</dt>
                                   <dd>Orange and Black</dd>
                              </dl>
                              <dl class=""dlist-align"">
                                   <dt>Material:</dt>
                                   <dd>Leather</dd>
                              </dl>
                         </div> <!-- box.// -->
                    </div> <!-- code-wra");
            WriteLiteral(@"p.// -->
               </aside>
               <aside class=""col-md-4"">
                    <h4 class=""subtitle-doc"">
                         # Total a pagar
                         <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                    </h4>
                    <div id=""code_desc_right"">
                         <div class=""box"">
                              <dl class=""dlist-align"">
                                   <dt>Parameter: </dt>
                                   <dd class=""text-right"">Value name</dd>
                              </dl>
                              <dl class=""dlist-align"">
                                   <dt>Color:</dt>
                                   <dd class=""text-right"">Orange and Black</dd>
                              </dl>
                              <dl class=""dlist-align"">
                                   <dt>Material:</dt>
                                   <dd class=""text-right"">Leather</dd>
            ");
            WriteLiteral(@"                  </dl>
                              <dl class=""dlist-align"">
                                   <dt>Total cost: </dt>
                                   <dd class=""text-right h5 b""> USD195 </dd>
                              </dl>
                         </div> <!-- box.// -->
                    </div> <!-- code-wrap.// -->
               </aside>
          </div>
     </section>

</main>");
            EndContext();
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
