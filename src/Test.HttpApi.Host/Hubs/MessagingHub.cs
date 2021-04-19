using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;

namespace Test.Hubs
{
    public class MessagingHub : AbpHub
    {
        public override Task OnConnectedAsync()
        {
            var currentUserName = CurrentUser.UserName; //Access to the current user info
            return base.OnConnectedAsync();
        }

        public async Task SendMessage(string targetUserName, string message)
        {
            var tenantId = Context?.User?.FindFirst("tenantid")?.Value;
            var currentUserName = CurrentUser.UserName; //Access to the current user info
        }

    }
}