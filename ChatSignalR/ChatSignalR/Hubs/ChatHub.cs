using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userId, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
