#pragma checksum "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaebeef0b038a866830cf59315c4c5d5d90c588a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                       HandleRegistration

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\t");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n\t\t");
                __builder2.AddMarkupContent(11, "<label for=\"email\">Email</label>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "email");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                           user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\t");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n\t\t");
                __builder2.AddMarkupContent(26, "<label for=\"username\">Username</label>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "id", "username");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                              user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 34, 35, 
#nullable restore
#line 17 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(36, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\t");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n\t\t");
                __builder2.AddMarkupContent(41, "<label for=\"password\">Password</label>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "id", "password");
                __builder2.AddAttribute(44, "type", "password");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                              user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 50, 51, 
#nullable restore
#line 22 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(52, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\t");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n\t\t");
                __builder2.AddMarkupContent(57, "<label for=\"confirmPassword\">Confirm Password</label>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "id", "confirmPassword");
                __builder2.AddAttribute(60, "type", "password");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                                     user.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 27 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\t");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n\t\t");
                __builder2.AddMarkupContent(73, "<label for=\"bio\">Bio</label>\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(74);
                __builder2.AddAttribute(75, "id", "bio");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                             user.Bio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Bio = __value, user.Bio))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Bio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\t");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "\r\n\t\t");
                __builder2.AddMarkupContent(85, "<label for=\"bananas\">Bananas</label>\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateInputNumber_4(__builder2, 86, 87, "bananas", 88, "form-control", 89, 
#nullable restore
#line 35 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                               user.Bananas

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Bananas = __value, user.Bananas)), 91, () => user.Bananas);
                __builder2.AddMarkupContent(92, "\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_5(__builder2, 93, 94, 
#nullable restore
#line 36 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.Bananas

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\t");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n\t\t");
                __builder2.AddMarkupContent(100, "<label for=\"startUnit\">Start Unit</label>\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateInputSelect_6(__builder2, 101, 102, "startUnit", 103, "form-control", 104, 
#nullable restore
#line 40 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                                 user.StartUnitId

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.StartUnitId = __value, user.StartUnitId)), 106, () => user.StartUnitId, 107, (__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n");
#nullable restore
#line 41 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
             foreach (var unit in UnitService.Units)
			{

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(109, "\t\t\t\t");
                    __builder3.OpenElement(110, "option");
                    __builder3.AddAttribute(111, "value", 
#nullable restore
#line 43 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                unit.Id.ToString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(112, 
#nullable restore
#line 43 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                                     unit.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n");
#nullable restore
#line 44 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
			}

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(114, "\t\t");
                }
                );
                __builder2.AddMarkupContent(115, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\t");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group");
                __builder2.AddMarkupContent(119, "\r\n\t\t");
                __builder2.AddMarkupContent(120, "<label for=\"dateOfBirth\">Date of Birth</label>\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateInputDate_7(__builder2, 121, 122, "dateOfBirth", 123, "form-control", 124, 
#nullable restore
#line 49 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                                 user.DateOfBirth

#line default
#line hidden
#nullable disable
                , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.DateOfBirth = __value, user.DateOfBirth)), 126, () => user.DateOfBirth);
                __builder2.AddMarkupContent(127, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n\t");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-check");
                __builder2.AddMarkupContent(131, "\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(132);
                __builder2.AddAttribute(133, "id", "confirmed");
                __builder2.AddAttribute(134, "class", "form-check-input");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                                   user.IsConfirmed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.IsConfirmed = __value, user.IsConfirmed))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => user.IsConfirmed));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n\t\t");
                __builder2.AddMarkupContent(139, "<label for=\"confirmed\">Confirmed</label>\r\n\t\t");
                __Blazor.BlazorBattles.Client.Pages.Register.TypeInference.CreateValidationMessage_8(__builder2, 140, 141, 
#nullable restore
#line 54 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
                                  () => user.IsConfirmed

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(142, "\r\n\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n\t");
                __builder2.AddMarkupContent(144, "<button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Paul Mackay\Desktop\BWAFSB-Intro\BlazorBattles\BlazorBattles\Client\Pages\Register.razor"
       
	BlazorBattles.Shared.UserRegister user = new BlazorBattles.Shared.UserRegister();

	void HandleRegistration()
	{
		NavigationManager.NavigateTo("login");
	}

	protected override async Task OnInitializedAsync()
	{
		await UnitService.LoadUnitsAsync();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IUnitService UnitService { get; set; }
    }
}
namespace __Blazor.BlazorBattles.Client.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
