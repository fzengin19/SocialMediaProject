using Entities.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
        public async Task SendGroupMessage(GroupMessageSendDto sendGroupMessageDto)
        => await Clients.All.SendAsync("ReceiveGroupMessage",sendGroupMessageDto);


        public async Task Login(GroupMessageSendDto sendGroupMessageDto)
        {
            
        }

    }
}
