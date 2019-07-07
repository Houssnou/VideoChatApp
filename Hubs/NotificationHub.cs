using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace VideoChatApp.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task RoomsUpdated(bool flag)
            => await ClientProxyExtensions.SendAsync(Clients.Others, "RoomsUpdated", flag);
    }
}