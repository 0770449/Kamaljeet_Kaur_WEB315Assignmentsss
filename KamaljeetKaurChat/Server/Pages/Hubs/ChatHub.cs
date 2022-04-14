using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace KamaljeetKaurChat.Server.Hubs
{
    public class ChatHub : Hub
    {
         public Task SendMessage(string user, string message)
        {

            return Clients.All.SendAsync("ReceivingMessageFromAUser", user, message);
        }
        public Task SendMessageToCaller(string user)
        {
            return Clients.Caller.SendAsync("ReceivingMessageFromAUser", user + " something special");
        }
    }
}