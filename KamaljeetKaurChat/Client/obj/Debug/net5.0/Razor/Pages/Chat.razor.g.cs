#pragma checksum "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4910ed63015d78691c804631b2c8b5f2e6e0cb9"
// <auto-generated/>
#pragma warning disable 1591
namespace KamaljeetKaurChat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using KamaljeetKaurChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\_Imports.razor"
using KamaljeetKaurChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "b-zwi9wjxrnf");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddAttribute(4, "b-zwi9wjxrnf");
            __builder.AddMarkupContent(5, "<label for=\"username\" b-zwi9wjxrnf>\r\n        Name:</label>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "id", "username");
            __builder.AddAttribute(8, "placeholder", "Enter username");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                                                                 userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(11, "b-zwi9wjxrnf");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddAttribute(15, "b-zwi9wjxrnf");
            __builder.OpenElement(16, "label");
            __builder.AddAttribute(17, "for", "msg");
            __builder.AddAttribute(18, "b-zwi9wjxrnf");
            __builder.AddMarkupContent(19, "\r\n        Message:\r\n        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "id", "msg");
            __builder.AddAttribute(22, "size", "50");
            __builder.AddAttribute(23, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                                                                 Addfocus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                                                                                    Removefocus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                               messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(27, "b-zwi9wjxrnf");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n\r\n");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "disabled", 
#nullable restore
#line 23 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "b-zwi9wjxrnf");
            __builder.AddContent(33, "Send ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                  SendMsgToCaller

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "disabled", 
#nullable restore
#line 24 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
                                               !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "b-zwi9wjxrnf");
            __builder.AddContent(39, "Send to others than me ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n<hr b-zwi9wjxrnf>\r\n\r\n");
            __builder.OpenElement(41, "section");
            __builder.AddAttribute(42, "b-zwi9wjxrnf");
            __builder.OpenElement(43, "ul");
            __builder.AddAttribute(44, "id", "messagesList");
            __builder.AddAttribute(45, "b-zwi9wjxrnf");
#nullable restore
#line 29 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "b-zwi9wjxrnf");
            __builder.AddContent(48, 
#nullable restore
#line 31 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "h2");
            __builder.AddAttribute(51, "b-zwi9wjxrnf");
            __builder.AddContent(52, 
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
             userisTyping

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Documents\GitHub\WEB315Assignment_Kamaljeet_Kaur\KamaljeetKaurChat\Client\Pages\Chat.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;
    private string userisTyping;
    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceivingMessageFromAUser", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });
         hubConnection.On<string>("ReceivingWhoIsTyping", (user) =>
        {
           
          var userisTyping  =  $"{user} is typing the message";
           messages.Add( userisTyping);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    async Task Send() =>
    await hubConnection.SendAsync("SendMessage", userInput, messageInput);
    async Task SendMsgToCaller() =>
    await hubConnection.SendAsync("ReceivingMessageFromAUser", userInput);
    async Task Addfocus() =>
    await hubConnection.SendAsync("Added the focus event", userInput);
    async Task Removefocus() =>
    await hubConnection.SendAsync("Applied the blur event", userInput);
    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
