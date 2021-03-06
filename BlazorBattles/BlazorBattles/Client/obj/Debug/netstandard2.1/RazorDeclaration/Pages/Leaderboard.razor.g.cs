// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorBattles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/leaderboard")]
    public partial class Leaderboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Paul Mackay\Desktop\BWAFSB\BlazorBattles\BlazorBattles\Client\Pages\Leaderboard.razor"
          

		int myUserId;

	protected override async Task OnInitializedAsync()
	{
		await LeaderboardService.GetLeaderboard();

		var authState = await AuthStateProvider.GetAuthenticationStateAsync();
		myUserId = int.Parse(authState.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value);
	}

	public string GetMyStyle(int userId)
	{
		if (userId == myUserId)
			return "color: green; font-weight: 600;";
		else
			return string.Empty;
	}

	public async Task StartBattle(int opponentId)
	{
		var result = await BattleService.StartBattle(opponentId);
		if (result.RoundsFought <= 0)
			ToastService.ShowInfo("The battle did not take place.");
		else if (result.IsVictory)
			ToastService.ShowSuccess("You won the battle!");
		else
			ToastService.ShowWarning("You have been defeated!");

		await LeaderboardService.GetLeaderboard();
		await BananaService.GetBananas();

		if (result.RoundsFought > 0)
			NavigationManager.NavigateTo("battlelog");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IBananaService BananaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IBattleService BattleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.ILeaderboardService LeaderboardService { get; set; }
    }
}
#pragma warning restore 1591
