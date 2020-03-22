using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtoxChat_Server.Models;
using Microsoft.AspNetCore.SignalR;

namespace ExtoxChat_Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }
}
