using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FishProject.Hubs;

public class FishHub : Hub
{
    public async Task FishUpdate(double x,double y,bool direction)
    {
        await this.Clients.All.SendAsync("FishUpdate",x,y,direction);
    }
}