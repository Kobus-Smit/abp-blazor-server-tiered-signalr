using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace Test.Blazor.Pages
{
    public partial class Index 
    {
        private HubConnection hubConnection;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            if (CurrentUser.IsAuthenticated)
            {
                hubConnection = new HubConnectionBuilder().WithUrl("https://localhost:44334/signalr-hubs/messaging").Build();
                await hubConnection.StartAsync();
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (hubConnection != null)
            {
                await hubConnection.DisposeAsync();
            }
        }
    }
}